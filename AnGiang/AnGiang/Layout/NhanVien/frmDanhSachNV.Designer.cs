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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachNV));
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.dvPhongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trinhDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl2 = new DevExpress.Utils.FlyoutPanelControl();
            this.xuC_NhanVien1 = new AnGiang.Layout.GPMController.XUC_NhanVien();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsTrinhDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).BeginInit();
            this.flyoutPanelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.gridControlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNhanVien.Location = new System.Drawing.Point(0, 0);
            this.gridControlNhanVien.MainView = this.gridViewNhanVien;
            this.gridControlNhanVien.Name = "gridControlNhanVien";
            this.gridControlNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlsTrinhDo,
            this.rlsPhongBan});
            this.gridControlNhanVien.Size = new System.Drawing.Size(984, 589);
            this.gridControlNhanVien.TabIndex = 0;
            this.gridControlNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNhanVien});
            this.gridControlNhanVien.DoubleClick += new System.EventHandler(this.gridControlNhanVien_DoubleClick);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl2);
            this.flyoutPanel1.Location = new System.Drawing.Point(48, 0);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Left;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OwnerControl = this.gridControlNhanVien;
            this.flyoutPanel1.Size = new System.Drawing.Size(728, 577);
            this.flyoutPanel1.TabIndex = 2;
            // 
            // flyoutPanelControl2
            // 
            this.flyoutPanelControl2.Controls.Add(this.xuC_NhanVien1);
            this.flyoutPanelControl2.Controls.Add(this.panelControl1);
            this.flyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl2.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl2.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl2.Name = "flyoutPanelControl2";
            this.flyoutPanelControl2.Size = new System.Drawing.Size(728, 577);
            this.flyoutPanelControl2.TabIndex = 0;
            // 
            // xuC_NhanVien1
            // 
            this.xuC_NhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuC_NhanVien1.Location = new System.Drawing.Point(2, 41);
            this.xuC_NhanVien1.Margin = new System.Windows.Forms.Padding(2);
            this.xuC_NhanVien1.Name = "xuC_NhanVien1";
            this.xuC_NhanVien1.Size = new System.Drawing.Size(724, 534);
            this.xuC_NhanVien1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(3);
            this.panelControl1.Size = new System.Drawing.Size(724, 39);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(685, 33);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thông tin nhân viên";
            // 
            // simpleButton1
            // 
            this.simpleButton1.AllowFocus = false;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(688, 3);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(33, 33);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // frmDanhSachNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 589);
            this.Controls.Add(this.flyoutPanel1);
            this.Controls.Add(this.gridControlNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachNV";
            this.Text = "frmDanhSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsTrinhDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl2)).EndInit();
            this.flyoutPanelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AnGiangDataSet anGiangDataSet;
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
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private GPMController.XUC_NhanVien xuC_NhanVien1;

    }
}