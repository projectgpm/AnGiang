namespace QLCafe
{
    partial class frmDonViTinh
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
            this.gvDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBtnXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoavaDaXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.cF_DonViTinhTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_DonViTinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFDonViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDonViTinh
            // 
            this.gvDonViTinh.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDonViTinh.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenDonViTinh,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colBtnXoa});
            this.gvDonViTinh.GridControl = this.gridControl1;
            this.gvDonViTinh.Name = "gvDonViTinh";
            this.gvDonViTinh.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvDonViTinh.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvDonViTinh.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDonViTinh.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvDonViTinh.OptionsFind.AlwaysVisible = true;
            this.gvDonViTinh.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvDonViTinh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvDonViTinh.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDonViTinh_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colID.OptionsFilter.AllowAutoFilter = false;
            this.colID.OptionsFilter.AllowFilter = false;
            this.colID.Width = 178;
            // 
            // colTenDonViTinh
            // 
            this.colTenDonViTinh.Caption = "Tên Đơn Vị Tính";
            this.colTenDonViTinh.FieldName = "TenDonViTinh";
            this.colTenDonViTinh.Name = "colTenDonViTinh";
            this.colTenDonViTinh.Visible = true;
            this.colTenDonViTinh.VisibleIndex = 0;
            this.colTenDonViTinh.Width = 251;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày Cập Nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 1;
            this.colNgayCapNhat.Width = 193;
            // 
            // colDaXoa
            // 
            this.colDaXoa.Caption = "Hiển Thị";
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 2;
            this.colDaXoa.Width = 90;
            // 
            // colBtnXoa
            // 
            this.colBtnXoa.ColumnEdit = this.btXoavaDaXoa;
            this.colBtnXoa.Name = "colBtnXoa";
            this.colBtnXoa.OptionsColumn.AllowMove = false;
            this.colBtnXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colBtnXoa.OptionsFilter.AllowAutoFilter = false;
            this.colBtnXoa.OptionsFilter.AllowFilter = false;
            this.colBtnXoa.Visible = true;
            this.colBtnXoa.VisibleIndex = 3;
            this.colBtnXoa.Width = 162;
            // 
            // btXoavaDaXoa
            // 
            this.btXoavaDaXoa.AutoHeight = false;
            this.btXoavaDaXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Xóa", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btXoavaDaXoa.Name = "btXoavaDaXoa";
            this.btXoavaDaXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoavaDaXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btXoaDonViTinh_ButtonClick);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFDonViTinhBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvDonViTinh;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoavaDaXoa});
            this.gridControl1.Size = new System.Drawing.Size(803, 462);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonViTinh});
            // 
            // cFDonViTinhBindingSource
            // 
            this.cFDonViTinhBindingSource.DataMember = "CF_DonViTinh";
            this.cFDonViTinhBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cF_DonViTinhTableAdapter
            // 
            this.cF_DonViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 462);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmDonViTinh";
            this.Text = "Đơn Vị Tính";
            this.Load += new System.EventHandler(this.frmDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFDonViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gvDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colBtnXoa;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoavaDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFDonViTinhBindingSource;
        private quanlycafeDataSetTableAdapters.CF_DonViTinhTableAdapter cF_DonViTinhTableAdapter;


    }
}