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
namespace AnGiang.Layout.GPMController
{
    public partial class XUC_Login : DevExpress.XtraEditors.XtraUserControl
    {
        public XUC_Login()
        {
            InitializeComponent();
        }
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

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gpm.vn/");
        }
        #endregion

        private void XUC_Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txt_UserName;
        }

    }
}
