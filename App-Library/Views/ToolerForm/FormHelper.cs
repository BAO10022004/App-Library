using App_Library.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace App_Library.Views.ToolerForm
{
    public class FormHelper : Form
    {
         Form ActForm;
        public  void activeFormChild(System.Windows.Forms.Control ctrlSource,Form formDes,object obj)
        {
            // Kiểm tra nếu ActForm khác null và đã tồn tại, đóng nó
            if (ActForm != null && !ActForm.IsDisposed)
            {
                ActForm.Close();
            }
            
            // Thiết lập form mới vào ActForm
            ActForm = formDes;
            formDes.TopLevel = false;
            formDes.FormBorderStyle = FormBorderStyle.None;
            formDes.Dock = DockStyle.Fill;

            // Thêm form vào Control và hiển thị
            ctrlSource.Controls.Add(formDes);
            ctrlSource.Tag = formDes;
            formDes.BringToFront();
            formDes.Show();
        }
        public System.Windows.Forms.Control FindControlContainer(System.Windows.Forms.Control.ControlCollection listControl, System.Windows.Forms.Control control)
        {
            System.Windows.Forms.Control result = new System.Windows.Forms.Control();
            foreach (System.Windows.Forms.Control panel in listControl)
            {
                var item = (Panel)panel;
                foreach (var c in item.Controls)
                {
                    var itemControl  = (System.Windows.Forms.Control)c; 
                    if(itemControl.Name.Equals(control.Name))
                    {
                        result = item;
                    }
                }
            }
            return result;
        }
        public Image GetImageFromResources(string imageName)
        {
            ResourceManager rm = Properties.Resources.ResourceManager;
            object image = rm.GetObject(imageName);
            return image as Image;
        }
    }
    
}
