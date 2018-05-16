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
    public partial class frmTongChi : DevExpress.XtraEditors.XtraForm
    {
        public frmTongChi()
        {
            InitializeComponent();
            //Chạy việt sub
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

        #region load dữ liệu
        private void frmTongChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_TongChi' table. You can move, or remove it, as needed.
            this.cF_TongChiTableAdapter.Fill(this.quanlycafeDataSet.CF_TongChi);

        }
        #endregion

        #region các chức năng thêm sửa xóa
        private void btXoavaDaXoa_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            try
            {
                int id = int.Parse(gvTongChi.GetRowCellValue(gvTongChi.FocusedRowHandle, colID).ToString());
                string name = gvTongChi.GetRowCellValue(gvTongChi.FocusedRowHandle, colLoaiChi).ToString();
                switch (e.Button.Index)
                {
                    case 0:
                        if (XtraMessageBox.Show("Bạn có muốn xóa " + name + " không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (DataProvider.Instance.ExecuteNoneQuery("DELETE dbo.CF_TongChi WHERE id =" + id) > 0)
                            { XtraMessageBox.Show("Xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); gvTongChi.DeleteRow(gvTongChi.FocusedRowHandle); }
                            else XtraMessageBox.Show("Xóa thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                    case 1:
                        if (XtraMessageBox.Show("Bạn có muốn Hủy/Kích hoạt " + name + " không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (DataProvider.Instance.ExecuteNoneQuery("rp_ActiveTongChi @id", new object[] { id }) > 0)
                            {
                                XtraMessageBox.Show("Hủy/Kích hoạt thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                cF_TongChiTableAdapter.Fill(quanlycafeDataSet.CF_TongChi);
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

        private void gvBangGia_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                int id = int.Parse(gvTongChi.GetRowCellValue(e.RowHandle, colID).ToString());
                string LoaiChi = gvTongChi.GetRowCellValue(e.RowHandle, colLoaiChi).ToString();
                string TienChi = gvTongChi.GetRowCellValue(e.RowHandle, colTienChi).ToString();
                DateTime NgayChi = (DateTime)gvTongChi.GetRowCellValue(e.RowHandle, colNgayChi);



                int checkUp = DataProvider.Instance.ExecuteNoneQuery("rp_UpInTongChi @id , @LoaiChi , @TienChi , @NgayChi", new object[] { id, LoaiChi, TienChi, NgayChi });
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
            cF_TongChiTableAdapter.Fill(quanlycafeDataSet.CF_TongChi);
        }
        #endregion

    }
}