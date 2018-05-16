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
    public partial class frmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            int thang = date.Month;
            int nam = date.Year;
            string ngayBD = ""; string ngayKT = "";
            if (rbTheoNam.Checked)
            {
                ngayBD = nam + "-01-01 ";
                ngayKT = nam + "-12-31 ";
            }
            else if (rbTheoThang.Checked)
            {
                ngayBD = nam + "-" + thang + "-01 ";
                ngayKT = nam + "-" + thang + "-" + tinhSoNgay(thang, nam) + " ";
            }
            else if (rbTuyChon.Checked)
            {
                try
                {
                     ngayBD = DateTime.Parse(dateNgayBD.EditValue + "").ToString("yyyy-MM-dd ");
                    ngayKT = DateTime.Parse(dateNgayKT.EditValue + "").ToString("yyyy-MM-dd ");
                }
                catch{}
               
            }
         

            ngayBD = ngayBD + "00:00:0.000";
            ngayKT = ngayKT + "23:59:59.999";
            SimpleButton bt = sender as SimpleButton;
            frmXemBaoCao f = new frmXemBaoCao();
            switch(bt.Name)
            {
                case "btXemBCLN":                  
                    f.Text = "bảng Kê Bán Hàng";
                    f.NameFrmBaoCao = "bcln";
                    f.NgayBD = ngayBD;
                    f.NgayKT = ngayKT;
                    f.ShowDialog();
                    break;
                case "btXemBCBH":
                    f.Text = "Bảng Kê Kết Ca";
                    f.NameFrmBaoCao = "bcbh";
                    f.NgayBD = ngayBD;
                    f.NgayKT = ngayKT;
                    f.ShowDialog();
                    break;
            }
           

        }

        public int tinhSoNgay(int thang, int nam)
        {
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                return 31;
            if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                return 30;

            if (nam % 4 == 0 && nam % 100 != 0 || nam % 400 == 0)
                return 29;
            else return 28;
        }

        private void rbTuyChon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTuyChon.Checked)
            {
                dateNgayBD.Enabled = true;
                dateNgayKT.Enabled = true;
            }
            else
            {
                dateNgayBD.Enabled = false;
                dateNgayKT.Enabled = false;
            }
        }

        private void rbTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            rbTuyChon_CheckedChanged(sender, e);
        }

        private void rbTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            rbTuyChon_CheckedChanged(sender, e);
        }
    }
}