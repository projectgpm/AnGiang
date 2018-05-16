namespace QLCafe
{
    partial class frmNhomHangHoa
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject17 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject18 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject19 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject20 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject21 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject22 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject23 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject24 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject25 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject26 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject27 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject28 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject29 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject30 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject31 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject32 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvNhomHangHoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoavaActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbChonBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbChonBangGia1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbChonKhuVuc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cF_NhomHangHoaTableAdapter1 = new QLCafe.quanlycafeDataSetTableAdapters.CF_NhomHangHoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonKhuVuc)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvNhomHangHoa;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.cbChonBangGia,
            this.cbChonBangGia1,
            this.btActive,
            this.cbChonKhuVuc,
            this.btXoavaActive});
            this.gridControl1.Size = new System.Drawing.Size(977, 442);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhomHangHoa});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "CF_NhomHangHoa";
            this.bindingSource1.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvNhomHangHoa
            // 
            this.gvNhomHangHoa.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvNhomHangHoa.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvNhomHangHoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenNhom,
            this.colGhiChu,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colCongCu});
            this.gvNhomHangHoa.GridControl = this.gridControl1;
            this.gvNhomHangHoa.Name = "gvNhomHangHoa";
            this.gvNhomHangHoa.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvNhomHangHoa.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvNhomHangHoa.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvNhomHangHoa.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gvNhomHangHoa.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvNhomHangHoa.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gvNhomHangHoa.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gvNhomHangHoa.OptionsFind.AlwaysVisible = true;
            this.gvNhomHangHoa.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvNhomHangHoa.OptionsNavigation.AutoFocusNewRow = true;
            this.gvNhomHangHoa.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvNhomHangHoa.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvNhomHangHoa.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvNhomHangHoa.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvBan_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colTenNhom
            // 
            this.colTenNhom.Caption = "Tên Nhóm";
            this.colTenNhom.FieldName = "TenNhom";
            this.colTenNhom.Name = "colTenNhom";
            this.colTenNhom.Visible = true;
            this.colTenNhom.VisibleIndex = 0;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi Chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 1;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày Cập Nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 2;
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
            // colCongCu
            // 
            this.colCongCu.ColumnEdit = this.btXoavaActive;
            this.colCongCu.Name = "colCongCu";
            this.colCongCu.OptionsColumn.AllowMove = false;
            this.colCongCu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCongCu.OptionsFilter.AllowAutoFilter = false;
            this.colCongCu.OptionsFilter.AllowFilter = false;
            this.colCongCu.Visible = true;
            this.colCongCu.VisibleIndex = 4;
            // 
            // btXoavaActive
            // 
            this.btXoavaActive.AutoHeight = false;
            this.btXoavaActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject17, serializableAppearanceObject18, serializableAppearanceObject19, serializableAppearanceObject20, "Xóa", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject21, serializableAppearanceObject22, serializableAppearanceObject23, serializableAppearanceObject24, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btXoavaActive.Name = "btXoavaActive";
            this.btXoavaActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoavaActive.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btXoavaActive_ButtonClick);
            // 
            // btXoa
            // 
            this.btXoa.AutoHeight = false;
            this.btXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject25, serializableAppearanceObject26, serializableAppearanceObject27, serializableAppearanceObject28, "Xóa", null, null, true)});
            this.btXoa.Name = "btXoa";
            this.btXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
            // btActive
            // 
            this.btActive.AutoHeight = false;
            this.btActive.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject29, serializableAppearanceObject30, serializableAppearanceObject31, serializableAppearanceObject32, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btActive.Name = "btActive";
            this.btActive.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // cbChonKhuVuc
            // 
            this.cbChonKhuVuc.AutoHeight = false;
            this.cbChonKhuVuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonKhuVuc.DisplayMember = "TenKhuVuc";
            this.cbChonKhuVuc.KeyMember = "ID";
            this.cbChonKhuVuc.Name = "cbChonKhuVuc";
            this.cbChonKhuVuc.ValueMember = "ID";
            // 
            // cF_NhomHangHoaTableAdapter1
            // 
            this.cF_NhomHangHoaTableAdapter1.ClearBeforeFill = true;
            // 
            // frmNhomHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 442);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNhomHangHoa";
            this.Text = "Nhóm Hàng Hóa";
            this.Load += new System.EventHandler(this.frmNhomHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhomHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonKhuVuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhomHangHoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonKhuVuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbChonBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonBangGia1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colCongCu;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoavaActive;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private quanlycafeDataSetTableAdapters.CF_NhomHangHoaTableAdapter cF_NhomHangHoaTableAdapter1;
    }
}