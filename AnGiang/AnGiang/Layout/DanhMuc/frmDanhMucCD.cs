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
    public partial class frmDanhMucCD : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhMucCD()
        {
            InitializeComponent();
        }

        private void nvDanhMucCDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nvDanhMucCDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.anGiangDataSet);
        }

        private void frmDanhMucCD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.nvDanhMucCD' table. You can move, or remove it, as needed.
            this.nvDanhMucCDTableAdapter.Fill(this.anGiangDataSet.nvDanhMucCD);
        }

        private void gridViewDanhMucCD_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int id = int.Parse(gridViewDanhMucCD.GetFocusedRowCellValue(colIDDanhMucCD).ToString());
            nvDanhMucCD dmuc = DataProvider.Ins.DB.nvDanhMucCDs.Find(id);
            if (dmuc == null)
            {
                dmuc = new nvDanhMucCD();
                dmuc.TenChucDanh = gridViewDanhMucCD.GetRowCellValue(e.RowHandle, colTenChucDanh).ToString();
                if (DataProvider.Ins.DB.nvDanhMucCDs.Where(q => q.TenChucDanh == dmuc.TenChucDanh).Count() == 1)
                {
                    MessageBox.Show("Tên danh mục đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //gridView1.DeleteRow(e.RowHandle);
                    gridViewDanhMucCD.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    dmuc.DaXoa = 0;
                    dmuc.NgayTao = dmuc.NgayCapNhat = DateTime.Now;
                    DataProvider.Ins.DB.nvDanhMucCDs.Add(dmuc);
                }
            }
            else
            {
                dmuc.TenChucDanh = gridViewDanhMucCD.GetRowCellValue(e.RowHandle, colTenChucDanh).ToString();
                if (DataProvider.Ins.DB.nvDanhMucCDs.Where(q => q.TenChucDanh == dmuc.TenChucDanh).Count() == 1)
                {
                    MessageBox.Show("Tên danh mục đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridViewDanhMucCD.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    dmuc.NgayCapNhat = DateTime.Now;
                }
            }
            DataProvider.Ins.DB.SaveChanges();
            this.nvDanhMucCDTableAdapter.Fill(this.anGiangDataSet.nvDanhMucCD);
        }

        private void gridViewDanhMucCD_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                if (e.Column.FieldName.Equals("") && e.Column.ColumnEdit.Name.CompareTo("beXoa") == 0)
                {

                    int id = int.Parse(gridViewDanhMucCD.GetRowCellValue(e.RowHandle, colIDDanhMucCD).ToString());
                    if (XtraMessageBox.Show("Bạn có muốn xóa danh mục này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        nvDanhMucCD cd = DataProvider.Ins.DB.nvDanhMucCDs.Find(id);
                        cd.DaXoa = 1;
                        cd.NgayCapNhat = DateTime.Now;

                    }
                    else { return; }
                    DataProvider.Ins.DB.SaveChanges();
                    this.nvDanhMucCDTableAdapter.Fill(this.anGiangDataSet.nvDanhMucCD);
                }

            }
            catch
            {
                XtraMessageBox.Show("Không thể xóa trường này, vui lòng thử lại!", "GPM.VN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}