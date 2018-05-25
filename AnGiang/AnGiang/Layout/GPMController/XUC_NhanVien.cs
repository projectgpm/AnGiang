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
            nvChucDanhTableAdapter.Fill(this.anGiangDataSet.nvChucDanh);
            nvDanhMucCDTableAdapter.Fill(this.anGiangDataSet.nvDanhMucCD);
            addDataBinding();
            EnableGroup(false, false);
            bbiCancel.Enabled = bbiRefresh.Enabled = bbiDelete.Enabled = false;
            
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
            this.heSoLuongTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "HeSoLuong", true));
            this.heSoChucDanhSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "HeSoChucDanh", true));
            this.tGPCKKSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "TGPCKK", true));
            this.chucDanhIDSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nvNhanVienBindingSource, "ChucDanhID", true));
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
            this.heSoLuongTextEdit.DataBindings.Clear();
            this.heSoChucDanhSpinEdit.DataBindings.Clear();
            this.tGPCKKSpinEdit.DataBindings.Clear();
            this.chucDanhIDSpinEdit.DataBindings.Clear();
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
            EnableGroup(true, true);
            bbiRefresh.Enabled = bbiCancel.Enabled = true;
            bbiNew.Enabled = bbiEdit.Enabled = false;
            int countnv = DataProvider.Ins.DB.nvNhanViens.Count()+1;
            string MaNV = "NV"+countnv.ToString("0000");
            maNhanVienTextEdit.Text = MaNV;
        }
        //cập nhật nv
        private void bbiEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiDelete.Enabled = bbiRefresh.Enabled = bbiCancel.Enabled = true;
            bbiNew.Enabled = bbiEdit.Enabled = false;
            EnableGroup(true, false);
        }
        //xóa nv
        private void bbiDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var manhanvien = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDNhanVien).ToString();
            if (XtraMessageBox.Show("Bạn muốn xóa nhân viên này không?", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int id = int.Parse(gridView1.GetFocusedRowCellValue(colIDNhanVien).ToString());
                if (id < 0)
                {
                    XtraMessageBox.Show("Bạn chưa chọn nhân viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    nvNhanVien nvxoa = DataProvider.Ins.DB.nvNhanViens.Find(id);
                    nvxoa.NgayCapNhat = nvxoa.NgayNghiViec = DateTime.Now;
                    nvxoa.DaXoa = 1;
                    gridView1.DeleteSelectedRows();
                }
            }
        }
        //lưu lại
        private void bbiRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            nvNhanVien nv;
            int count = DataProvider.Ins.DB.nvNhanViens.Where(q => q.MaNhanVien == maNhanVienTextEdit.Text).Count();
            if (count == 0)
            {
                nv = new nvNhanVien();
                if (String.IsNullOrEmpty(maNhanVienTextEdit.Text))
                {
                    XtraMessageBox.Show("Mã nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                nv.MaNhanVien = maNhanVienTextEdit.Text;
                if (String.IsNullOrEmpty(hoTenTextEdit.Text))
                {
                    XtraMessageBox.Show("Tên nhân viên không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nv.HoTen = hoTenTextEdit.Text;
                nv.GioiTinh = gioiTinhSpinEdit.SelectedIndex;
                nv.GhiChu = ghiChuTextEdit.Text;
                nv.DiaChi = diaChiTextEdit.Text;
                nv.CMND = cMNDTextEdit.Text;
                nv.DienThoai = dienThoaiTextEdit.Text;
                if(ngayLamViecDateEdit.Text.Count()!=0)
                nv.NgayLamViec = ngayLamViecDateEdit.DateTime;
                if (ngaySinhdateEdit.Text.Count() != 0)
                nv.NgaySinh = ngaySinhdateEdit.DateTime;
                nv.NgayTao = nv.NgayCapNhat = DateTime.Now;
                nv.DaXoa = 0;
                nv.DonViID = 1;
                nv.TrinhDoID = long.Parse(trinhDoIDSpinEdit.EditValue.ToString());
                nv.PhongBanID = long.Parse(phongBanIDSpinEdit.EditValue.ToString());
                nv.HeSoLuong = double.Parse(heSoLuongTextEdit.Text);
                if(nv.HeSoLuong < 0)
                {
                    XtraMessageBox.Show("Hệ số lương phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nv.HeSoChucDanh = double.Parse(heSoChucDanhSpinEdit.EditValue.ToString());
                if (nv.HeSoChucDanh < 0)
                {
                    XtraMessageBox.Show("Hệ số chức danh phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nv.TGPCKK = int.Parse(tGPCKKSpinEdit.EditValue.ToString());
                if (nv.HeSoChucDanh < 0)
                {
                    XtraMessageBox.Show("Thời gian tính PCKK phải lớn hơn hoặc bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(chucDanhIDSpinEdit.EditValue.ToString()))
                {
                    XtraMessageBox.Show("Chưa chọn chức danh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                nv.ChucDanhID = long.Parse(chucDanhIDSpinEdit.EditValue.ToString());
                DataProvider.Ins.DB.nvNhanViens.Add(nv);
            }
            else 
            { 
                    
            }
            DataProvider.Ins.DB.SaveChanges();
            tableAdapterManager.nvNhanVienTableAdapter.Fill(anGiangDataSet.nvNhanVien);
        }
        // in 
        private void bbiPrintPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        //bật tắt group
        private void EnableGroup(bool b, bool clear)
        {
            maNhanVienTextEdit.Enabled = hoTenTextEdit.Enabled = dienThoaiTextEdit.Enabled = gioiTinhSpinEdit.Enabled = diaChiTextEdit.Enabled = cMNDTextEdit.Enabled = ngaySinhdateEdit.Enabled = trinhDoIDSpinEdit.Enabled = ngayLamViecDateEdit.Enabled = ngayNghiViecDateEdit.Enabled = phongBanIDSpinEdit.Enabled = ghiChuTextEdit.Enabled = heSoLuongTextEdit.Enabled = heSoChucDanhSpinEdit.Enabled = tGPCKKSpinEdit.Enabled = chucDanhIDSpinEdit.Enabled = b;
            if (clear)
                maNhanVienTextEdit.Text = hoTenTextEdit.Text = dienThoaiTextEdit.Text = gioiTinhSpinEdit.Text = diaChiTextEdit.Text = cMNDTextEdit.Text = ngaySinhdateEdit.Text = trinhDoIDSpinEdit.Text = ngayLamViecDateEdit.Text = ngayNghiViecDateEdit.Text = phongBanIDSpinEdit.Text = ghiChuTextEdit.Text = heSoLuongTextEdit.Text = heSoChucDanhSpinEdit.Text = tGPCKKSpinEdit.Text = chucDanhIDSpinEdit.Text = String.Empty;
        }
        //hủy thao tác
        private void bbiCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                addDataBinding();
            }
            catch
            {}

            bbiDelete.Enabled = bbiRefresh.Enabled = bbiCancel.Enabled = false;
            bbiNew.Enabled = bbiEdit.Enabled = true;
            EnableGroup(false, false);
            tableAdapterManager.nvNhanVienTableAdapter.Fill(anGiangDataSet.nvNhanVien);
            
        }

        private void HinhAnhPictureEdit_Validated(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Clicked");
        }

    }
}
