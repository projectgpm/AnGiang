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

namespace AnGiang.Layout.GPMController
{
    public partial class XUC_ChamCong : DevExpress.XtraEditors.XtraUserControl
    {
        public XUC_ChamCong()
        {
            InitializeComponent();
            nvNhanVienPhongBanTableAdapter1.Fill(anGiangDataSet1.nvNhanVienPhongBan);
            ccKyHieuTableAdapter.Fill(anGiangDataSet1.ccKyHieu);
        }

        #region Kiem tra
        public bool laNamNhuan(int nYear)
        {
            if ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0)
            {
                return true;
            }
            return false;

            // <=> return ((nYear % 4 == 0 && nYear % 100 != 0) || nYear % 400 == 0);
        }
        // Hàm trả về số ngày trong tháng thuộc năm cho trước
        public int tinhSoNgayTrongThang(int nMonth, int nYear)
        {
            int nNumOfDays = 0;

            switch (nMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    nNumOfDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    nNumOfDays = 30;
                    break;
                case 2:
                    if (laNamNhuan(nYear))
                    {
                        nNumOfDays = 29;
                    }
                    else
                    {
                        nNumOfDays = 28;
                    }
                    break;
            }

            return nNumOfDays;
        }

        #endregion

        private void XUC_ChamCong_Load(object sender, EventArgs e)
        {          
            gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            gridView1.OptionsView.ShowIndicator = false;
            gridView1.OptionsBehavior.AutoExpandAllGroups = true;
        }
        private void dateThangNam_EditValueChanged(object sender, EventArgs e)
        {
            if (dateThangNam == null)
                return;
            gridControl1.DataSource = null;
            DateTime dt = dateThangNam.DateTime;
            gridView1.Columns.Clear();
            //var chamcong = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year);
            DataTable tb = nvNhanVienPhongBanTableAdapter1.GetData();             
            AnGiang.Model.ccKyHieu layMacDinh = AnGiang.Model.DataProvider.Ins.DB.ccKyHieux.Where(q => q.MacDinh == 1).First();
            List<int> ngaycuoituan = new List<int>();
            _SoNgay = tinhSoNgayTrongThang(dt.Month, dt.Year);
            for (int i = 1; i <= _SoNgay; i++)
            {
                DataColumn coldt = new DataColumn(i.ToString());                                
                string temp = dt.Year + "-" + dt.Month.ToString("00") + "-" + i.ToString("00");
                DateTime KiemTraCuoiTuan = DateTime.ParseExact(temp + " 00:00:00,000", "yyyy-MM-dd HH:mm:ss,fff", System.Globalization.CultureInfo.InvariantCulture);
                if ((KiemTraCuoiTuan.DayOfWeek == DayOfWeek.Sunday) || (KiemTraCuoiTuan.DayOfWeek == DayOfWeek.Saturday))
                {
                    ngaycuoituan.Add(i);
                }else
                {
                    coldt.DefaultValue = layMacDinh.MaKyHieu;
                }

                tb.Columns.Add(coldt);
            }

            #region khoi tao
            tb.Columns.Add("HuongLuong");
            tb.Columns.Add("AnTrua");
            tb.Columns.Add("PhepNam");
            gridControl1.DataSource = tb;
            GridColumn colTenPhongBan = gridView1.Columns.ColumnByFieldName("TenPhongBan");
            GridColumn colHuongLuong = gridView1.Columns.ColumnByFieldName("HuongLuong");
            GridColumn colAnTrua = gridView1.Columns.ColumnByFieldName("AnTrua");
            GridColumn colNghiPhep = gridView1.Columns.ColumnByFieldName("PhepNam");
            GridColumn colHoten = gridView1.Columns.ColumnByFieldName("HoTen");
            GridColumn colNhanVien = gridView1.Columns.ColumnByFieldName("IDNhanVien");
            colTenPhongBan.GroupIndex = 0;          
            colNhanVien.Visible = false;
            colNhanVien.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;            
            colHoten.OptionsColumn.ReadOnly = true;
            colHuongLuong.OptionsColumn.ReadOnly = true;
            colAnTrua.OptionsColumn.ReadOnly = true;
            colNghiPhep.OptionsColumn.ReadOnly = true;
            colHoten.Caption = "Họ tên";
            colHuongLuong.Caption = "Hưỡng lương";
            colHoten.Caption = "Ăn trưa";
            colHoten.Caption = "Phép năm";
            colHoten.MinWidth = 200;
            colHoten.MaxWidth = 200;
            colHoten.Fixed = FixedStyle.Left;           
            colHuongLuong.MinWidth = 70;
            colAnTrua.MinWidth = 70;
            colNghiPhep.MinWidth = 70;
            colHuongLuong.OptionsColumn.FixedWidth = false;
            colAnTrua.OptionsColumn.FixedWidth = false;            
            colNghiPhep.OptionsColumn.FixedWidth = false;
            for (int i = 1; i <= _SoNgay; i++)
            {
                GridColumn col = gridView1.Columns.ColumnByFieldName(i.ToString());
                col.MaxWidth = 30;
                col.MinWidth = 30;
                col.OptionsFilter.AllowFilter = false;
                col.OptionsFilter.AllowAutoFilter = false;
                col.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
                //col.OptionsColumn.ReadOnly=true;
                if(ngaycuoituan.Contains(i))
                {
                    col.AppearanceHeader.BackColor = Color.DarkSalmon;
                    col.AppearanceCell.BackColor = Color.DarkSalmon;                   
                }
            }
            #endregion
        }

