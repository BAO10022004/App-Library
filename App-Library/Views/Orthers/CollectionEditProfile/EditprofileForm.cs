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


namespace App_Library.Views.Orthers.CollectionEditProfile
{
    public partial class EditprofileForm : FormHelper
    {
        private User currentUser;
        private UserService _userService;
        private static readonly string firebaseStorageUrl = "https://firebasestorage.googleapis.com/v0/b/reading-book-web.appspot.com/o/";
        private static readonly string filePath = @"path\to\your\image.jpg";  // Đường dẫn đến file ảnh
        UpdateUserDTO updateBookDTO = new UpdateUserDTO();
        NewProfileForm parent;
        private static readonly string fileName = "image.jpg";
        string pathImage = "";
        public EditprofileForm(NewProfileForm parent)
        {
            InitializeComponent();
            _userService = new UserService();
            this.parent = parent;
        }
        private async void EditprofileForm_Load(object sender, EventArgs e)
        {
            currentUser = await _userService.GetCurrentUserAsync();
            txbUsername.Text = currentUser.Username;
            txbEmail.Text = currentUser.Email;
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
                txbEmail.Enabled = true;
                txbEmail.ReadOnly = true;
            }
        }
        Form actForm;
        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool checkMail = true;
            LoadingForm loadingForm = new LoadingForm();

            // Hiển thị LoadingForm ngay lập tức
            loadingForm.Show();
            bool checkUsername =await checkUsernameOutLimit(currentUser,txbUsername.Text);
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
            if(!checkUsername)
            {
                loadingForm.Hide();
                loadingForm.Close();
                txbUsername.BorderColor = Color.Red;
                (new AlertFail(" Fail" + "\n" + "Username is exist")).ShowDialog();
            }
            if(checkMail && checkUsername)
            {
                bool confirm = false;
                using (var alert = (new AlertConfirm()))
                {
                    alert.ShowDialog();
                    confirm = alert.ConfirmResult;
                }
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
        public static async Task<bool> checkUsernameOutLimit(User _user ,string username)
        {
            string usernameCurrent = _user.Username;
            string passwordCurrent = _user.PasswordHash;
            AuthService db = new AuthService();
            bool result =await  db.Login("admin", "123456", null);
            if (!result)
            {
                MessageBox.Show(result.ToString());
                await db.Login(usernameCurrent, passwordCurrent, null);
                return false;
            }
            else
            {
                var listAccount =await (new UserService()).GetUsersAsync();
                foreach (var user in listAccount)
                {
                    if(user.Username.Equals(username))
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
            activeFormChild(parent.mainForm.pnContent, new NewProfileForm(parent.mainForm), null, ref actForm2); 
        }
    }
}
