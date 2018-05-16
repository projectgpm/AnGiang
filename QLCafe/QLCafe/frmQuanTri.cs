using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace QLCafe
{
    public partial class frmQuanTri : DevExpress.XtraEditors.XtraForm
    {
        public frmQuanTri()
        {
            InitializeComponent();
           
        }


        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
                frmQLDanhMuc f = new frmQLDanhMuc();
                //this.Hide();
                f.ShowDialog();         
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    f.Close();
            //}
            //Application.Exit();
            this.Close();
        }

        private void frmQuanTri_FormClosing(object sender, FormClosingEventArgs e)
        {
            //foreach (Form f in MdiChildren)
            //{
            //    f.Close();
            //}
            //Application.Exit();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            Form fQLNguoiDung = new frmQLNguoiDung();
            //this.Hide();
            fQLNguoiDung.ShowDialog();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            try{
                string help = Application.StartupPath + "\\help.chm";
                Help.ShowHelp(this, help);
            }catch{}
              
        }

        private void frmQuanTri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string help = Application.StartupPath + "\\help.chm";
                Help.ShowHelp(this, help);
            }
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            Form fQLBangKe = new frmQLBangKe();
            //this.Hide();
            fQLBangKe.ShowDialog();
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            Form fQLBaoCao = new frmQLBaoCao();
            //this.Hide();
            fQLBaoCao.ShowDialog();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            Form fChiNhanh = new frmCaiDatThongTin();
            //this.Hide();
            fChiNhanh.ShowDialog();
        }
    }
}