using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Firebase.Storage;
using Google.Apis.Storage.v1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebaseAdmin.Messaging;
using MongoDB.Libmongocrypt;
using System.Windows.Forms;

namespace App_Library.Services
{
    internal class FirebaseService
    {
        private readonly FirebaseStorage _firebaseStorage;

        public FirebaseService()
        {
            string serviceAccountPath = Path.Combine(Directory.GetCurrentDirectory(), "serviceAccountKey.json");

            if (!File.Exists(serviceAccountPath))
            {
                throw new FileNotFoundException("serviceAccountKey.json not found at path: " + serviceAccountPath);
            }

            // Khởi tạo Firebase với tệp JSON cấu hình (key JSON từ Firebase)
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(serviceAccountPath)
                });
            }
            _firebaseStorage = new FirebaseStorage("reading-book-web.appspot.com");
        }

        public async Task<string> UploadFileAsync(string localFilePath, string folder)
        {
            var fileName = $"{folder}/{DateTime.Now.Ticks}{Path.GetFileName(localFilePath)}";
            //var fileName = $"{DateTime.Now.Ticks}{Path.GetFileName(localFilePath)}";
            using (var fileStream = File.OpenRead(localFilePath))
            {
                var uploadTask = _firebaseStorage
                    .Child(fileName)
                    .PutAsync(fileStream);
                Console.WriteLine($"{localFilePath}\n{fileName}\n{uploadTask.ToString()}");
                try
                {
                    var downloadUrl = await uploadTask; // URL trả về từ Firebase Storage
                     MessageBox.Show(downloadUrl);
                    return downloadUrl;  // URL này có thể sử dụng trực tiếp
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error uploading file: {ex.Message}");
                    throw;
                }
                //return "";
            }
        }
    }
}
