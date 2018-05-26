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
using DevExpress.XtraReports.UI;
using AnGiang.Report;
using GPMLibrary;

namespace AnGiang.Layout.ChamCong
{
    public partial class frmXemBaoCao : DevExpress.XtraEditors.XtraForm
    {

        private int _nam;
        public int nam
        {
            get { return _nam; }
            set { _nam = value; }
        }
        private int _thang;
        public int thang
        {
            get { return _thang; }
            set { _thang = value; }
        }
        private double? _tongsotien;
        public double? tongsotien
        {
            get { return _tongsotien; }
            set { _tongsotien = value; }
        }
        private DataTable _tbDataSource;

        public DataTable tbDataSource
        {
            get { return _tbDataSource; }
            set { _tbDataSource = value; }
        }
        private string _ten;

        public string ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        
        
        public frmXemBaoCao(int nam = 0, int thang = 0, double? tongsotien = 0, DataTable tbDataSource = null,string ten = "")
        {
            InitializeComponent();
            this.tongsotien = tongsotien;
            this.nam = nam;
            this.thang = thang;
            this.tbDataSource = tbDataSource;
            this.ten = ten;
        }
        private void XemLuong_Load(object sender, EventArgs e)
        {
            XtraReport rp = new r_BaoCaoLuongXiNghiep();
            rp.DataSource = tbDataSource;
            rp.Parameters["Nam"].Value = nam;
            rp.Parameters["Nam"].Visible = false;
            rp.Parameters["Thang"].Value = thang.ToString("00");
            rp.Parameters["Thang"].Visible = false;
            rp.Parameters["SoTienBangChu"].Value = Tooler.Tools.ConvertNumberToStringVND((double)tongsotien, "Số tiền bằng chữ: ", "");
            rp.Parameters["SoTienBangChu"].Visible = false;
            rp.Parameters["TenXiNghiep"].Value = ten;
            rp.Parameters["TenXiNghiep"].Visible = false;
            rp.CreateDocument();
            documentViewerRibbonController1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
            documentViewer1.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.ZoomToPageWidth);
            
        }
    }
}