namespace QLCafe
{
    partial class frmHangHoa
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbChonDonViTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIDNhomHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbChonNhomHang = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFNhomHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbChonBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbChonBangGia1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cbChonKhuVuc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cF_DonViTinhTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_DonViTinhTableAdapter();
            this.cF_NhomHangHoaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_NhomHangHoaTableAdapter();
            this.cF_HangHoaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_HangHoaTableAdapter();
            this.quanlycafeDataSet1 = new QLCafe.quanlycafeDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFDonViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNhomHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNhomHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFHangHoaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 49);
            this.gridControl1.MainView = this.gvHangHoa;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.cbChonBangGia,
            this.cbChonBangGia1,
            this.btActive,
            this.cbChonKhuVuc,
            this.cbChonDonViTinh,
            this.cbChonNhomHang});
            this.gridControl1.Size = new System.Drawing.Size(1005, 456);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvHangHoa});
            // 
            // cFHangHoaBindingSource
            // 
            this.cFHangHoaBindingSource.DataMember = "CF_HangHoa";
            this.cFHangHoaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvHangHoa
            // 
            this.gvHangHoa.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvHangHoa.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvHangHoa.Appearance.ViewCaption.Options.UseFont = true;
            this.gvHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMaHangHoa,
            this.colTenHangHoa,
            this.colGiaBan,
            this.colIDDonViTinh,
            this.colIDNhomHang,
            this.colDaXoa,
            this.colNgayCapNhat,
            this.colGhiChu,
            this.colActive,
            this.colXoa});
            this.gvHangHoa.GridControl = this.gridControl1;
            this.gvHangHoa.Name = "gvHangHoa";
            this.gvHangHoa.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvHangHoa.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvHangHoa.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvHangHoa.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvHangHoa.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gvHangHoa.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvHangHoa.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gvHangHoa.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gvHangHoa.OptionsFind.AlwaysVisible = true;
            this.gvHangHoa.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvHangHoa.OptionsNavigation.AutoFocusNewRow = true;
            this.gvHangHoa.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvHangHoa.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvHangHoa.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvHangHoa.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvBan_RowCellClick);
            this.gvHangHoa.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gvHangHoa_InitNewRow);
            this.gvHangHoa.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvBan_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colMaHangHoa
            // 
            this.colMaHangHoa.Caption = "Mã Hàng Hóa";
            this.colMaHangHoa.FieldName = "MaHangHoa";
            this.colMaHangHoa.Name = "colMaHangHoa";
            this.colMaHangHoa.Visible = true;
            this.colMaHangHoa.VisibleIndex = 0;
            // 
            // colTenHangHoa
            // 
            this.colTenHangHoa.Caption = "Tên Hàng Hóa";
            this.colTenHangHoa.FieldName = "TenHangHoa";
            this.colTenHangHoa.Name = "colTenHangHoa";
            this.colTenHangHoa.Visible = true;
            this.colTenHangHoa.VisibleIndex = 1;
            // 
            // colGiaBan
            // 
            this.colGiaBan.Caption = "Giá Bán";
            this.colGiaBan.FieldName = "GiaBan";
            this.colGiaBan.Name = "colGiaBan";
            this.colGiaBan.Visible = true;
            this.colGiaBan.VisibleIndex = 2;
            // 
            // colIDDonViTinh
            // 
            this.colIDDonViTinh.Caption = "Đơn Vị Tính";
            this.colIDDonViTinh.ColumnEdit = this.cbChonDonViTinh;
            this.colIDDonViTinh.FieldName = "IDDonViTinh";
            this.colIDDonViTinh.Name = "colIDDonViTinh";
            this.colIDDonViTinh.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // cbChonDonViTinh
            // 
            this.cbChonDonViTinh.AutoHeight = false;
            this.cbChonDonViTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonDonViTinh.DataSource = this.cFDonViTinhBindingSource;
            this.cbChonDonViTinh.DisplayMember = "TenDonViTinh";
            this.cbChonDonViTinh.KeyMember = "ID";
            this.cbChonDonViTinh.Name = "cbChonDonViTinh";
            this.cbChonDonViTinh.NullText = "";
            this.cbChonDonViTinh.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cbChonDonViTinh.ShowFooter = false;
            this.cbChonDonViTinh.ShowHeader = false;
            this.cbChonDonViTinh.ShowLines = false;
            this.cbChonDonViTinh.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbChonDonViTinh.ValueMember = "ID";
            // 
            // cFDonViTinhBindingSource
            // 
            this.cFDonViTinhBindingSource.DataMember = "CF_DonViTinh";
            this.cFDonViTinhBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colIDNhomHang
            // 
            this.colIDNhomHang.Caption = "Nhóm Hàng";
            this.colIDNhomHang.ColumnEdit = this.cbChonNhomHang;
            this.colIDNhomHang.FieldName = "IDNhomHang";
            this.colIDNhomHang.Name = "colIDNhomHang";
            this.colIDNhomHang.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // cbChonNhomHang
            // 
            this.cbChonNhomHang.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonNhomHang.DataSource = this.cFNhomHangHoaBindingSource;
            this.cbChonNhomHang.DisplayMember = "TenNhom";
            this.cbChonNhomHang.KeyMember = "ID";
            this.cbChonNhomHang.Name = "cbChonNhomHang";
            this.cbChonNhomHang.NullText = "";
            this.cbChonNhomHang.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cbChonNhomHang.ShowFooter = false;
            this.cbChonNhomHang.ShowHeader = false;
            this.cbChonNhomHang.ShowLines = false;
            this.cbChonNhomHang.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbChonNhomHang.ValueMember = "ID";
            // 
            // cFNhomHangHoaBindingSource
            // 
            this.cFNhomHangHoaBindingSource.DataMember = "CF_NhomHangHoa";
            this.cFNhomHangHoaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colDaXoa
            // 
            this.colDaXoa.Caption = "Hiển Thị";
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 3;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày Cập Nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 4;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 5;
            // 
            // colActive
            // 
            this.colActive.ColumnEdit = this.btActive;
            this.colActive.Name = "colActive";
            this.colActive.OptionsColumn.AllowMove = false;
            this.colActive.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colActive.OptionsFilter.AllowAutoFilter = false;
            this.colActive.OptionsFilter.AllowFilter = false;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 6;
            // 
            // btActive
            // 
            this.btActive.AutoHeight = false;
            this.btActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btActive.Name = "btActive";
            this.btActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // colXoa
            // 
            this.colXoa.ColumnEdit = this.btXoa;
            this.colXoa.Name = "colXoa";
            this.colXoa.OptionsColumn.AllowMove = false;
            this.colXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colXoa.OptionsFilter.AllowAutoFilter = false;
            this.colXoa.OptionsFilter.AllowFilter = false;
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 7;
            // 
            // btXoa
            // 
            this.btXoa.AutoHeight = false;
            this.btXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Xóa", null, null, true)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cbChonBangGia
            // 
            this.cbChonBangGia.AutoHeight = false;
            this.cbChonBangGia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonBangGia.Name = "cbChonBangGia";
            // 
            // cbChonBangGia1
            // 
            this.cbChonBangGia1.AutoHeight = false;
            this.cbChonBangGia1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonBangGia1.DisplayMember = "TenBangGia";
            this.cbChonBangGia1.KeyMember = "ID";
            this.cbChonBangGia1.Name = "cbChonBangGia1";
            this.cbChonBangGia1.NullText = "";
            this.cbChonBangGia1.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cbChonBangGia1.ShowFooter = false;
            this.cbChonBangGia1.ShowHeader = false;
            this.cbChonBangGia1.ShowLines = false;
            this.cbChonBangGia1.ValueMember = "ID";
            // 
            // cbChonKhuVuc
            // 
            this.cbChonKhuVuc.AutoHeight = false;
            this.cbChonKhuVuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonKhuVuc.DisplayMember = "TenKhuVuc";
            this.cbChonKhuVuc.KeyMember = "ID";
            this.cbChonKhuVuc.Name = "cbChonKhuVuc";
            this.cbChonKhuVuc.NullText = "";
            this.cbChonKhuVuc.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cbChonKhuVuc.ShowFooter = false;
            this.cbChonKhuVuc.ShowHeader = false;
            this.cbChonKhuVuc.ShowLines = false;
            this.cbChonKhuVuc.ValueMember = "ID";
            // 
            // cF_DonViTinhTableAdapter
            // 
            this.cF_DonViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // cF_NhomHangHoaTableAdapter
            // 
            this.cF_NhomHangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // cF_HangHoaTableAdapter
            // 
            this.cF_HangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // quanlycafeDataSet1
            // 
            this.quanlycafeDataSet1.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(1005, 40);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Tải lại dữ liệu";
            this.simpleButton1.Click += new System.EventHandler(this.frmHangHoa_Load);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.251968F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.74803F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1011, 508);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmHangHoa";
            this.Text = "Hàng Hóa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFDonViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNhomHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNhomHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonKhuVuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbChonBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonBangGia1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaBan;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonDonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonNhomHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHangHoa;
        public DevExpress.XtraGrid.Views.Grid.GridView gvHangHoa;
        public quanlycafeDataSet quanlycafeDataSet;
        public System.Windows.Forms.BindingSource cFDonViTinhBindingSource;
        public quanlycafeDataSetTableAdapters.CF_DonViTinhTableAdapter cF_DonViTinhTableAdapter;
        public System.Windows.Forms.BindingSource cFNhomHangHoaBindingSource;
        public quanlycafeDataSetTableAdapters.CF_NhomHangHoaTableAdapter cF_NhomHangHoaTableAdapter;
        public quanlycafeDataSetTableAdapters.CF_HangHoaTableAdapter cF_HangHoaTableAdapter;
        private System.Windows.Forms.BindingSource cFHangHoaBindingSource;
        private quanlycafeDataSet quanlycafeDataSet1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}