using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.Utils.Win;
using AnGiang.Model;

namespace AnGiang.Layout.GPMController
{
    public partial class XUC_NhanVien : UserControl
    {
        public XUC_NhanVien()
        {
            InitializeComponent();
            dvPhongBanTableAdapter.Fill(this.anGiangDataSet.dvPhongBan);
            trinhDoTableAdapter.Fill(this.anGiangDataSet.TrinhDo);
            nvNhanVienTableAdapter.Fill(this.anGiangDataSet.nvNhanVien);
            addDataBinding();
        }
        //binding vào grid và textbox
        private void addDataBinding()
        {
            this.maNhanVienTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "MaNhanVien", true));
            this.hoTenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "HoTen", true));
            this.dienThoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "DienThoai", true));
            this.gioiTinhSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.nvNhanVienBindingSource, "GioiTinh", true));
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "DiaChi", true));
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "CMND", true));
            this.ghiChuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "GhiChu", true));
            this.ngayLamViecDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "NgayLamViec", true));
            this.ngayNghiViecDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "NgayNghiViec", true));
            this.trinhDoIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "TrinhDoID", true));
            this.phongBanIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "PhongBanID", true));
        }
        //xóa binding
        private void clearDataBinding()
        {
            this.maNhanVienTextEdit.DataBindings.Clear();
            this.hoTenTextEdit.DataBindings.Clear();
            this.dienThoaiTextEdit.DataBindings.Clear();
            this.gioiTinhSpinEdit.DataBindings.Clear();
            this.diaChiTextEdit.DataBindings.Clear();
            this.cMNDTextEdit.DataBindings.Clear();
            this.ghiChuTextEdit.DataBindings.Clear();
            this.ngayLamViecDateEdit.DataBindings.Clear();
            this.ngayNghiViecDateEdit.DataBindings.Clear();
            this.trinhDoIDSpinEdit.DataBindings.Clear();
            this.phongBanIDSpinEdit.DataBindings.Clear();
        }

        //set witdh popup
        private void phongBanIDSpinEdit_Popup(object sender, EventArgs e)
        {
            LookUpEdit edit = sender as LookUpEdit;
            PopupLookUpEditForm f = (edit as IPopupControl).PopupWindow as PopupLookUpEditForm;
            f.Width = 300;
        }

        private void trinhDoIDSpinEdit_Popup(object sender, EventArgs e)
        {
            LookUpEdit edit = sender as LookUpEdit;
            PopupLookUpEditForm f = (edit as IPopupControl).PopupWindow as PopupLookUpEditForm;
            f.Width = 300;
        }
        //thêm nv
        private void bbiNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clearDataBinding();
            nvNhanVien nv = new nvNhanVien();
            if (DataProvider.Ins.DB.nvNhanViens.Where(q => q.MaNhanVien==maNhanVienTextEdit.Text).Count()!=0)
            {
                XtraMessageBox.Show("Mã nhân viên đã tồn tại!", "Thêm nhân viên không thành công!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nv.HoTen = hoTenTextEdit.Text;
            nv.MaNhanVien = maNhanVienTextEdit.Text;
            if (ngaySinhdateEdit.Text.Length != 0)
                nv.NgaySinh = ngaySinhdateEdit.DateTime;
            nv.PhongBanID = (long)phongBanIDSpinEdit.EditValue;
            nv.DaXoa = 0;
            nv.DonViID = 1;
            nv.CMND = cMNDTextEdit.Text;
            nv.DiaChi = diaChiTextEdit.Text;
            nv.GioiTinh = gioiTinhSpinEdit.SelectedIndex;
            nv.NgayLamViec = ngayLamViecDateEdit.DateTime;
            nv.DienThoai = dienThoaiTextEdit.Text;
            nv.GhiChu = ghiChuTextEdit.Text;
            if (ngayNghiViecDateEdit.Text.Length != 0)
                nv.NgayNghiViec = ngayNghiViecDateEdit.DateTime;
            DataProvider.Ins.DB.nvNhanViens.Add(nv);
            DataProvider.Ins.DB.SaveChanges();
            tableAdapterManager.nvNhanVienTableAdapter.Fill(anGiangDataSet.nvNhanVien);
            addDataBinding();

            
        }
        //cập nhật nv
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Validate();
            this.nvNhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.anGiangDataSet);
        }
        //xóa nv
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var manhanvien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDNhanVien).ToString();
            if (XtraMessageBox.Show("Bạn muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                txtDaXoaTmp.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "DaXoa", true));
                txtDaXoaTmp.Text = "1";
                bbiEdit_ItemClick(sender, e);
                txtDaXoaTmp.DataBindings.Clear();
            }
        }
        //refresh grid
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tableAdapterManager.nvNhanVienTableAdapter.Fill(anGiangDataSet.nvNhanVien);
        }

        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

    }
}
