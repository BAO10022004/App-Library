using App_Library.Models;
using App_Library.Services;
using System;
using Firebase.Storage;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using User = App_Library.Models.User;
using FirebaseAdmin.Auth;
using Firebase.Auth;
using App_Library.Views.Orthers.CollectionProfile;
using App_Library.Views.ToolerForm;
using FirebaseAuth = FirebaseAdmin.Auth.FirebaseAuth;


namespace App_Library.Views.Orthers.CollectionEditProfile
{
    public partial class EditprofileForm : FormHelper
    {
        private User currentUser;
        private UserService _userService;
        private static readonly string firebaseStorageUrl = "https://firebasestorage.googleapis.com/v0/b/reading-book-web.appspot.com/o/";
        private static readonly string filePath = @"path\to\your\image.jpg";  // Đường dẫn đến file ảnh
        UpdateUserDTO updateBookDTO = new UpdateUserDTO();
        ProfileForm parent;
        private static readonly string fileName = "image.jpg";
        string pathImage = "";
        public EditprofileForm(ProfileForm parent)
        {
            InitializeComponent();
            _userService = new UserService();
            this.parent = parent;
        }
        private async void EditprofileForm_Load(object sender, EventArgs e)
        {
            currentUser = await _userService.GetCurrentUserAsync();
            txtName.Text = currentUser.Username;
            txtEmail.Text = currentUser.Email;
            try
            {
                picAvatar.Load(currentUser.PhotoURL);

            }
            catch (Exception ex)
            {
            }
            updateBookDTO.PhotoURL = currentUser.PhotoURL;
            updateBookDTO.Email = currentUser.Email;
            updateBookDTO.Username = currentUser.Username;
            updateBookDTO.PasswordHash = currentUser.PasswordHash;
            if (Program.checkLoginGG)
            {
                txtEmail.Enabled = true;
                txtEmail.ReadOnly = true;
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form actForm;
        private async void btnSave_Click(object sender, EventArgs e)
        {
            updateBookDTO.Email = txtEmail.Text;
            updateBookDTO.Username = txtName.Text;
            await _userService.UpdateUserAsync(currentUser.Id, updateBookDTO);
            activeFormChild(this, new ProfileForm(parent.mainForm), null, ref actForm);
        }

        private void btnChangeAvartar_Click(object sender, EventArgs e)
        {

        }

        private async void picEdit_Click(object sender, EventArgs e)
        {
            // Hiển thị OpenFileDialog để chọn file
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select File to Upload";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    FirebaseAuth auth = FirebaseAuth.DefaultInstance;
                    var user = currentUser;
                    string idToken = user.Id; // Lấy ID token của người dùng đã đăng nhập

                    // Kết nối tới Firebase Storage
                    var firebaseStorage = new FirebaseStorage(
                        "reading-book-web.appspot.com", // Tên bucket Firebase Storage của bạn
                        new FirebaseStorageOptions
                        {
                            AuthTokenAsyncFactory = () => Task.FromResult(idToken), // Cung cấp token xác thực cho Firebase Storage
                        });

                    // Lấy tên file từ đường dẫn file
                    string fileName = Path.GetFileName(filePath);

                    try
                    {
                        // Upload file lên Firebase Storage
                        var uploadTask = firebaseStorage
                            .Child("uploads")  // Đường dẫn nơi lưu file (có thể là thư mục uploads hoặc khác)
                            .Child(fileName)
                            .PutAsync(File.Open(filePath, FileMode.Open));

                        // Chờ tải lên hoàn tất
                        var downloadUrl = await uploadTask;

                        // Hiển thị URL tải về của file
                        MessageBox.Show("File uploaded successfully: " + downloadUrl);
                        updateBookDTO.PhotoURL = downloadUrl;
                        try
                        {
                            using (HttpClient client = new HttpClient())
                            {
                                var imageBytes = await client.GetByteArrayAsync(downloadUrl);
                                using (var ms = new System.IO.MemoryStream(imageBytes))
                                {
                                    picAvatar.Image = System.Drawing.Image.FromStream(ms);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("LOI");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error uploading file: " + ex.Message);
                    }
                }

            }
        }
        public static async Task<String> UploadImageToFirebase(string localFilePath, string fileName)
        {
            using (HttpClient client = new HttpClient())
            {
                var fileContent = new ByteArrayContent(File.ReadAllBytes(localFilePath));
                fileContent.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");

                var url = $"{firebaseStorageUrl}?name={Uri.EscapeDataString(fileName)}";

                var request = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    Content = fileContent
                };

                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Tải tệp lên Firebase thành công!");
                }
                else
                {
                    Console.WriteLine($"Lỗi khi tải tệp lên Firebase: {response.ReasonPhrase}");
                }
                return url;
            }
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
