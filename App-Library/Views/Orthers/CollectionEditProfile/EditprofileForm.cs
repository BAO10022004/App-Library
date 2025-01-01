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
using System.Text.RegularExpressions;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace App_Library.Views.Orthers.CollectionEditProfile
{
    public partial class EditprofileForm : FormHelper
    {
        private User currentUser;
        private UserService _userService;
        //private static readonly string firebaseStorageUrl = "https://firebasestorage.googleapis.com/v0/b/reading-book-web.appspot.com/o/";
        //private static readonly string filePath = @"path\to\your\image.jpg";  // Đường dẫn đến file ảnh
        UpdateUserDTO updateBookDTO = new UpdateUserDTO();
        NewProfileForm parent;
        //private static readonly string fileName = "image.jpg";
        //string pathImage = "";

        public EditprofileForm(NewProfileForm parent)
        {
            InitializeComponent();
            _userService = new UserService();
            this.parent = parent;
        }
        private  async void EditprofileForm_Load(object sender, EventArgs e)
        {
            currentUser = await _userService.GetCurrentUserAsync();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageBytes = await client.GetByteArrayAsync(currentUser.PhotoURL);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        picAvatar.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {
            }
            txbEmail.Text = Session.CurentUser.Email;
            txbUsername.Text = Session.CurentUser.Username;
           

            updateBookDTO.PhotoURL = currentUser.PhotoURL;
            updateBookDTO.Email = currentUser.Email;
            updateBookDTO.Username = currentUser.Username;
            updateBookDTO.PasswordHash = currentUser.PasswordHash;

            if (Program.checkLoginGG)
            {
                txbEmail.Enabled = true;
                txbEmail.ReadOnly = true;
            }
        }
        
        Form actForm;
        private async void btnSave_Click(object sender, EventArgs e)
        {
            currentUser =await( new UserService()).GetCurrentUserAsync();
            
            if(!txbUsername.Text.Equals(currentUser.Username) && !txbEmail.Text.Equals(currentUser.Email))
            {
                bool checkMail = true;
                LoadingForm loadingForm = new LoadingForm();

                loadingForm.Show();
                bool checkUsername = await checkUsernameOutLimit(currentUser, txbUsername.Text);
                // check Mail
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                checkMail = Regex.IsMatch(txbEmail.Text, emailPattern);
                if (!checkMail)
                {
                    // Đóng LoadingForm khi thành công
                    loadingForm.Hide();
                    loadingForm.Close();
                    txbEmail.BorderColor = Color.Red;
                    (new AlertFail(" Fail" + "\n" + "Email format incorrect")).ShowDialog();
                }
                if (!checkUsername)
                {
                    loadingForm.Hide();
                    loadingForm.Close();
                    txbUsername.BorderColor = Color.Red;
                    (new AlertFail(" Fail" + "\n" + "Username is exist")).ShowDialog();
                }
                if (checkMail && checkUsername)
                {
                    bool confirm = false;
                    using (var alert = (new AlertConfirm()))
                    {
                        alert.ShowDialog();
                        confirm = alert.ConfirmResult;
                    }
                    loadingForm.Hide();
                    loadingForm.Close();
                    if (confirm)
                    {
                        
                        updateBookDTO.Email = txbEmail.Text;
                        updateBookDTO.Username = txbUsername.Text;
                        if (await _userService.UpdateUserAsync(currentUser.Id, updateBookDTO))
                        {
                            Program.sp.Hide();
                            Program.sp = new SplashForm();
                            Program.sp.ShowDialog();
                        }
                    }
                }
                txbUsername.Text = currentUser.Username;
                txbEmail.Text = currentUser.Email;
            }
            
        }

        public static async Task<bool> checkUsernameOutLimit(User _user, string username)
        {
            string usernameCurrent = _user.Username;
            string passwordCurrent = _user.PasswordHash;
            string idCurrent = _user.Id;
            AuthService db = new AuthService();
            bool result = await db.Login("testappuser", "$2a$11$1OI6fJlj5s/4jQYeGEmFqucoLhIUaJlcKjl./EvToy7Fjq.jWpzUG", null);
            if (!result)
            {
                await db.Login(usernameCurrent, passwordCurrent, null);
                return false;
            }
            else
            {
                var listAccount = await (new UserService()).GetUsersAsync();
                foreach (var user in listAccount)
                {
                    if (user.Username.Equals(username) &&! user.Id.Equals(idCurrent))
                    {
                        await db.Login(usernameCurrent, passwordCurrent, null);
                        return false;
                    }
                }
                await db.Login(usernameCurrent, passwordCurrent, null);
                return true;
            }
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
                        (new AlertSuccess("Save success")).ShowDialog();
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

        Form actForm2;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            activeFormChild(parent.mainForm.pnContent, new NewProfileForm(parent), null, ref actForm2);
        }
    }
}
