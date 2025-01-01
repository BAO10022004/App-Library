using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Library.Views.SignUpSignIn
{
    public partial class AnimationOpenLoginWithGG : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetLayeredWindowAttributes(IntPtr hwnd, uint crKey, byte bAlpha, uint dwFlags);

        private const int WS_EX_LAYERED = 0x80000; // Window style layered
        private const int WS_EX_TRANSPARENT = 0x20; // Window style transparent
        private const int LWA_COLORKEY = 0x1; // Use color key for transparency
        private const int LWA_ALPHA = 0x2; // Use alpha value for transparency

        public AnimationOpenLoginWithGG()
        {
            InitializeComponent();
            // Thiết lập form không viền và trong suốt
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Lime; // Màu nền sẽ được dùng làm "màu trong suốt"
            this.TransparencyKey = Color.Lime; // Đặt TransparencyKey khớp với màu nền
            this.TopMost = true; // Đưa form lên trên cùng (nếu cần)

            // Đặt Layered Window để kiểm soát độ trong suốt
            this.Load += (s, e) =>
            {
                IntPtr hwnd = this.Handle;
                int extendedStyle = GetWindowLong(hwnd, -20); // -20 là GWL_EXSTYLE
                SetWindowLong(hwnd, -20, extendedStyle | WS_EX_LAYERED | WS_EX_TRANSPARENT);
            };
            timerOpen.Start();
        }
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        // API: Đặt thuộc tính Window Long
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        private void timerOpen_Tick(object sender, EventArgs e)
        {
            // Lấy kích thước hiện tại của Panel và Form
            int targetWidth = this.Width;
            int targetHeight = this.Height;
            int currentWidth = pnMain.Width;
            int currentHeight = pnMain.Height;

            // Lấy vị trí hiện tại của Panel
            int currentX = pnMain.Location.X;
            int currentY = pnMain.Location.Y;

            // Tính toán gia tốc cho kích thước và vị trí (Giảm chia để tăng tốc)
            int deltaWidth = Math.Max(1, (targetWidth - currentWidth) / 5);  // Giảm chia để nhanh hơn
            int deltaHeight = Math.Max(1, (targetHeight - currentHeight) / 5);  // Giảm chia để nhanh hơn
            int deltaX = Math.Max(1, Math.Abs(currentX) / 5);  // Giảm chia để nhanh hơn
            int deltaY = Math.Max(1, Math.Abs(currentY) / 5);  // Giảm chia để nhanh hơn

            // Cập nhật kích thước và vị trí
            if (currentWidth < targetWidth || currentHeight < targetHeight || currentX > 0 || currentY > 0)
            {
                pnMain.Size = new Size(
                    Math.Min(currentWidth + deltaWidth, targetWidth),
                    Math.Min(currentHeight + deltaHeight, targetHeight)
                );

                pnMain.Location = new Point(
                    Math.Max(0, currentX - deltaX),
                    Math.Max(0, currentY - deltaY)
                );

                picGG.Size = new Size(picGG.Width + 1, picGG.Height + 1);
                picGG.Location = new Point(pnMain.Width / 2 - picGG.Width / 2, pnMain.Height / 2 - picGG.Height / 2);
            }
            else
            {
                // Dừng Timer khi đạt kích thước và vị trí mong muốn
                pnMain.Size = new Size(targetWidth, targetHeight);
                pnMain.Location = new Point(0, 0);
                timerOpen.Stop();
                this.Close();
            }
        }

    }
}
