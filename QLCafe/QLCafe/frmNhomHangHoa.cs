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
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Localization;
using QLCafe.DAO;
using QLCafe.BUS;
using QLCafe.DTO;

namespace QLCafe
{
    public partial class frmNhomHangHoa : DevExpress.XtraEditors.XtraForm
    {
        public frmNhomHangHoa()
        {
            InitializeComponent();
            //chạy việt sub khi load form
            GridLocalizer.Active = new MyGridLocalizer();
            Localizer.Active = new MyLocalizer();
        }

        #region load dữ liệu
        private void frmNhomHangHoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_NhomHangHoa' table. You can move, or remove it, as needed.
            this.cF_NhomHangHoaTableAdapter1.Fill(this.quanlycafeDataSet.CF_NhomHangHoa);

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

        #region các chức năng thêm sửa xóa

        private void gvBan_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                int id = int.Parse(gvNhomHangHoa.GetRowCellValue(e.RowHandle, colID).ToString());
                string TenNhom = gvNhomHangHoa.GetRowCellValue(e.RowHandle, colTenNhom).ToString();
                string GhiChu = gvNhomHangHoa.GetRowCellValue(e.RowHandle, colGhiChu).ToString();

                int checkUp = DataProvider.Instance.ExecuteNoneQuery("rp_UpInNhomHangHoa @id , @TenNhom , @GhiChu", new object[] { id, TenNhom, GhiChu });
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
            //cF_NhomHangHoaTableAdapter.Fill(dataSet1.CF_NhomHangHoa);
        }

        private void btXoavaActive_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                int id = int.Parse(gvNhomHangHoa.GetRowCellValue(gvNhomHangHoa.FocusedRowHandle, colID).ToString());
                string name = gvNhomHangHoa.GetRowCellValue(gvNhomHangHoa.FocusedRowHandle, colTenNhom).ToString();

                    switch (e.Button.Index) //Thực hiện các chức năng các nút Xóa và Active
                    {
                        case 0:
                            if (XtraMessageBox.Show("Bạn có muốn xóa " + name + " không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (DataProvider.Instance.ExecuteNoneQuery("DELETE dbo.CF_NhomHangHoa WHERE id =" + id) > 0)
                                { XtraMessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); gvNhomHangHoa.DeleteRow(gvNhomHangHoa.FocusedRowHandle); }
                                else XtraMessageBox.Show("Xóa thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        case 1:
                            if (XtraMessageBox.Show("Bạn có muốn Hủy/Kích hoạt " + name + " không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (DataProvider.Instance.ExecuteNoneQuery("rp_ActiveNhomHangHoa @id", new object[] { id }) > 0)
                                {
                                    XtraMessageBox.Show("Hủy/Kích hoạt thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
                                   // cF_NhomHangHoaTableAdapter.Fill(dataSet1.CF_NhomHangHoa);
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
        #endregion
    }
}