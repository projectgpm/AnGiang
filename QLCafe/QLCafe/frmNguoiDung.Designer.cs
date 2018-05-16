namespace QLCafe
{
    partial class frmNguoiDung
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
            this.cFNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDangNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMatKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colIDNhomNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbChonNhomNguoiDung = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFNhomNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btActive = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cbChonBangGia = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbChonBangGia1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cF_NhomNguoiDungTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_NhomNguoiDungTableAdapter();
            this.cF_NguoiDungTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNhomNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNhomNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFNguoiDungBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvNguoiDung;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoa,
            this.cbChonBangGia,
            this.cbChonBangGia1,
            this.btActive,
            this.cbChonNhomNguoiDung,
            this.repositoryItemTextEdit1});
            this.gridControl1.Size = new System.Drawing.Size(651, 424);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNguoiDung});
            // 
            // cFNguoiDungBindingSource
            // 
            this.cFNguoiDungBindingSource.DataMember = "CF_NguoiDung";
            this.cFNguoiDungBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvNguoiDung
            // 
            this.gvNguoiDung.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvNguoiDung.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMaNhanVien,
            this.colTenNguoiDung,
            this.colTenDangNhap,
            this.colSDT,
            this.colMatKhau,
            this.colIDNhomNguoiDung,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colActive,
            this.colXoa});
            this.gvNguoiDung.GridControl = this.gridControl1;
            this.gvNguoiDung.Name = "gvNguoiDung";
            this.gvNguoiDung.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvNguoiDung.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvNguoiDung.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gvNguoiDung.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;
            this.gvNguoiDung.OptionsCustomization.CustomizationFormSearchBoxVisible = true;
            this.gvNguoiDung.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvNguoiDung.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gvNguoiDung.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gvNguoiDung.OptionsFind.AlwaysVisible = true;
            this.gvNguoiDung.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvNguoiDung.OptionsNavigation.AutoFocusNewRow = true;
            this.gvNguoiDung.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvNguoiDung.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvNguoiDung.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gvNguoiDung.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gvBan_RowCellClick);
            this.gvNguoiDung.EditFormShowing += new DevExpress.XtraGrid.Views.Grid.EditFormShowingEventHandler(this.gvBan_EditFormShowing);
            this.gvNguoiDung.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvBan_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã Nhân Viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            // 
            // colTenNguoiDung
            // 
            this.colTenNguoiDung.Caption = "Tên Người Dùng";
            this.colTenNguoiDung.FieldName = "TenNguoiDung";
            this.colTenNguoiDung.Name = "colTenNguoiDung";
            this.colTenNguoiDung.Visible = true;
            this.colTenNguoiDung.VisibleIndex = 1;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.Caption = "Tên Đăng Nhập";
            this.colTenDangNhap.FieldName = "TenDangNhap";
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Visible = true;
            this.colTenDangNhap.VisibleIndex = 2;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số Điện Thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            // 
            // colMatKhau
            // 
            this.colMatKhau.Caption = "Mật Khẩu";
            this.colMatKhau.ColumnEdit = this.repositoryItemTextEdit1;
            this.colMatKhau.FieldName = "MatKhau";
            this.colMatKhau.Name = "colMatKhau";
            this.colMatKhau.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.True;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // colIDNhomNguoiDung
            // 
            this.colIDNhomNguoiDung.Caption = "Nhóm Người Dùng";
            this.colIDNhomNguoiDung.ColumnEdit = this.cbChonNhomNguoiDung;
            this.colIDNhomNguoiDung.FieldName = "IDNhomNguoiDung";
            this.colIDNhomNguoiDung.Name = "colIDNhomNguoiDung";
            this.colIDNhomNguoiDung.Visible = true;
            this.colIDNhomNguoiDung.VisibleIndex = 4;
            // 
            // cbChonNhomNguoiDung
            // 
            this.cbChonNhomNguoiDung.AutoHeight = false;
            this.cbChonNhomNguoiDung.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonNhomNguoiDung.DataSource = this.cFNhomNguoiDungBindingSource;
            this.cbChonNhomNguoiDung.DisplayMember = "TenNhom";
            this.cbChonNhomNguoiDung.KeyMember = "ID";
            this.cbChonNhomNguoiDung.Name = "cbChonNhomNguoiDung";
            this.cbChonNhomNguoiDung.NullText = "";
            this.cbChonNhomNguoiDung.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.cbChonNhomNguoiDung.ShowFooter = false;
            this.cbChonNhomNguoiDung.ShowHeader = false;
            this.cbChonNhomNguoiDung.ShowLines = false;
            this.cbChonNhomNguoiDung.ValueMember = "ID";
            // 
            // cFNhomNguoiDungBindingSource
            // 
            this.cFNhomNguoiDungBindingSource.DataMember = "CF_NhomNguoiDung";
            this.cFNhomNguoiDungBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày Cập Nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 5;
            // 
            // colDaXoa
            // 
            this.colDaXoa.Caption = "Hiển Thị";
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 6;
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
            this.colActive.VisibleIndex = 7;
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
            this.colXoa.VisibleIndex = 8;
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
            // cF_NhomNguoiDungTableAdapter
            // 
            this.cF_NhomNguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // cF_NguoiDungTableAdapter
            // 
            this.cF_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 424);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNguoiDung";
            this.Text = "Người Dùng";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNhomNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNhomNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonBangGia1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNguoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonNhomNguoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbChonBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbChonBangGia1;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFNhomNguoiDungBindingSource;
        private quanlycafeDataSetTableAdapters.CF_NhomNguoiDungTableAdapter cF_NhomNguoiDungTableAdapter;
        private System.Windows.Forms.BindingSource cFNguoiDungBindingSource;
        private quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter cF_NguoiDungTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDangNhap;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colMatKhau;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNhomNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}