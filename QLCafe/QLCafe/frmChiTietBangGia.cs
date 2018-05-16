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
    public partial class frmChiTietBangGia : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietBangGia()
        {
            InitializeComponent();
        }

        private int iDBangGia;

        public int IDBangGia
        {
            get { return iDBangGia; }
            set { iDBangGia = value; }
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
        private void fmChiTietBangGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_HangHoa' table. You can move, or remove it, as needed.
            this.cF_HangHoaTableAdapter.Fill(this.quanlycafeDataSet.CF_HangHoa);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_BangGia' table. You can move, or remove it, as needed.
            this.cF_BangGiaTableAdapter.Fill(this.quanlycafeDataSet.CF_BangGia);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_ChiTietBangGia' table. You can move, or remove it, as needed.
            this.cF_ChiTietBangGiaTableAdapter.Fill(this.quanlycafeDataSet.CF_ChiTietBangGia, iDBangGia);
        }
        #endregion

        #region xử lý thêm sửa xóa
        private void gvDonViTinh_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                int id = int.Parse(gvChiTietBangGia.GetRowCellValue(e.RowHandle, colID).ToString());
                string GiaMoi = gvChiTietBangGia.GetRowCellValue(e.RowHandle, colGiaMoi).ToString();
                string IDBangGia = gvChiTietBangGia.GetRowCellValue(e.RowHandle, colIDBangGia).ToString();
                string IDHangHoa = gvChiTietBangGia.GetRowCellValue(e.RowHandle, colIDHangHoa).ToString();
                int IDNguoiDung = 8; //frmDangNhap.NguoiDung.Id; //lấy id người dùng
                int checkUp = DataProvider.Instance.ExecuteNoneQuery("rp_UpInChiTietBangGia @id , @GiaMoi , @IDBangGia , @IDHangHoa , @IDNguoiDung", new object[] { id, GiaMoi, IDBangGia, IDHangHoa, IDNguoiDung });
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
            cF_ChiTietBangGiaTableAdapter.Fill(quanlycafeDataSet.CF_ChiTietBangGia, iDBangGia);
        }

        private void btXoavaDaXoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int id = int.Parse(gvChiTietBangGia.GetRowCellValue(gvChiTietBangGia.FocusedRowHandle, colID).ToString());
                switch (e.Button.Index)
                {
                    case 0:
                        if (XtraMessageBox.Show("Bạn có muốn Hủy/Kích hoạt " + id + " không?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (DataProvider.Instance.ExecuteNoneQuery("rp_ActiveChiTietBangGia @id", new object[] { id }) > 0)
                            {
                                XtraMessageBox.Show("Hủy/Kích hoạt thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                cF_ChiTietBangGiaTableAdapter.Fill(quanlycafeDataSet.CF_ChiTietBangGia, iDBangGia);
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