        private void cbLoaiChamCong_EditValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiChamCong.EditValue != null)
            {
                var loaichamcong = DataProvider.Ins.DB.ccKyHieux.Find(cbLoaiChamCong.EditValue);
                if(loaichamcong!=null)
                _MaKyHieu = loaichamcong.MaKyHieu;
            }
        }

        private string _MaKyHieu = string.Empty;
        private int _SoNgay = 0;
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            switch(e.Column.FieldName)
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

            if (ckBatDauSua.Checked)
            {
                gridView1.SetFocusedRowCellValue(e.Column, _MaKyHieu);
                //gridView1.
                //int ID = (int)gridView1.GetRowCellValue(e.RowHandle, "IDNhanVien");
                 //DateTime dt = dateThangNam.DateTime;
                 //DataProvider.Ins.DB.pr_ThemChamCong(ID, dt.Month, dt.Year, _SoNgay);
                 //var chamcong = DataProvider.Ins.DB.ccChamCongs.Where(q => q.Thang == dt.Month && q.Nam == dt.Year);
                 //if (chamcong != null)
                 //{
                 //    DataProvider.Ins.DB.pr_ThemChiTiet((int)cbLoaiChamCong.EditValue, chamcong.First().IDChamCong, int.Parse(e.Column.FieldName));
                 //}
            }
            if(ck_ChamMotHang.Checked)
            {
                for (int i = 1; i <= _SoNgay; i++)
                {
                    GridColumn col = gridView1.Columns.ColumnByFieldName(i.ToString());
                    gridView1.SetFocusedRowCellValue(col, _MaKyHieu);
                }
            }

            if(ck_ChamMotCot.Checked)
            {
                 DataTable tb = nvNhanVienPhongBanTableAdapter1.GetData();
                int i=0;
                foreach(DataRow r in tb.Rows)
                {                   
                    gridView1.SetRowCellValue(gridView1.GetRowHandle(i),e.Column, _MaKyHieu);
                    i++;
                }
            
            }
           
        }

        private void cbLoaiChamCong_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption.Contains("hủy"))
            {
                cbLoaiChamCong.EditValue = null;
                _MaKyHieu = string.Empty;
            }
        }
    }
}
