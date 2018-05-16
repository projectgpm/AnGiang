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
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraEditors.Controls;

namespace QLCafe
{
    public partial class frmXemInLaiHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmXemInLaiHoaDon()
        {
            InitializeComponent();
            GridLocalizer.Active = new MyGridLocalizer();
            Localizer.Active = new MyLocalizer();
        }
        #region (Viet-sub he thong )



        public class MyGridLocalizer : GridLocalizer
        {
            public override string GetLocalizedString(GridStringId id)
            {
                switch (id)
                {
                    case GridStringId.FindControlFindButton:
                        return "Tìm Kiếm";
                    case GridStringId.FindControlClearButton:
                        return "Hủy Tìm";
                    case GridStringId.FilterPanelCustomizeButton:
                        return "Tùy Chọn Kích Cở";
                    case GridStringId.EditFormCancelButton:
                        return "Hủy";
                    case GridStringId.EditFormUpdateButton:
                        return "Cập Nhật";
                    case GridStringId.EditFormSaveMessage:
                        return "Dữ liệu đã thay đổi, bạn có muốn lưu không?";
                    case GridStringId.WindowWarningCaption:
                        return "CHÚ Ý";
                    case GridStringId.GridGroupPanelText:
                        return "Kéo một trường của hàng đầu tiên trong bảng vào đây";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        public class MyLocalizer : Localizer
        {
            public override string GetLocalizedString(StringId id)
            {
                switch (id)
                {
                    case StringId.InvalidValueText:
                        return @"Giá trị không hợp lệ";
                    case StringId.XtraMessageBoxYesButtonText:
                        return "Đồng ý";
                    case StringId.XtraMessageBoxCancelButtonText:
                        return "Trở lại";
                    case StringId.XtraMessageBoxNoButtonText:
                        return "Hủy";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }


        #endregion


        private void frmXemInLaiHoaDoncs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_NguoiDung' table. You can move, or remove it, as needed.
            this.cF_NguoiDungTableAdapter.Fill(this.quanlycafeDataSet.CF_NguoiDung);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_Ban' table. You can move, or remove it, as needed.
            this.cF_BanTableAdapter.Fill(this.quanlycafeDataSet.CF_Ban);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_HoaDon' table. You can move, or remove it, as needed.
            this.cF_HoaDonTableAdapter.FillByDaThanhToan(this.quanlycafeDataSet.CF_HoaDon);

        }
        rpHoaDonBanHang1 rp;

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                rp = new rpHoaDonBanHang1();
                string id = gridView1.GetRowCellValue(e.RowHandle, colID).ToString();
                rp.Parameters["ID"].Value = id;
                rp.Parameters["ID"].Visible = false;
                rp.Parameters["IDChiNhanh"].Value = frmDangNhap.NguoiDung.Idchinhanh;
                rp.Parameters["IDChiNhanh"].Visible = false;
                documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                rp.CreateDocument();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ReportPrintTool print = new ReportPrintTool(rp);
            print.Print();
        }


    }
}