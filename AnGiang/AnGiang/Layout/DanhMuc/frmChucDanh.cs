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
    public partial class frmChucDanh : DevExpress.XtraEditors.XtraForm
    {
        public frmChucDanh()
        {
            InitializeComponent();
        }

        private void frmChucDanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.nvDanhMucCD' table. You can move, or remove it, as needed.
            this.nvDanhMucCDTableAdapter.Fill(this.anGiangDataSet.nvDanhMucCD);
            // TODO: This line of code loads data into the 'anGiangDataSet.nvChucDanh' table. You can move, or remove it, as needed.
            this.nvChucDanhTableAdapter.Fill(this.anGiangDataSet.nvChucDanh);
            

        }
        #region binding dữ liệu
        private void nvChucDanhBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nvChucDanhBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.anGiangDataSet);
        }
        #endregion
        #region thêm xóa sửa chức danh (1 dòng)
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            rlsDanhMucCD.NullText = "Chưa chọn";
        }
        //thêm, sửa
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

            int id = int.Parse(gridViewChucDanh.GetFocusedRowCellValue(colIDChucDanh).ToString());
            nvChucDanh cd = DataProvider.Ins.DB.nvChucDanhs.Find(id);
            if (cd == null)
            {
                cd = new nvChucDanh();
                cd.MaChucDanh = gridViewChucDanh.GetRowCellValue(e.RowHandle, colMaChucDanh).ToString();
                if (DataProvider.Ins.DB.nvChucDanhs.Where(q => q.MaChucDanh == cd.MaChucDanh).Count() == 1)
                {
                    MessageBox.Show("Mã chức danh đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //gridView1.DeleteRow(e.RowHandle);
                    gridViewChucDanh.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    cd.GhiChu = gridViewChucDanh.GetRowCellValue(e.RowHandle, colGhiChu).ToString();
                    cd.DaXoa = 0;
                    cd.NgayTao = cd.NgayCapNhat = DateTime.Now;
                    cd.DanhMucCDID = long.Parse(gridViewChucDanh.GetRowCellValue(e.RowHandle, colDanhMucCDID).ToString());
                    cd.TenChucDanh = gridViewChucDanh.GetRowCellValue(e.RowHandle, colTenChucDanh).ToString();
                    DataProvider.Ins.DB.nvChucDanhs.Add(cd);
                }
            }
            else
            {
                cd.MaChucDanh = gridViewChucDanh.GetRowCellValue(e.RowHandle, colMaChucDanh).ToString();
                if (DataProvider.Ins.DB.nvChucDanhs.Where(q => q.MaChucDanh == cd.MaChucDanh).Count() == 1)
                {
                    MessageBox.Show("Mã chức danh đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridViewChucDanh.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    cd.GhiChu = gridViewChucDanh.GetRowCellValue(e.RowHandle, colGhiChu).ToString();
                    cd.NgayCapNhat = DateTime.Now;
                    cd.DanhMucCDID = long.Parse(gridViewChucDanh.GetRowCellValue(e.RowHandle, colDanhMucCDID).ToString());
                    cd.TenChucDanh = gridViewChucDanh.GetRowCellValue(e.RowHandle, colTenChucDanh).ToString();
                }
            }
            DataProvider.Ins.DB.SaveChanges();
            this.nvChucDanhTableAdapter.Fill(this.anGiangDataSet.nvChucDanh);
            //load waiting form cập nhật thành công
        }
        #endregion

        private void gridViewChucDanh_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName.Equals("") && e.Column.ColumnEdit.Name.CompareTo("beXoa") == 0)
                {
                    
                    int id = int.Parse(gridViewChucDanh.GetRowCellValue(e.RowHandle, colIDChucDanh).ToString());
                    if (XtraMessageBox.Show("Bạn có muốn xóa chức danh này không?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        nvChucDanh cd = DataProvider.Ins.DB.nvChucDanhs.Find(id);
                        cd.DaXoa = 1;
                        cd.NgayCapNhat = DateTime.Now;
                        
                    }else { return; }
                    DataProvider.Ins.DB.SaveChanges();
                    this.nvChucDanhTableAdapter.Fill(this.anGiangDataSet.nvChucDanh);
                }
                
            }
            catch 
            {
                XtraMessageBox.Show("Không thể xóa trường này, vui lòng thử lại!", "GPM.VN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}