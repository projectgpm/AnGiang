using QLCafe.BUS;
using QLCafe.DAO;
using QLCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Helpers;
using QLCafe.Properties;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using Microsoft.VisualBasic;
using DevExpress.XtraSplashScreen;
using DevExpress.LookAndFeel;


namespace QLCafe
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {       
        private TextBox txtArgs;
        public string[] Args;
        public static DTO_DangNhap NguoiDung;

        public frmDangNhap()
        {
            InitializeComponent();
            ckluu.Checked = Settings.Default.ckluu;
            txtTenDangNhap.Text = Settings.Default.UserName;
            //if (Settings.Default.SkinName.Contains("The Bezier"))
            //{ 
            //    UserLookAndFeel.Default.SetSkinStyle("The Bezier", Settings.Default.PaletteName);
            //}else
            //{
                UserLookAndFeel.Default.SetSkinStyle(Settings.Default.SkinName);
            //}
            //this.LookAndFeel.SetSkinStyle(Settings.Default.SkinName);
            
        }
       
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (this.Args != null)
            {
                ProcessParameters(null, this.Args);
                this.Args = null;
            }
            if (Settings.Default.UserName != string.Empty)
                txtMatKhau.Select();
            else
                txtTenDangNhap.Select();
        }

        #region sự kiện khi nhấn vào các nút
        private void linkLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string NameLink = (sender as LinkLabel).Name;
            switch (NameLink)
            {
                case "linkLienHe":
                    System.Diagnostics.Process.Start("https://gpm.vn/");
                    break;
                case "linkDoiMatKhau":
                    using (Form frDoiMatKhau = new frmDoiMatKhau())
                    {
                        this.Hide();
                        frDoiMatKhau.ShowDialog();
                        this.Show();
                    }
                    break;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            foreach (Form f in MdiChildren)
            {
                f.Close();
            }
            Application.Exit();
        }      

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DangNhap(true);
        }
        #endregion

        #region Sự kiện nhấn vào các checkbox
        private void ckluu_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.ckluu = ckluu.Checked;
            Settings.Default.Save();
        }

        private void ckeHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckeHienMatKhau.Checked == true)
            {
                txtMatKhau.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.Properties.UseSystemPasswordChar = true;
            }
        }
        #endregion

        #region sự kiện thoát/đóng
        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //đóng hết tất cả các form con trước khi thoát
            //foreach (Form f in MdiChildren)
            //{
            //    f.Close();
            //}
            Application.Exit();
        }
        #endregion

        #region Sự kiện khác
        public delegate void ProcessParametersDelegate(object sender, string[] args);
        public void ProcessParameters(object sender, string[] args)
        {
            // The form has loaded, and initialization will have been be done.

            // Add the command-line arguments to our textbox, just to confirm that
            // it reached here.
            if (args != null && args.Length != 0)
            {
                txtArgs.Text += DateTime.Now.ToString("mm:ss.ff") + " ";
                for (int i = 0; i < args.Length; i++)
                {
                    txtArgs.Text += args[i] + " ";
                }
                txtArgs.Text += "\r\n";
            }
        }
        public void DangNhap(bool ktquantri)
        {
            string TenDangNhap = txtTenDangNhap.Text.ToUpper();
            string MatKhau = DAO_Setting.GetSHA1HashData(txtMatKhau.Text.ToString());
            bool KT = BUS_DangNhap.KiemTraDangNhap(TenDangNhap, MatKhau);
            if (KT == true)
            {
                DataTable dt = BUS_DangNhap.ThongTin(TenDangNhap, MatKhau);
                if (dt.Rows.Count > 0)
                {
                    //lưu tên đăng nhập nếu checkbox lưu được check
                    if (Settings.Default.UserName != txtTenDangNhap.Text)
                        if (ckluu.Checked)
                        {
                            Settings.Default.UserName = txtTenDangNhap.Text;
                        }
                        else
                        {
                            Settings.Default.UserName = string.Empty;
                        }
                    DataRow dr = dt.Rows[0];
                    NguoiDung = new DTO_DangNhap(dr);                               
                    if (NguoiDung.IDNhomNguoiDung == 1 && ktquantri)
                    {
                        SplashScreenManager.ShowForm(typeof(WaitForm1));
                        using (frmQuanTri fquantri = new frmQuanTri())
                        {


                            SplashScreenManager.CloseForm();
                            this.Hide();
                            fquantri.ShowDialog();
                            this.Show();
                        }
                    }
                    else
                    {
                        SplashScreenManager.ShowForm(typeof(WaitForm1));
                        using (frmBanHang frBanHang = new frmBanHang())
                        {
                            SplashScreenManager.CloseForm();
                            this.Hide();
                            frBanHang.ShowDialog();
                            this.Show();
                        }
                        
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


       
       

    }
}
