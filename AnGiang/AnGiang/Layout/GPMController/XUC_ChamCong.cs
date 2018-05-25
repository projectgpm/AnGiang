using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using AnGiang.Model;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraEditors.Controls;
using System.Reflection;
using AnGiang.Layout.ChamCong;
using GPMLibrary;

namespace AnGiang.Layout.GPMController
{
    public partial class XUC_ChamCong : DevExpress.XtraEditors.XtraUserControl
    {
        private bool _MouseRight = false;
        private int _SoNgay = 0;
        private List<int> _NgayNghi;
        private List<int> _NgayNghiT7;

        public XUC_ChamCong()
        {
            InitializeComponent();           
            GridLocalizer.Active = new MyGridLocalizer();
            Localizer.Active = new MyLocalizer();           
        }

        #region Việt Sub
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
                        return "Giá trị không hợp lệ";
                    case StringId.XtraMessageBoxYesButtonText:
                        return "Có";
                    case StringId.XtraMessageBoxCancelButtonText:
                        return "Hủy";
                    case StringId.XtraMessageBoxNoButtonText:
                        return "Không";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }
        #endregion

        #region Kiem tra
        private void cbLoaiChamCong_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption.Contains("hủy"))
            {
                ccKyHieu layMacDinhNghiCuoiTuan = DataProvider.Ins.DB.ccKyHieux.Where(q => q.MacDinh == 1).FirstOrDefault();
                cbLoaiChamCong.EditValue = layMacDinhNghiCuoiTuan.IDKyHieu;
                LoadUnchecked();
            }
        }
        private void ckChamTheoNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBatDau.Value > txtNgayKetThuc.Value)
            {
                ckChamTheoNgay.Checked = false;
            }
        }
        private void txtNgayKetThuc_EditValueChanged(object sender, EventArgs e)
        {
            if (txtBatDau.Value > txtNgayKetThuc.Value)
            {
                txtNgayKetThuc.Value = txtBatDau.Value;
            }
        }
        private void txtBatDau_EditValueChanged(object sender, EventArgs e)
        {
            if (txtBatDau.Value > txtNgayKetThuc.Value)
            {
                txtNgayKetThuc.Value = txtBatDau.Value;
            }
        }
        private void gridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                _MouseRight = true;
            else
                _MouseRight = false;
        }

        #endregion

        #region Load
        void LoadEnable()
        {
            ckChamTungO.Enabled = true;
            ckChamMotCot.Enabled = true;
            ckChamMotHang.Enabled = true;
            ckChamTheoNgay.Enabled = true;
            ckDaCham.Enabled = true;
            txtBatDau.Enabled = true;
            txtNgayKetThuc.Enabled = true;
            cbLoaiChamCong.Enabled = true;
        }
        void LoadDisable()
        {
            ckChamTungO.Enabled = false;
            ckChamMotCot.Enabled = false;
            ckChamMotHang.Enabled = false;
            ckChamTheoNgay.Enabled = false;
            ckDaCham.Enabled = false;
            txtBatDau.Enabled = false;
            cbLoaiChamCong.Enabled = false;
            txtNgayKetThuc.Enabled = false;
        }
        void LoadUnchecked()
        {
            ckChamMotCot.Checked = false;
            ckChamTungO.Checked = false;
            ckChamMotHang.Checked = false;
            ckChamTheoNgay.Checked = false;
        }
        #endregion

        public bool CapNhatChiTiet(long IDNhanVien, long IDChamCong, int Ngay, long IDKyHieu=0)
        {
            if(IDKyHieu==0)
            IDKyHieu = (long)cbLoaiChamCong.EditValue;
            var kyhieuvankhongphep = DataProvider.Ins.DB.ccKyHieux.Where(q => q.MaKyHieu == "K").SingleOrDefault();
            if (_NgayNghi.Contains(Ngay) && IDKyHieu != kyhieuvankhongphep.IDKyHieu)
                    return DataProvider.Ins.DB.pr_ThemChiTiet(IDKyHieu, IDChamCong, Ngay, 2) > 0;
            if (_NgayNghiT7.Contains(Ngay))
                    return DataProvider.Ins.DB.pr_ThemChiTiet(IDKyHieu, IDChamCong, Ngay, 3) > 0;
            if (!_NgayNghi.Contains(Ngay) && !_NgayNghiT7.Contains(Ngay))
                return DataProvider.Ins.DB.pr_ThemChiTiet(IDKyHieu, IDChamCong, Ngay, 0) > 0;               
            return false;
        }
        private void XUC_ChamCong_Load(object sender, EventArgs e)
        {
            ccKyHieuTableAdapter.Fill(anGiangDataSet1.ccKyHieu);
            ccXemChamCongTableAdapter1.Fill(anGiangDataSet1.ccXemChamCong, DateTime.Now.Month, DateTime.Now.Year);
            colHuongLuong.Caption = "Hưởng \nlương";
            colNgayPhep.Caption = "Ngày \nphép";
            colPhepNam.Caption = "Phép \nnăm";
            colAnTrua.Caption = "Ăn \nTrưa";
            dateThangNam.EditValue = DateTime.Now;
            dateThangNam.Properties.MaxValue = DateTime.Now;
            ccKyHieu layMacDinhNghiCuoiTuan = DataProvider.Ins.DB.ccKyHieux.Where(q => q.MacDinh == 1).SingleOrDefault();
            cbLoaiChamCong.EditValue = layMacDinhNghiCuoiTuan.IDKyHieu;
        }
        private void dateThangNam_EditValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateThangNam.DateTime;
            //lấy danh sach nhân viên
            var nhanvien = DataProvider.Ins.DB.nvNhanViens.Where(q => q.DaXoa == 0 && (q.NgayLamViec.Value.Year == dt.Year && q.NgayLamViec.Value.Month <= dt.Month || q.NgayLamViec.Value.Year < dt.Year)).ToList();
            if (dt == null || nhanvien == null)
            {
                LoadDisable();
                return;
            }
            LoadEnable();
            //lấy số ngày trong tháng của năm
            _SoNgay = Tooler.Tools.GetDayInMoth(dt.Month, dt.Year);
            //giới hạng lại ngày
            txtBatDau.Properties.MaxValue = _SoNgay;
            //giới hạng lại ngày
            txtNgayKetThuc.Properties.MaxValue = _SoNgay; 

            
            //lấy danh sách ID nhân viên làm việc
            List<long> listIDNhanVien = nhanvien.Select(x => x.IDNhanVien).ToList(); 
            var chamcong = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && listIDNhanVien.Contains((long)q.NhanVienID)).ToList();
            List<long?> listNhanVienID = chamcong.Select(x => x.NhanVienID).ToList(); //danh sách Id nhân viên có trong bảng chấm công        
            var DanhSachNhanVienChuaThem = DataProvider.Ins.DB.nvNhanViens.Where(q => q.DaXoa == 0 && (q.NgayLamViec.Value.Year == dt.Year && q.NgayLamViec.Value.Month <= dt.Month || q.NgayLamViec.Value.Year < dt.Year) && !listNhanVienID.Contains(q.IDNhanVien)).ToList();

            //lấy ký hiệu mặt định nghĩ cuối tuần
            //ngay lam 8 tieng 
            ccKyHieu layMacDinh = DataProvider.Ins.DB.ccKyHieux.Where(q => q.MaKyHieu == "8").FirstOrDefault();
            //1: nghi ngay chu nhat 
            ccKyHieu layMacDinhNghiChuNhat = DataProvider.Ins.DB.ccKyHieux.Where(q => q.MacDinh == 1).FirstOrDefault();
            //Ngay lam thu 7 4 tieng
            ccKyHieu layMacDinhNghiThuBay = DataProvider.Ins.DB.ccKyHieux.Where(q => q.MaKyHieu == "4").FirstOrDefault(); 

            //lấy danh sách cuối tuần
            _NgayNghi = new List<int>();
            _NgayNghiT7 = new List<int>();
            for (int i = _SoNgay+1; i <= 31; i++)
            {
                GridColumn col = gridView1.Columns.ColumnByFieldName(i.ToString());
                col.Visible = false;
            }
            for (int i = 1; i <= _SoNgay; i++)
            {                
                DateTime KiemTraCuoiTuan = new DateTime(dt.Year, dt.Month, i);
                GridColumn col = gridView1.Columns.ColumnByFieldName(i.ToString());
                if (!col.Visible)
                { 
                    col.Visible = true;
                    col.VisibleIndex = i+1;
                }
                
                if (KiemTraCuoiTuan.DayOfWeek == DayOfWeek.Sunday)
                    _NgayNghi.Add(i);
                if (KiemTraCuoiTuan.DayOfWeek == DayOfWeek.Saturday)
                    _NgayNghiT7.Add(i);
                if (_NgayNghi.Contains(i) || _NgayNghiT7.Contains(i))
                {
                   
                    col.AppearanceHeader.BackColor = Color.DarkSalmon;
                    col.AppearanceCell.BackColor = Color.DarkSalmon;
                }
                else
                {
                    col.AppearanceHeader.BackColor = Color.Transparent;
                    col.AppearanceCell.BackColor = Color.Transparent;
                }
                
            }
                //kiểm tra xem còn nhân viền nào chưa được thêm vào bảng chấm công chưa nếu chưa thì thêm vào
                if (listIDNhanVien.Count != listNhanVienID.Count)
                {
                    float ngaychunhat = _NgayNghi.Count;
                    float ngaythubay = _NgayNghiT7.Count;
                    float ngaynghi = ngaychunhat + ngaythubay / 2;
                    float huongluong = _SoNgay - ngaynghi;
                    foreach (nvNhanVien nv in DanhSachNhanVienChuaThem)
                    {
                        //thêm vào châm công mới
                        DataProvider.Ins.DB.pr_ThemChamCong(nv.IDNhanVien, dt.Month, dt.Year, _SoNgay, ngaynghi, huongluong);
                        //đưa số ngày vào chi tiết
                        DataProvider.Ins.DB.Entry(DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == nv.IDNhanVien).FirstOrDefault());
                        long IDChamCong = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == nv.IDNhanVien).FirstOrDefault().IDChamCong;
                        for (int i = 1; i <= _SoNgay; i++)
                        {
                            if (_NgayNghi.Contains(i))
                                CapNhatChiTiet(nv.IDNhanVien, IDChamCong, i, layMacDinhNghiChuNhat.IDKyHieu);
                            else
                                if (_NgayNghiT7.Contains(i))
                                    CapNhatChiTiet(nv.IDNhanVien, IDChamCong, i, layMacDinhNghiThuBay.IDKyHieu);
                                else
                                    CapNhatChiTiet(nv.IDNhanVien, IDChamCong, i, layMacDinh.IDKyHieu);
                        }
                        DataProvider.Ins.DB.pr_LoadChamCong(IDChamCong);
                        DataProvider.Ins.DB.pr_bangLuongTongHop(1, (int?)nv.IDNhanVien, dt.Month, dt.Year);
                    }
                }
            ccXemChamCongTableAdapter1.Fill(anGiangDataSet1.ccXemChamCong,dt.Month,dt.Year);          
        }    
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            switch (e.Column.FieldName)
            {
                case "HuongLuong":
                    return;
                case "AnTrua":
                    return;
                case "PhepNam":
                    return;
                case "HoTen":
                    return;
            }

            long IDKyHieu = (long)cbLoaiChamCong.EditValue;
            string maKyHieu = DataProvider.Ins.DB.ccKyHieux.Find(IDKyHieu).MaKyHieu;
            if (!ckChamMotCot.Checked && !ckChamMotHang.Checked && !ckChamTungO.Checked && !ckChamTheoNgay.Checked)
                return;
            DateTime dt = dateThangNam.DateTime;
            int IDNhanVien = int.Parse(gridView1.GetFocusedRowCellValue("IDNhanVien").ToString());
            DataProvider.Ins.DB.Entry(DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == IDNhanVien).FirstOrDefault()).Reload();
            long IDChamCong = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == IDNhanVien).FirstOrDefault().IDChamCong;

            GridColumn colHuongLuong = gridView1.Columns.ColumnByFieldName("HuongLuong");
            GridColumn colAnTrua = gridView1.Columns.ColumnByFieldName("AnTrua");
            GridColumn colNghiPhep = gridView1.Columns.ColumnByFieldName("PhepNam");
            GridColumn colNgayPhep = gridView1.Columns.ColumnByFieldName("NgayPhep");
          
            if (ckChamTungO.Checked)
            {
                int Ngay = int.Parse(e.Column.FieldName);
                if (!CapNhatChiTiet(IDNhanVien, IDChamCong, Ngay))
                    return;
                gridView1.SetFocusedRowCellValue(e.Column, maKyHieu);                                               
            }
            else
            //chấm công nhanh theo một hàng
            if (ckChamMotHang.Checked)
            {
                for (int i = 1; i <= _SoNgay; i++)
                {
                    GridColumn col = gridView1.Columns.ColumnByFieldName(i.ToString());
                    int Ngay = int.Parse(col.FieldName);
                    if (CapNhatChiTiet(IDNhanVien, IDChamCong, Ngay))
                    gridView1.SetFocusedRowCellValue(col, maKyHieu);                    
                }
            }
            else
            //chấm công nhanh theo ngày
            if (ckChamTheoNgay.Checked)
            {               
                for (int i = (int)txtBatDau.Value; i <= (int)txtNgayKetThuc.Value; i++)
                {
                    GridColumn col = gridView1.Columns.ColumnByFieldName(i.ToString());
                    int Ngay = int.Parse(col.FieldName);
                    if (CapNhatChiTiet(IDNhanVien, IDChamCong, Ngay))
                    gridView1.SetFocusedRowCellValue(col, maKyHieu);                                        
                }
            }
            else
            //chấm công nhanh theo cột
            if (ckChamMotCot.Checked)
            {
                DataTable tb = ccXemChamCongTableAdapter1.GetData(dt.Month, dt.Year);
                int i = 0;
                gridView1.SetFocusedRowCellValue(e.Column, maKyHieu);
                foreach (DataRow r in tb.Rows)
                {
                    int Ngay = int.Parse(e.Column.FieldName);
                    int IDNhanVienRow = int.Parse(gridView1.GetRowCellValue(i, "IDNhanVien").ToString());
                    long IDChamCongRow = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == IDNhanVienRow).FirstOrDefault().IDChamCong;
                    
                    if (CapNhatChiTiet(IDNhanVien, IDChamCongRow, Ngay))
                    {
                        DataProvider.Ins.DB.Entry(DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == IDNhanVienRow).FirstOrDefault()).Reload();
                        ccChamCong CapNhatCotChamCongRow = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == IDNhanVienRow).FirstOrDefault();
                        gridView1.SetRowCellValue(i, e.Column, maKyHieu);
                        gridView1.SetRowCellValue(i, colHuongLuong, CapNhatCotChamCongRow.HuongLuong);
                        gridView1.SetRowCellValue(i, colAnTrua, CapNhatCotChamCongRow.AnTrua);
                        gridView1.SetRowCellValue(i, colNghiPhep, CapNhatCotChamCongRow.PhepNam);
                        gridView1.SetRowCellValue(i, colNgayPhep, CapNhatCotChamCongRow.NgayPhep);
                    }
                    DataProvider.Ins.DB.pr_LoadChamCong(IDChamCongRow);
                    DataProvider.Ins.DB.pr_bangLuongTongHop(1, IDNhanVienRow, dt.Month, dt.Year);
                    i++;
                }
            }
            if (!ckChamMotCot.Checked)
            {
                DataProvider.Ins.DB.Entry(DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == IDNhanVien).FirstOrDefault()).Reload();
                var CapNhatCotChamCong = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year && q.NhanVienID == IDNhanVien).FirstOrDefault();
                gridView1.SetFocusedRowCellValue(colHuongLuong, CapNhatCotChamCong.HuongLuong);
                gridView1.SetFocusedRowCellValue(colAnTrua, CapNhatCotChamCong.AnTrua);
                gridView1.SetFocusedRowCellValue(colNghiPhep, CapNhatCotChamCong.PhepNam);
                gridView1.SetFocusedRowCellValue(colNgayPhep, CapNhatCotChamCong.NgayPhep);
                DataProvider.Ins.DB.pr_LoadChamCong(IDChamCong);
                DataProvider.Ins.DB.pr_bangLuongTongHop(1, IDNhanVien, dt.Month, dt.Year);
                
            }
        }
        private void btn_ViewReport_Click(object sender, EventArgs e)
        {
            DateTime dt = dateThangNam.DateTime;
            lgBangLuongTableAdapter1.Fill(anGiangDataSet1.lgBangLuong, dt.Month, dt.Year);
            double? tongtien = DataProvider.Ins.DB.lgBangLuongs.Where(q => q.THANG == dt.Month && q.NAM == dt.Year).Sum(q => q.THUCLANH);
            DataTable tb = lgBangLuongTableAdapter1.GetData(dt.Month, dt.Year);
            XtraForm f = new frmXemBaoCao(dt.Year, dt.Month, tongtien, tb, "Xí Nghiệp Phà An Giang");
            f.ShowDialog();
        }
        
    }
}
