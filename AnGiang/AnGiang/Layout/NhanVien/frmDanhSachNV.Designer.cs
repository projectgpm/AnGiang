namespace AnGiang.Layout.NhanVien
{
    partial class frmDanhSachNV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.nvNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvNhanVienTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvNhanVienTableAdapter();
            this.colIDNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLamViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNghiViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongBanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrinhDoID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.DataSource = this.nvNhanVienBindingSource;
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhanVien.MainView = this.gridViewNhanVien;
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.Size = new System.Drawing.Size(984, 510);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // gridViewNhanVien
            // 
            this.gridViewNhanVien.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.gridViewNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDNhanVien,
            this.colMaNhanVien,
            this.colHoTen,
            this.colDienThoai,
            this.colGioiTinh,
            this.colDiaChi,
            this.colCMND,
            this.colGhiChu,
            this.colNgayLamViec,
            this.colNgayNghiViec,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colPhongBanID,
            this.colDonViID,
            this.colTrinhDoID});
            this.gridViewNhanVien.GridControl = this.gridControlNhanVien;
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewNhanVien.ViewCaption = "Danh sách nhân viên";
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nvNhanVienBindingSource
            // 
            this.nvNhanVienBindingSource.DataMember = "nvNhanVien";
            this.nvNhanVienBindingSource.DataSource = this.anGiangDataSet;
            // 
            // nvNhanVienTableAdapter
            // 
            this.nvNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // colIDNhanVien
            // 
            this.colIDNhanVien.FieldName = "IDNhanVien";
            this.colIDNhanVien.Name = "colIDNhanVien";
            this.colIDNhanVien.Visible = true;
            this.colIDNhanVien.VisibleIndex = 0;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 1;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 2;
            // 
            // colDienThoai
            // 
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 3;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 4;
            // 
            // colDiaChi
            // 
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 5;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 6;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 7;
            // 
            // colNgayLamViec
            // 
            this.colNgayLamViec.FieldName = "NgayLamViec";
            this.colNgayLamViec.Name = "colNgayLamViec";
            this.colNgayLamViec.Visible = true;
            this.colNgayLamViec.VisibleIndex = 8;
            // 
            // colNgayNghiViec
            // 
            this.colNgayNghiViec.FieldName = "NgayNghiViec";
            this.colNgayNghiViec.Name = "colNgayNghiViec";
            this.colNgayNghiViec.Visible = true;
            this.colNgayNghiViec.VisibleIndex = 9;
            // 
            // colNgayTao
            // 
            this.colNgayTao.FieldName = "NgayTao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.Visible = true;
            this.colNgayTao.VisibleIndex = 10;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 11;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 12;
            // 
            // colPhongBanID
            // 
            this.colPhongBanID.FieldName = "PhongBanID";
            this.colPhongBanID.Name = "colPhongBanID";
            this.colPhongBanID.Visible = true;
            this.colPhongBanID.VisibleIndex = 13;
            // 
            // colDonViID
            // 
            this.colDonViID.FieldName = "DonViID";
            this.colDonViID.Name = "colDonViID";
            this.colDonViID.Visible = true;
            this.colDonViID.VisibleIndex = 14;
            // 
            // colTrinhDoID
            // 
            this.colTrinhDoID.FieldName = "TrinhDoID";
            this.colTrinhDoID.Name = "colTrinhDoID";
            this.colTrinhDoID.Visible = true;
            this.colTrinhDoID.VisibleIndex = 15;
            // 
            // frmDanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 510);
            this.Controls.Add(this.gridControlNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachNV";
            this.Text = "frmDanhSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource nvNhanVienBindingSource;
        private AnGiangDataSetTableAdapters.nvNhanVienTableAdapter nvNhanVienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLamViec;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNghiViec;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBanID;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViID;
        private DevExpress.XtraGrid.Columns.GridColumn colTrinhDoID;

    }
}