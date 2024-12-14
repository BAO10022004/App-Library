using App_Library.Services;
using App_Library.Views.ToolerForm;
using Firebase.Auth;
using Guna.UI2.WinForms;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace App_Library.Views.SignIn
{
    public partial class GoogleLoginForm : Form
    {
        private string clientId = "399731708640-c3s7bv2pqmba4rk388mdknfqn1ffn4ti.apps.googleusercontent.com";
        private string clientSecret = "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";
        private string redirectUri = "http://localhost"; // Thay bằng Redirect URI bạn đã cấu hình
        public string AuthorizationCode { get; private set; }
        private string tokenEndpoint = "https://oauth2.googleapis.com/token";

        private AuthService authService;

        public GoogleLoginForm()
        {
            InitializeComponent();
            authService = new AuthService();
            webViewGoogle.SourceChanged += WebViewGoogle_SourceChanged;
        }

        private void GoogleLoginForm_Load(object sender, EventArgs e)
        {
            string authorizationUrl = $"https://accounts.google.com/o/oauth2/v2/auth?" +
                                      $"client_id={clientId}" +
                                      $"&redirect_uri={redirectUri}" +
                                      $"&response_type=code" +
                                      $"&scope=openid%20email%20profile";

            webViewGoogle.Source = new Uri(authorizationUrl); // Điều hướng đến trang đăng nhập Google
        }


        private void WebViewGoogle_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            if (webViewGoogle.Source.ToString().StartsWith(redirectUri))
            {
                var query = HttpUtility.ParseQueryString(new Uri(webViewGoogle.Source.ToString()).Query);
                AuthorizationCode = query["code"];

                if (!string.IsNullOrEmpty(AuthorizationCode))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
        public async Task<string> ExchangeCodeForIdTokenAsync(string code)
        {
            var client = new HttpClient();
            var response = await client.PostAsync(tokenEndpoint,
                new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("code", code),
                    new KeyValuePair<string, string>("client_id", clientId),
                    new KeyValuePair<string, string>("client_secret", clientSecret),
                    new KeyValuePair<string, string>("redirect_uri", redirectUri),
                    new KeyValuePair<string, string>("grant_type", "authorization_code")
                }));

            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            var tokenData = JsonSerializer.Deserialize<JsonDocument>(responseBody);
            return tokenData.RootElement.GetProperty("id_token").GetString();
        }
        public GoogleLoginRequest DecodeIdToken(string idToken)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(idToken) as JwtSecurityToken;

            // Lấy các claim cần thiết từ token
            var claims = jsonToken.Claims.ToDictionary(claim => claim.Type, claim => claim.Value);

            // Ví dụ, lấy email, name, và picture
            GoogleLoginRequest googleLoginRequest = new GoogleLoginRequest();
            googleLoginRequest.Email = claims["email"];
            googleLoginRequest.Name = claims["name"];
            googleLoginRequest.GooglePhotoURL = claims["picture"];

            return googleLoginRequest;
        }
        public async Task<bool> GoogleSignInAndSaveUserAsync(SplashForm sp)
        {
            using (var loginForm = new GoogleLoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Tạo LoadingForm
                    LoadingForm loadingForm = new LoadingForm();

                    // Tạo thread và gọi công việc trong thread phụ
                    Thread thread1 = new Thread(() =>
                    {
                        // Kiểm tra xem thread này có phải là UI thread không
                        if (loadingForm.InvokeRequired)
                        {
                            // Sử dụng Invoke để gọi ShowDialog từ UI thread
                            loadingForm.Invoke(new Action(() =>
                            {
                                loadingForm.ShowDialog();
                            }));
                        }
                        else
                        {
                            // Nếu đã ở trên UI thread, có thể gọi trực tiếp
                            loadingForm.ShowDialog();
                        }
                    });

                    // Bắt đầu thread
                    thread1.Start();

                    // Thực hiện các thao tác tiếp theo như đăng nhập và lưu người dùng
                    var idToken = await ExchangeCodeForIdTokenAsync(loginForm.AuthorizationCode);
                    var googleLoginRequest = DecodeIdToken(idToken);
                    var result = await authService.GoogleLoginAsync(googleLoginRequest);

                    // Ẩn LoadingForm sau khi hoàn thành công việc
                    loadingForm.Invoke(new Action(() => loadingForm.Hide()));

                    (new AlertSuccess("Success")).ShowDialog();

                    // Đảm bảo đóng LoadingForm sau khi sử dụng
                    loadingForm.Close();

                    return result;
                }
            }
            (new AlertFail("Login Fail")).ShowDialog();
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
