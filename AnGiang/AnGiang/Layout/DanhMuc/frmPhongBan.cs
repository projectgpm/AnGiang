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
using AnGiang.Model;

namespace AnGiang.Layout.DanhMuc
{
    public partial class frmPhongBan : DevExpress.XtraEditors.XtraForm
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.dvPhongBan' table. You can move, or remove it, as needed.
            this.dvPhongBanTableAdapter.Fill(this.anGiangDataSet.dvPhongBan);

        }

        private void gridViewPhongBan_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int id = int.Parse(gridViewPhongBan.GetFocusedRowCellValue(colIDPhongBan).ToString());
            dvPhongBan pb = DataProvider.Ins.DB.dvPhongBans.Find(id);
            if (pb == null)
            {
                pb = new dvPhongBan();
                pb.MaPhongBan = gridViewPhongBan.GetRowCellValue(e.RowHandle, colMaPhongBan).ToString();
                if (DataProvider.Ins.DB.dvPhongBans.Where(q => q.MaPhongBan == pb.MaPhongBan && q.DaXoa==0).Count() == 1)
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridViewPhongBan.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    pb.TenPhongBan = gridViewPhongBan.GetRowCellValue(e.RowHandle, colTenPhongBan).ToString();
                    pb.DonViID = 1;
                    pb.GhiChu = gridViewPhongBan.GetRowCellValue(e.RowHandle, colGhiChu).ToString();
                    pb.DaXoa = 0;
                    pb.NgayTao = pb.NgayCapNhat = DateTime.Now;
                    DataProvider.Ins.DB.dvPhongBans.Add(pb);
                }
            }
            else
            {
                pb.MaPhongBan = gridViewPhongBan.GetRowCellValue(e.RowHandle, colMaPhongBan).ToString();
                if (DataProvider.Ins.DB.dvPhongBans.Where(q => q.MaPhongBan == pb.MaPhongBan && q.DaXoa == 0).Count() == 1)
                {
                    MessageBox.Show("Mã phòng ban đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridViewPhongBan.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    pb.TenPhongBan = gridViewPhongBan.GetRowCellValue(e.RowHandle, colTenPhongBan).ToString();
                    pb.DonViID = 1;
                    pb.GhiChu = gridViewPhongBan.GetRowCellValue(e.RowHandle, colGhiChu).ToString();
                    pb.NgayCapNhat = DateTime.Now;
                }
            }
            DataProvider.Ins.DB.SaveChanges();
            this.dvPhongBanTableAdapter.Fill(this.anGiangDataSet.dvPhongBan);
        }

        private void gridViewPhongBan_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName.Equals("") && e.Column.ColumnEdit.Name.CompareTo("beXoa") == 0)
                {

                    int id = int.Parse(gridViewPhongBan.GetRowCellValue(e.RowHandle, colIDPhongBan).ToString());
                    if (XtraMessageBox.Show("Bạn có muốn xóa phòng ban này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dvPhongBan pb = DataProvider.Ins.DB.dvPhongBans.Find(id);
                        pb.DaXoa = 1;
                        pb.NgayCapNhat = DateTime.Now;
                    }
                    else { return; }
                    DataProvider.Ins.DB.SaveChanges();
                    this.dvPhongBanTableAdapter.Fill(this.anGiangDataSet.dvPhongBan);
                }

            }
            catch
            {
                XtraMessageBox.Show("Không thể xóa trường này, vui lòng thử lại!", "GPM.VN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}