namespace QLCafe
{
    partial class frmBan
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbChonKhuVuc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFKhuVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbChonBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbChonBangGia1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cF_BanTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_BanTableAdapter();
            this.cF_KhuVucTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_KhuVucTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFKhuVucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFBanBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 51);
            this.gridControl1.MainView = this.gvBan;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.cbChonBangGia,
            this.cbChonBangGia1,
            this.btActive,
            this.cbChonKhuVuc});
            this.gridControl1.Size = new System.Drawing.Size(940, 354);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBan});
            // 
            // cFBanBindingSource
            // 
            this.cFBanBindingSource.DataMember = "CF_Ban";
            this.cFBanBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBan
            // 
            this.gvBan.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvBan.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenBan,
            this.colIDKhuVuc,
            this.colTrangThai,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colXoa,
            this.colActive});
            this.gvBan.GridControl = this.gridControl1;
            this.gvBan.Name = "gvBan";
            this.gvBan.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvBan.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvBan.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvBan.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvBan.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gvBan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvBan.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gvBan.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gvBan.OptionsFind.AlwaysVisible = true;
            this.gvBan.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvBan.OptionsNavigation.AutoFocusNewRow = true;
            this.gvBan.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvBan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvBan.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvBan.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvKhuVuc_RowCellClick);
            this.gvBan.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvKhuVuc_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colTenBan
            // 
            this.colTenBan.Caption = "Tên Bàn";
            this.colTenBan.FieldName = "TenBan";
            this.colTenBan.Name = "colTenBan";
            this.colTenBan.Visible = true;
            this.colTenBan.VisibleIndex = 0;
            this.colTenBan.Width = 87;
            // 
            // colIDKhuVuc
            // 
            this.colIDKhuVuc.Caption = "Khu Vực";
            this.colIDKhuVuc.ColumnEdit = this.cbChonKhuVuc;
            this.colIDKhuVuc.FieldName = "IDKhuVuc";
            this.colIDKhuVuc.Name = "colIDKhuVuc";
            this.colIDKhuVuc.Visible = true;
            this.colIDKhuVuc.VisibleIndex = 1;
            this.colIDKhuVuc.Width = 102;
            // 
            // cbChonKhuVuc
            // 
            this.cbChonKhuVuc.AutoHeight = false;
            this.cbChonKhuVuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonKhuVuc.DataSource = this.cFKhuVucBindingSource;
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
            // cFKhuVucBindingSource
            // 
            this.cFKhuVucBindingSource.DataMember = "CF_KhuVuc";
            this.cFKhuVucBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng Thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 2;
            this.colTrangThai.Width = 90;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày Cập Nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 3;
            this.colNgayCapNhat.Width = 123;
            // 
            // colDaXoa
            // 
            this.colDaXoa.Caption = "Hiển Thị";
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 4;
            this.colDaXoa.Width = 93;
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
            this.colXoa.VisibleIndex = 6;
            this.colXoa.Width = 61;
            // 
            // btXoa
            // 
            this.btXoa.AutoHeight = false;
            this.btXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Xóa", null, null, true)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 56;
            // 
            // btActive
            // 
            this.btActive.AutoHeight = false;
            this.btActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btActive.Name = "btActive";
            this.btActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cbChonBangGia
            // 
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
            // cF_BanTableAdapter
            // 
            this.cF_BanTableAdapter.ClearBeforeFill = true;
            // 
            // cF_KhuVucTableAdapter
            // 
            this.cF_KhuVucTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.23529F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(946, 408);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(940, 42);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Tải lại dữ liệu";
            this.simpleButton1.Click += new System.EventHandler(this.frmBan_Load);
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 408);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmBan";
            this.Text = "Bàn";
            this.Load += new System.EventHandler(this.frmBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFKhuVucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBan;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonBangGia1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbChonBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBan;
        private DevExpress.XtraGrid.Columns.GridColumn colIDKhuVuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFBanBindingSource;
        private quanlycafeDataSetTableAdapters.CF_BanTableAdapter cF_BanTableAdapter;
        private System.Windows.Forms.BindingSource cFKhuVucBindingSource;
        private quanlycafeDataSetTableAdapters.CF_KhuVucTableAdapter cF_KhuVucTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}