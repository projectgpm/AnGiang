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
using QLCafe.BUS;
using QLCafe.DAO;
using QLCafe.DTO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;

namespace QLCafe
{
    public partial class frmKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuVuc()
        {
            InitializeComponent();
            //Chạy việt sub
            GridLocalizer.Active = new MyGridLocalizer();
            Localizer.Active = new MyLocalizer();
        }

        #region Load dữ liệu
        public void frmKhuVucload()
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_BangGia' table. You can move, or remove it, as needed.
            this.cF_BangGiaTableAdapter.FillBycbChonBangGia(this.quanlycafeDataSet.CF_BangGia);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_KhuVuc' table. You can move, or remove it, as needed.
            this.cF_KhuVucTableAdapter.Fill(this.quanlycafeDataSet.CF_KhuVuc);
        }

        private void frmKhuVuc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_BangGia' table. You can move, or remove it, as needed.
            this.cF_BangGiaTableAdapter.FillBycbChonBangGia(this.quanlycafeDataSet.CF_BangGia);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_KhuVuc' table. You can move, or remove it, as needed.
            this.cF_KhuVucTableAdapter.Fill(this.quanlycafeDataSet.CF_KhuVuc);
            

        }
        #endregion

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
                    case StringId.NavigatorTextStringFormat:
                        return "no ne " + StringId.NavigatorTextStringFormat;
                    case StringId.ContainerAccessibleEditName:
                        return "no ne " + StringId.ContainerAccessibleEditName;
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }


        #endregion

        #region Các chức năng xử lý thêm sửa xóa

        private void gvKhuVuc_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                int id = int.Parse(gvKhuVuc.GetRowCellValue(gvKhuVuc.FocusedRowHandle, colID).ToString());
                string name = gvKhuVuc.GetRowCellValue(gvKhuVuc.FocusedRowHandle, colTenKhuVuc).ToString();
                
                if (e.Column.FieldName.Equals("")) //Kiểm tra click đúng nút Xóa và Active
                switch (e.Column.ColumnEdit.Name) //Thực hiện các chức năng các nút Xóa và Active
                {
                    case "btXoa":
                        if (XtraMessageBox.Show("Bạn có muốn xóa " + name + " không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (DataProvider.Instance.ExecuteNoneQuery("DELETE dbo.CF_KhuVuc WHERE id =" + id) > 0)
                            { XtraMessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); gvKhuVuc.DeleteRow(gvKhuVuc.FocusedRowHandle); }
                            else XtraMessageBox.Show("Xóa thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case "btActive":
                        if (XtraMessageBox.Show("Bạn có muốn Hủy/Kích hoạt " + name + " không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (DataProvider.Instance.ExecuteNoneQuery("rp_ActiveKhuVuc @id", new object[] { id }) > 0)
                            {
                                XtraMessageBox.Show("Hủy/Kích hoạt thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            cF_KhuVucTableAdapter.Fill(quanlycafeDataSet.CF_KhuVuc); 
                            }
                            else XtraMessageBox.Show("Hủy/Kích hoạt thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xuất hiện lỗi hệ thống xin vui lòng thông báo bên chăm sóc khách hàng để có bản cập nhật sửa lỗi!\nMã Lỗi: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvKhuVuc_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                int id = int.Parse(gvKhuVuc.GetRowCellValue(e.RowHandle, colID).ToString());            
                string MaKhuVuc = gvKhuVuc.GetRowCellValue(e.RowHandle, colMaKhuVuc).ToString();
                string KyHieu = gvKhuVuc.GetRowCellValue(e.RowHandle, colKyHieu).ToString();
                string TenKhuVuc = gvKhuVuc.GetRowCellValue(e.RowHandle, colTenKhuVuc).ToString();
                string GhiChu = gvKhuVuc.GetRowCellValue(e.RowHandle, colGhiChu).ToString();
                string IDBangGia = gvKhuVuc.GetRowCellValue(e.RowHandle, colIDBangGia).ToString();

                int checkUp = DataProvider.Instance.ExecuteNoneQuery("rp_UpInKhuVuc @id , @MaKhuVuc , @KyHieu , @TenKhuVuc , @GhiChu , @IDBangGia", new object[] { id, MaKhuVuc, KyHieu, TenKhuVuc, GhiChu, IDBangGia});
                if (checkUp > 0)
                {
                    XtraMessageBox.Show("Cập nhật thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (checkUp == -1) { XtraMessageBox.Show("Không thể thêm vì tên bị trùng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Xuất hiện lỗi hệ thống xin vui lòng thông báo bên chăm sóc khách hàng để có bản cập nhật sửa lỗi!\nMã Lỗi: " + ex.Message, "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           cF_KhuVucTableAdapter.Fill(quanlycafeDataSet.CF_KhuVuc);
        }
        #endregion
    }
}