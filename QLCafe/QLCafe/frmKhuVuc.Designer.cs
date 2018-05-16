namespace QLCafe
{
    partial class frmKhuVuc
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
            this.cFKhuVucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvKhuVuc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKyHieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaKhuVuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbChonBangGia1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFBangGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbChonBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cF_KhuVucTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_KhuVucTableAdapter();
            this.cF_BangGiaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_BangGiaTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFKhuVucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBangGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFKhuVucBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 54);
            this.gridControl1.MainView = this.gvKhuVuc;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.cbChonBangGia,
            this.cbChonBangGia1,
            this.btActive});
            this.gridControl1.Size = new System.Drawing.Size(812, 410);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKhuVuc});
            // 
            // cFKhuVucBindingSource
            // 
            this.cFKhuVucBindingSource.DataMember = "CF_KhuVuc";
            this.cFKhuVucBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvKhuVuc
            // 
            this.gvKhuVuc.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvKhuVuc.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvKhuVuc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMaKhuVuc,
            this.colKyHieu,
            this.colTenKhuVuc,
            this.colGiaKhuVuc,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colGhiChu,
            this.colIDBangGia,
            this.colXoa,
            this.colActive});
            this.gvKhuVuc.GridControl = this.gridControl1;
            this.gvKhuVuc.Name = "gvKhuVuc";
            this.gvKhuVuc.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvKhuVuc.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvKhuVuc.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvKhuVuc.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvKhuVuc.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gvKhuVuc.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvKhuVuc.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gvKhuVuc.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gvKhuVuc.OptionsFind.AlwaysVisible = true;
            this.gvKhuVuc.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvKhuVuc.OptionsNavigation.AutoFocusNewRow = true;
            this.gvKhuVuc.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvKhuVuc.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvKhuVuc.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvKhuVuc.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvKhuVuc_RowCellClick);
            this.gvKhuVuc.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvKhuVuc_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colMaKhuVuc
            // 
            this.colMaKhuVuc.Caption = "Mã Khu Vực";
            this.colMaKhuVuc.FieldName = "MaKhuVuc";
            this.colMaKhuVuc.Name = "colMaKhuVuc";
            this.colMaKhuVuc.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colMaKhuVuc.Width = 103;
            // 
            // colKyHieu
            // 
            this.colKyHieu.Caption = "Ký Hiệu";
            this.colKyHieu.FieldName = "KyHieu";
            this.colKyHieu.Name = "colKyHieu";
            this.colKyHieu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            this.colKyHieu.Width = 72;
            // 
            // colTenKhuVuc
            // 
            this.colTenKhuVuc.Caption = "Tên Khu Vực";
            this.colTenKhuVuc.FieldName = "TenKhuVuc";
            this.colTenKhuVuc.Name = "colTenKhuVuc";
            this.colTenKhuVuc.Visible = true;
            this.colTenKhuVuc.VisibleIndex = 0;
            this.colTenKhuVuc.Width = 208;
            // 
            // colGiaKhuVuc
            // 
            this.colGiaKhuVuc.Caption = "Giá Khu Vực";
            this.colGiaKhuVuc.FieldName = "GiaKhuVuc";
            this.colGiaKhuVuc.Name = "colGiaKhuVuc";
            this.colGiaKhuVuc.Width = 134;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày Cập Nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 4;
            this.colNgayCapNhat.Width = 128;
            // 
            // colDaXoa
            // 
            this.colDaXoa.Caption = "Hiển Thị";
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 3;
            this.colDaXoa.Width = 65;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 122;
            // 
            // colIDBangGia
            // 
            this.colIDBangGia.Caption = "Bảng Giá";
            this.colIDBangGia.ColumnEdit = this.cbChonBangGia1;
            this.colIDBangGia.FieldName = "IDBangGia";
            this.colIDBangGia.Name = "colIDBangGia";
            this.colIDBangGia.OptionsColumn.FixedWidth = true;
            this.colIDBangGia.OptionsEditForm.Caption = "Bang Gia:";
            this.colIDBangGia.Visible = true;
            this.colIDBangGia.VisibleIndex = 1;
            this.colIDBangGia.Width = 113;
            // 
            // cbChonBangGia1
            // 
            this.cbChonBangGia1.AutoHeight = false;
            this.cbChonBangGia1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonBangGia1.DataSource = this.cFBangGiaBindingSource;
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
            // cFBangGiaBindingSource
            // 
            this.cFBangGiaBindingSource.DataMember = "CF_BangGia";
            this.cFBangGiaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colXoa
            // 
            this.colXoa.ColumnEdit = this.btXoa;
            this.colXoa.Name = "colXoa";
            this.colXoa.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colXoa.OptionsColumn.AllowMove = false;
            this.colXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colXoa.OptionsFilter.AllowAutoFilter = false;
            this.colXoa.OptionsFilter.AllowFilter = false;
            this.colXoa.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 6;
            this.colXoa.Width = 81;
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
            this.colActive.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.colActive.OptionsColumn.AllowMove = false;
            this.colActive.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colActive.OptionsFilter.AllowAutoFilter = false;
            this.colActive.OptionsFilter.AllowFilter = false;
            this.colActive.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colActive.Visible = true;
            this.colActive.VisibleIndex = 5;
            this.colActive.Width = 59;
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
            // cF_KhuVucTableAdapter
            // 
            this.cF_KhuVucTableAdapter.ClearBeforeFill = true;
            // 
            // cF_BangGiaTableAdapter
            // 
            this.cF_BangGiaTableAdapter.ClearBeforeFill = true;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.1349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.8651F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(818, 467);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(812, 45);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Tải lại dữ liệu";
            this.simpleButton1.Click += new System.EventHandler(this.frmKhuVuc_Load);
            // 
            // frmKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmKhuVuc";
            this.Text = "Khu Vực";
            this.Load += new System.EventHandler(this.frmKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFKhuVucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBangGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colKyHieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaKhuVuc;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonBangGia1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbChonBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btActive;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFKhuVucBindingSource;
        private quanlycafeDataSetTableAdapters.CF_KhuVucTableAdapter cF_KhuVucTableAdapter;
        private System.Windows.Forms.BindingSource cFBangGiaBindingSource;
        private quanlycafeDataSetTableAdapters.CF_BangGiaTableAdapter cF_BangGiaTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}