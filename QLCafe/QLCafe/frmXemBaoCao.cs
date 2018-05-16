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
using QLCafe.Report;

namespace QLCafe
{
    public partial class frmXemBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmXemBaoCao()
        {
            InitializeComponent();
        }

        private string nameFrmBaoCao;

        public string NameFrmBaoCao
        {
            get { return nameFrmBaoCao; }
            set { nameFrmBaoCao = value; }
        }
        private string ngayBD;

        public string NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }
        private string ngayKT;

        public string NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }
        private string iDNhanVien;

        public string IDNhanVien
        {
            get { return iDNhanVien; }
            set { iDNhanVien = value; }
        }
        
        

        private void frmXemBaoCao_Load(object sender, EventArgs e)
        {

            string strNgay = DateTime.Parse(NgayBD).ToString("dd-MM-yyyy") + " - " + DateTime.Parse(NgayKT).ToString("dd-MM-yyyy");
            DevExpress.XtraReports.UI.XtraReport rp;
            switch (nameFrmBaoCao)
            {
                case "bkbh":
                    
                    rp = new rpBKBanHang();
                    rp.Parameters["strNgay"].Value = strNgay;
                    rp.Parameters["strNgay"].Visible = false;
                    rp.Parameters["NgayBD"].Value = ngayBD;
                    rp.Parameters["NgayBD"].Visible = false;
                    rp.Parameters["NgayKT"].Value = ngayKT;
                    rp.Parameters["NgayKT"].Visible = false;
                    rp.Parameters["IDChiNhanh"].Value = 0;
                    rp.Parameters["IDChiNhanh"].Visible = false;
                    documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                    rp.CreateDocument();
                    break;
                case "bkkc":
                    rp = new rpBKKetCa();
                    rp.Parameters["strNgay"].Value = strNgay;
                    rp.Parameters["strNgay"].Visible = false;
                    rp.Parameters["NgayBD"].Value = ngayBD;
                    rp.Parameters["NgayBD"].Visible = false;
                    rp.Parameters["NgayKT"].Value = ngayKT;
                    rp.Parameters["NgayKT"].Visible = false;
                    rp.Parameters["IDNhanVien"].Value = iDNhanVien;
                    rp.Parameters["IDNhanVien"].Visible = false;
                    rp.Parameters["IDChiNhanh"].Value = 0;
                    rp.Parameters["IDChiNhanh"].Visible = false;
                    documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                    rp.CreateDocument();
                    break;
                case "bcln":
                    rp = new rpBaoCaoTongHop();
                    rp.Parameters["strNgay"].Value = strNgay;
                    rp.Parameters["strNgay"].Visible = false;
                    rp.Parameters["NgayBD"].Value = NgayBD;
                    rp.Parameters["NgayBD"].Visible = false;
                    rp.Parameters["NgayKT"].Value = NgayKT;
                    rp.Parameters["NgayKT"].Visible = false;
                    rp.Parameters["IDChiNhanh"].Value = 0;
                    rp.Parameters["IDChiNhanh"].Visible = false;
                    documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                    rp.CreateDocument();
                    break;
                case "bcbh":
                    rp = new rpBCBanHang();
                    rp.Parameters["strNgay"].Value = strNgay;
                    rp.Parameters["strNgay"].Visible = false;
                    rp.Parameters["NgayBD"].Value = NgayBD;
                    rp.Parameters["NgayBD"].Visible = false;
                    rp.Parameters["NgayKT"].Value = NgayKT;
                    rp.Parameters["NgayKT"].Visible = false;
                    rp.Parameters["IDChiNhanh"].Value = 0;
                    rp.Parameters["IDChiNhanh"].Visible = false;
                    documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                    rp.CreateDocument();
                    break;
                default: break;
            }
        }
    }
}