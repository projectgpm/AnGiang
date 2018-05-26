using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnGiang.Layout.NhanVien;
using AnGiang.Controller;
using AnGiang.Layout.DanhMuc;
using AnGiang.Layout.ChamCong;
using AnGiang.Layout.Luong;
//using AnGiang.Layout.Luong;

namespace AnGiang
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            barXemNgay.Caption = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        //private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //     XtraForm1 fr = new XtraForm1();
            
        //    if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
        //    {
        //        fr.MdiParent = this;
        //        fr.WindowState = FormWindowState.Maximized;
        //        fr.Show();
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            barXemGio.Caption = "Giờ: " + DateTime.Now.ToLongTimeString();
        }

        private void navDanhSachNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDanhSachNV fr = new frmDanhSachNV();
             if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
             {
                 fr.MdiParent = this;
                 fr.Show();
             }

           
        }

        private void navAddNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThemNhanVien fr = new frmThemNhanVien();

            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            //GPMLibrary.Validation.Vals.CloseAllForm(this);
        }

        private void barPhongBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPhongBan fr = new frmPhongBan();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barChucDanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChucDanh fr = new frmChucDanh();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barChuyenMon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenMon fr = new frmChuyenMon();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navBangChamCong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmChamCong fr = new frmChamCong();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void barDanhMucCD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDanhMucCD fr = new frmDanhMucCD();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navDinhMuc_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmThietLap fr = new frmThietLap();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmDinhMucTienLuong fr = new frmDinhMucTienLuong();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navHopDongLaoDong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmComingSoon fr = new frmComingSoon();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navTieuSuNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmComingSoon fr = new frmComingSoon();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navQDChuyenBoPhan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmComingSoon fr = new frmComingSoon();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navQDTangLuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmComingSoon fr = new frmComingSoon();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navQDKhenThuongKyLuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmComingSoon fr = new frmComingSoon();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

        private void navQDNghiViec_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmComingSoon fr = new frmComingSoon();
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.Show();
            }
        }

       
    }
}
