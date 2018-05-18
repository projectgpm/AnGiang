using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Runtime.InteropServices;
using DevExpress.Utils;
using ApplicationGPM.Properties;

namespace ApplicationGPM.GPMController
{
    public partial class XUC_Login : DevExpress.XtraEditors.XtraUserControl
    {
        public XUC_Login()
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(Settings.Default.UserName))
            { 
                txt_UserName.Text = Settings.Default.UserName;
                ck_SaveUserName.Checked = true;
            }      
        }

        #region Xử lý sự kiện Click

        #region xử lý các phần rìa
        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txt_Password.Text))
                    SendKeys.Send("{TAB}");
                else
                { 
                    btn_Login.AllowFocus = true;
                    btn_Login.PerformClick();
                }
            }
        }
        private void btn_Login_MouseHover(object sender, EventArgs e)
        {
            btn_Login.Margin = new Padding(2);
        }
        private void btn_Login_MouseLeave(object sender, EventArgs e)
        {
            btn_Login.Margin = new Padding(3);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txt_Password.Properties.UseSystemPasswordChar)
            {
                btn_ShowHidePassword.Image = Resources.show_32x32;
            }else
            {
                btn_ShowHidePassword.Image = Resources.hide_32x32;
            }
            txt_Password.Properties.UseSystemPasswordChar = !txt_Password.Properties.UseSystemPasswordChar;
        }
        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://gpm.vn/");
        }
        private void link_ChangePassword_Click(object sender, EventArgs e)
        {
            myFlyoutControl1.ShowPopup();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            myFlyoutControl1.HidePopup();
        }
        private void btn_ShowPassOld_Click(object sender, EventArgs e)
        {
            if(txt_PassOld.Properties.UseSystemPasswordChar)
                btn_ShowPassOld.Image = Resources.hide_32x32;
            else
                btn_ShowPassOld.Image = Resources.show_32x32;
            txt_PassOld.Properties.UseSystemPasswordChar = !txt_PassOld.Properties.UseSystemPasswordChar;
        }
        private void btn_ShowPassNew_Click(object sender, EventArgs e)
        {
            if (txt_PassNew.Properties.UseSystemPasswordChar)
                btn_ShowPassNew.Image = Resources.hide_32x32;
            else
                btn_ShowPassNew.Image = Resources.show_32x32;
            txt_PassNew.Properties.UseSystemPasswordChar = !txt_PassNew.Properties.UseSystemPasswordChar;
        }
        private void btn_ShowPassConfirm_Click(object sender, EventArgs e)
        {
            if (txt_PassConfirm.Properties.UseSystemPasswordChar)
                btn_ShowPassConfirm.Image = Resources.hide_32x32;
            else
                btn_ShowPassConfirm.Image = Resources.show_32x32;
            txt_PassConfirm.Properties.UseSystemPasswordChar = !txt_PassConfirm.Properties.UseSystemPasswordChar;
        }
        #endregion

        #region Xử lý các phần chức năng
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            myFlyoutControl1.HidePopup();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (ck_SaveUserName.Checked)
                Settings.Default.UserName = txt_UserName.Text;
            else
                Settings.Default.UserName = string.Empty;
            Settings.Default.Save();
            frmLogin.IsLogin = true;
            Form f = this.ParentForm;
            f.Close();
        }
        #endregion

        #endregion

        private void XUC_Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_UserName;
        }

    }
}
