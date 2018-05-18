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
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.nvNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvNhanVienTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvNhanVienTableAdapter();
            this.tableAdapterManager = new AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager();
            this.trinhDoTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.TrinhDoTableAdapter();
            this.nvNhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.rlsPhongBan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.dvPhongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDonViID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrinhDoID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlsTrinhDo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.trinhDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dvPhongBanTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.dvPhongBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsTrinhDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.dvChuyenMonTableAdapter = null;
            this.tableAdapterManager.dvPhongBanTableAdapter = null;
            this.tableAdapterManager.nvChucDanhTableAdapter = null;
            this.tableAdapterManager.nvChucVuTableAdapter = null;
            this.tableAdapterManager.nvNhanVienTableAdapter = this.nvNhanVienTableAdapter;
            this.tableAdapterManager.TrinhDoTableAdapter = this.trinhDoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // trinhDoTableAdapter
            // 
            this.trinhDoTableAdapter.ClearBeforeFill = true;
            // 
            // nvNhanVienGridControl
            // 
            this.nvNhanVienGridControl.DataSource = this.nvNhanVienBindingSource;
            this.nvNhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvNhanVienGridControl.Location = new System.Drawing.Point(0, 0);
            this.nvNhanVienGridControl.MainView = this.gridView1;
            this.nvNhanVienGridControl.Name = "nvNhanVienGridControl";
            this.nvNhanVienGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlsTrinhDo,
            this.rlsPhongBan});
            this.nvNhanVienGridControl.Size = new System.Drawing.Size(1082, 572);
            this.nvNhanVienGridControl.TabIndex = 1;
            this.nvNhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView1.GridControl = this.nvNhanVienGridControl;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "PhongBanID", null, "({0})")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPhongBanID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIDNhanVien
            // 
            this.colIDNhanVien.FieldName = "IDNhanVien";
            this.colIDNhanVien.Name = "colIDNhanVien";
            this.colIDNhanVien.OptionsColumn.AllowEdit = false;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã nhân viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.OptionsColumn.AllowEdit = false;
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            this.colMaNhanVien.Width = 95;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.AllowEdit = false;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 142;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.OptionsColumn.AllowEdit = false;
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 2;
            this.colDienThoai.Width = 100;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.OptionsColumn.AllowEdit = false;
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            this.colGioiTinh.Width = 63;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            this.colDiaChi.Width = 89;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 5;
            this.colCMND.Width = 89;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 9;
            this.colGhiChu.Width = 175;
            // 
            // colNgayLamViec
            // 
            this.colNgayLamViec.Caption = "Ngày vào làm";
            this.colNgayLamViec.FieldName = "NgayLamViec";
            this.colNgayLamViec.Name = "colNgayLamViec";
            this.colNgayLamViec.OptionsColumn.AllowEdit = false;
            this.colNgayLamViec.Visible = true;
            this.colNgayLamViec.VisibleIndex = 7;
            this.colNgayLamViec.Width = 99;
            // 
            // colNgayNghiViec
            // 
            this.colNgayNghiViec.Caption = "Ngày nghĩ việc";
            this.colNgayNghiViec.FieldName = "NgayNghiViec";
            this.colNgayNghiViec.Name = "colNgayNghiViec";
            this.colNgayNghiViec.OptionsColumn.AllowEdit = false;
            this.colNgayNghiViec.Visible = true;
            this.colNgayNghiViec.VisibleIndex = 8;
            this.colNgayNghiViec.Width = 126;
            // 
            // colNgayTao
            // 
            this.colNgayTao.FieldName = "NgayTao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.OptionsColumn.AllowEdit = false;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsColumn.AllowEdit = false;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsColumn.AllowEdit = false;
            // 
            // colPhongBanID
            // 
            this.colPhongBanID.Caption = "Phòng ban";
            this.colPhongBanID.ColumnEdit = this.rlsPhongBan;
            this.colPhongBanID.FieldName = "PhongBanID";
            this.colPhongBanID.Name = "colPhongBanID";
            this.colPhongBanID.OptionsColumn.AllowEdit = false;
            this.colPhongBanID.Visible = true;
            this.colPhongBanID.VisibleIndex = 9;
            this.colPhongBanID.Width = 101;
            // 
            // rlsPhongBan
            // 
            this.rlsPhongBan.AutoHeight = false;
            this.rlsPhongBan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlsPhongBan.DataSource = this.dvPhongBanBindingSource;
            this.rlsPhongBan.DisplayMember = "TenPhongBan";
            this.rlsPhongBan.Name = "rlsPhongBan";
            this.rlsPhongBan.ValueMember = "IDPhongBan";
            // 
            // dvPhongBanBindingSource
            // 
            this.dvPhongBanBindingSource.DataMember = "dvPhongBan";
            this.dvPhongBanBindingSource.DataSource = this.anGiangDataSet;
            // 
            // colDonViID
            // 
            this.colDonViID.FieldName = "DonViID";
            this.colDonViID.Name = "colDonViID";
            this.colDonViID.OptionsColumn.AllowEdit = false;
            // 
            // colTrinhDoID
            // 
            this.colTrinhDoID.Caption = "Trình độ";
            this.colTrinhDoID.ColumnEdit = this.rlsTrinhDo;
            this.colTrinhDoID.FieldName = "TrinhDoID";
            this.colTrinhDoID.Name = "colTrinhDoID";
            this.colTrinhDoID.OptionsColumn.AllowEdit = false;
            this.colTrinhDoID.Visible = true;
            this.colTrinhDoID.VisibleIndex = 6;
            this.colTrinhDoID.Width = 82;
            // 
            // rlsTrinhDo
            // 
            this.rlsTrinhDo.AutoHeight = false;
            this.rlsTrinhDo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlsTrinhDo.DataSource = this.trinhDoBindingSource;
            this.rlsTrinhDo.DisplayMember = "TenTrinhDo";
            this.rlsTrinhDo.Name = "rlsTrinhDo";
            this.rlsTrinhDo.ValueMember = "IDTrinhDo";
            // 
            // trinhDoBindingSource
            // 
            this.trinhDoBindingSource.DataMember = "TrinhDo";
            this.trinhDoBindingSource.DataSource = this.anGiangDataSet;
            // 
            // dvPhongBanTableAdapter
            // 
            this.dvPhongBanTableAdapter.ClearBeforeFill = true;
            // 
            // frmDanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 572);
            this.Controls.Add(this.nvNhanVienGridControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDanhSachNV";
            this.Text = "Danh sách nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsTrinhDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource nvNhanVienBindingSource;
        private AnGiangDataSetTableAdapters.nvNhanVienTableAdapter nvNhanVienTableAdapter;
        private AnGiangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nvNhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private AnGiangDataSetTableAdapters.TrinhDoTableAdapter trinhDoTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlsTrinhDo;
        private System.Windows.Forms.BindingSource trinhDoBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlsPhongBan;
        private System.Windows.Forms.BindingSource dvPhongBanBindingSource;
        private AnGiangDataSetTableAdapters.dvPhongBanTableAdapter dvPhongBanTableAdapter;
    }
}