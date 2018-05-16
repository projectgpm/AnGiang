namespace QLCafe
{
    partial class frmBangGia
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvBangGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoavaDaXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cF_BangGiaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_BangGiaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvBangGia;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoavaDaXoa});
            this.gridControl1.Size = new System.Drawing.Size(712, 449);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvBangGia});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "CF_BangGia";
            this.bindingSource1.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvBangGia
            // 
            this.gvBangGia.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvBangGia.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvBangGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTenBangGia,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colCongCu});
            this.gvBangGia.GridControl = this.gridControl1;
            this.gvBangGia.Name = "gvBangGia";
            this.gvBangGia.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvBangGia.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvBangGia.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvBangGia.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvBangGia.OptionsFind.AlwaysVisible = true;
            this.gvBangGia.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvBangGia.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvBangGia.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvBangGia_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colID.Width = 69;
            // 
            // colTenBangGia
            // 
            this.colTenBangGia.Caption = "Tên Bảng Giá";
            this.colTenBangGia.FieldName = "TenBangGia";
            this.colTenBangGia.Name = "colTenBangGia";
            this.colTenBangGia.Visible = true;
            this.colTenBangGia.VisibleIndex = 0;
            this.colTenBangGia.Width = 155;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày Cập Nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 1;
            this.colNgayCapNhat.Width = 155;
            // 
            // colDaXoa
            // 
            this.colDaXoa.Caption = "Đã Xóa";
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 2;
            this.colDaXoa.Width = 188;
            // 
            // colCongCu
            // 
            this.colCongCu.ColumnEdit = this.btXoavaDaXoa;
            this.colCongCu.Name = "colCongCu";
            this.colCongCu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCongCu.OptionsFilter.AllowAutoFilter = false;
            this.colCongCu.OptionsFilter.AllowFilter = false;
            this.colCongCu.Visible = true;
            this.colCongCu.VisibleIndex = 3;
            this.colCongCu.Width = 127;
            // 
            // btXoavaDaXoa
            // 
            this.btXoavaDaXoa.AutoHeight = false;
            this.btXoavaDaXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Xóa", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Hiển Thị", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Hủy/Kích hoạt dữ liệu", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "Xem chi tiết giá", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Zoom100", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Xem chi tiết giá", null, null, true)});
            this.btXoavaDaXoa.Name = "btXoavaDaXoa";
            this.btXoavaDaXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoavaDaXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btXoavaDaXoa_ButtonClick);
            // 
            // cF_BangGiaTableAdapter
            // 
            this.cF_BangGiaTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 449);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmBangGia";
            this.Text = "frmBangGia";
            this.Load += new System.EventHandler(this.frmBangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoavaDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTenBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colCongCu;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private quanlycafeDataSetTableAdapters.CF_BangGiaTableAdapter cF_BangGiaTableAdapter;
    }
}