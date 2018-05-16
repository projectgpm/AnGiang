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
using QLCafe.DAO;

namespace QLCafe
{
    public partial class frmTachBan : DevExpress.XtraEditors.XtraForm
    {
        public static bool Ngoai_KiemTra = false;
        DataTable tb;
        public frmTachBan()
        {
            InitializeComponent();
            lbTTTachBan.Text = string.Format("Tách từ {0} ra bàn {1}", frmBanHang.Ngoai_TenBan1, frmBanHang.Ngoai_TenBan2);
            lbChiTiet.Text += frmBanHang.Ngoai_TenBan2+"!";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Ngoai_KiemTra = false;
            this.Close();
        }

        private void frmTachBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_ChiTietHoaDon_Temp' table. You can move, or remove it, as needed.
            this.cF_ChiTietHoaDon_TempTableAdapter.FillByIDHoaDon(this.quanlycafeDataSet.CF_ChiTietHoaDon_Temp,frmBanHang.Ngoai_IDhoadon);
            tb = DataProvider.Instance.ExecuteQuery("SELECT * FROM CF_ChiTietHoaDon_Temp WHERE IDHoaDon=" + frmBanHang.Ngoai_IDhoadon.ToString());
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                int soluong = int.Parse(gridView1.GetRowCellValue(i, colSoLuong).ToString());
                int IDHangHoa = int.Parse(gridView1.GetRowCellValue(i, colIDHangHoa).ToString());
                DataProvider.Instance.GoiMon(frmBanHang.Ngoai_IDBan2, IDHangHoa, soluong, frmDangNhap.NguoiDung);
                int SLCu = int.Parse(tb.Rows[i]["SoLuong"].ToString());
                DataProvider.Instance.ThayDoiSoLuong(0, frmBanHang.Ngoai_IDhoadon.ToString(), IDHangHoa.ToString(), SLCu - soluong, frmDangNhap.NguoiDung);                               
            }
            string chitiet = "Tách " + frmBanHang.Ngoai_TenBan1 + " Sang " + frmBanHang.Ngoai_TenBan2;
            DataProvider.Instance.ThemLichSuThaoTac("Tách", chitiet, frmDangNhap.NguoiDung.Id);
            Ngoai_KiemTra = true;
            this.Close();
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            if (e.Column.Name == colSoLuong.Name)
            {
                repositoryItemSpinEdit1.MaxValue = int.Parse(tb.Rows[gridView1.FocusedRowHandle]["SoLuong"].ToString());
            }
        }
    }
}