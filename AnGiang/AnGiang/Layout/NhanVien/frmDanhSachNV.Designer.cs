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
            this.nvNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.dvPhongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trinhDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvNhanVienTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvNhanVienTableAdapter();
            this.trinhDoTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.TrinhDoTableAdapter();
            this.dvPhongBanTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.dvPhongBanTableAdapter();
            this.rlsTrinhDo = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.rlsPhongBan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridViewNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.gridControlNhanVien = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsTrinhDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // nvNhanVienBindingSource
            // 
            this.nvNhanVienBindingSource.DataMember = "nvNhanVien";
            this.nvNhanVienBindingSource.DataSource = this.anGiangDataSet;
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dvPhongBanBindingSource
            // 
            this.dvPhongBanBindingSource.DataMember = "dvPhongBan";
            this.dvPhongBanBindingSource.DataSource = this.anGiangDataSet;
            // 
            // trinhDoBindingSource
            // 
            this.trinhDoBindingSource.DataMember = "TrinhDo";
            this.trinhDoBindingSource.DataSource = this.anGiangDataSet;
            // 
            // nvNhanVienTableAdapter
            // 
            this.nvNhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // trinhDoTableAdapter
            // 
            this.trinhDoTableAdapter.ClearBeforeFill = true;
            // 
            // dvPhongBanTableAdapter
            // 
            this.dvPhongBanTableAdapter.ClearBeforeFill = true;
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
            this.gridViewNhanVien.GroupCount = 1;
            this.gridViewNhanVien.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "PhongBanID", null, "({0})")});
            this.gridViewNhanVien.Name = "gridViewNhanVien";
            this.gridViewNhanVien.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewNhanVien.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewNhanVien.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPhongBanID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewNhanVien.ViewCaption = "Danh sách nhân viên";
            this.gridViewNhanVien.DoubleClick += new System.EventHandler(this.gridViewNhanVien_DoubleClick);
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
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.AllowEdit = false;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colDienThoai
            // 
            this.colDienThoai.Caption = "Điện thoại";
            this.colDienThoai.FieldName = "DienThoai";
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.OptionsColumn.AllowEdit = false;
            this.colDienThoai.Visible = true;
            this.colDienThoai.VisibleIndex = 2;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.OptionsColumn.AllowEdit = false;
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 3;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.AllowEdit = false;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.AllowEdit = false;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 5;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 7;
            // 
            // colNgayLamViec
            // 
            this.colNgayLamViec.Caption = "Ngày vào làm";
            this.colNgayLamViec.FieldName = "NgayLamViec";
            this.colNgayLamViec.Name = "colNgayLamViec";
            this.colNgayLamViec.OptionsColumn.AllowEdit = false;
            this.colNgayLamViec.Visible = true;
            this.colNgayLamViec.VisibleIndex = 8;
            // 
            // colNgayNghiViec
            // 
            this.colNgayNghiViec.Caption = "Ngày nghĩ việc";
            this.colNgayNghiViec.FieldName = "NgayNghiViec";
            this.colNgayNghiViec.Name = "colNgayNghiViec";
            this.colNgayNghiViec.OptionsColumn.AllowEdit = false;
            this.colNgayNghiViec.Visible = true;
            this.colNgayNghiViec.VisibleIndex = 9;
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
            // 
            // gridControlNhanVien
            // 
            this.gridControlNhanVien.DataSource = this.nvNhanVienBindingSource;
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhanVien.MainView = this.gridViewNhanVien;
            this.gridControlNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlsTrinhDo,
            this.rlsPhongBan});
            this.gridControlNhanVien.Size = new System.Drawing.Size(1148, 628);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            // 
            // frmDanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 628);
            this.Controls.Add(this.gridControlNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDanhSachNV";
            this.Text = "frmDanhSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsTrinhDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource nvNhanVienBindingSource;
        private AnGiangDataSetTableAdapters.nvNhanVienTableAdapter nvNhanVienTableAdapter;
        private System.Windows.Forms.BindingSource trinhDoBindingSource;
        private AnGiangDataSetTableAdapters.TrinhDoTableAdapter trinhDoTableAdapter;
        private System.Windows.Forms.BindingSource dvPhongBanBindingSource;
        private AnGiangDataSetTableAdapters.dvPhongBanTableAdapter dvPhongBanTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlsTrinhDo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlsPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNhanVien;
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
        private DevExpress.XtraGrid.GridControl gridControlNhanVien;

    }
}