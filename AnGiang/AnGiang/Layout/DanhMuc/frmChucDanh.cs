﻿using System;
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

            int id = int.Parse(gridView1.GetFocusedRowCellValue(colIDChucDanh).ToString());
            nvChucDanh cd = DataProvider.Ins.DB.nvChucDanhs.Find(id);
            if (cd == null)
            {
                cd = new nvChucDanh();
                cd.MaChucDanh = gridView1.GetRowCellValue(e.RowHandle, colMaChucDanh).ToString();
                if (DataProvider.Ins.DB.nvChucDanhs.Where(q => q.MaChucDanh == cd.MaChucDanh).Count() == 1)
                {
                    MessageBox.Show("Mã chức danh đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //gridView1.DeleteRow(e.RowHandle);
                    gridView1.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    cd.GhiChu = gridView1.GetRowCellValue(e.RowHandle, colGhiChu).ToString();
                    cd.DaXoa = 0;
                    cd.NgayTao = cd.NgayCapNhat = DateTime.Now;
                    cd.DanhMucCDID = long.Parse(gridView1.GetRowCellValue(e.RowHandle, colDanhMucCDID).ToString());
                    cd.TenChucDanh = gridView1.GetRowCellValue(e.RowHandle, colTenChucDanh).ToString();
                    DataProvider.Ins.DB.nvChucDanhs.Add(cd);
                }
            }
            else
            {
                cd.MaChucDanh = gridView1.GetRowCellValue(e.RowHandle, colMaChucDanh).ToString();
                if (DataProvider.Ins.DB.nvChucDanhs.Where(q => q.MaChucDanh == cd.MaChucDanh).Count() == 1)
                {
                    MessageBox.Show("Mã chức danh đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gridView1.CancelUpdateCurrentRow();
                    return;
                }
                else
                {
                    cd.GhiChu = gridView1.GetRowCellValue(e.RowHandle, colGhiChu).ToString();
                    cd.NgayCapNhat = DateTime.Now;
                    cd.DanhMucCDID = long.Parse(gridView1.GetRowCellValue(e.RowHandle, colDanhMucCDID).ToString());
                    cd.TenChucDanh = gridView1.GetRowCellValue(e.RowHandle, colTenChucDanh).ToString();
                }
            }
            DataProvider.Ins.DB.SaveChanges();
            //load waiting form cập nhật thành công
        }
        #endregion
    }
}