namespace QLCafe
{
    partial class frmChiTietBangGia
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFChiTietBangGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvChiTietBangGia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBangGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFBangGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIDHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colGiaCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaMoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoavaDaXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cF_ChiTietBangGiaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_ChiTietBangGiaTableAdapter();
            this.cF_BangGiaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_BangGiaTableAdapter();
            this.cF_HangHoaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_HangHoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFChiTietBangGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietBangGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBangGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFChiTietBangGiaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvChiTietBangGia;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoavaDaXoa,
            this.repositoryItemSpinEdit1,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(849, 470);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChiTietBangGia});
            // 
            // cFChiTietBangGiaBindingSource
            // 
            this.cFChiTietBangGiaBindingSource.DataMember = "CF_ChiTietBangGia";
            this.cFChiTietBangGiaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvChiTietBangGia
            // 
            this.gvChiTietBangGia.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvChiTietBangGia.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvChiTietBangGia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDBangGia,
            this.colIDHangHoa,
            this.colGiaCu,
            this.colGiaMoi,
            this.colDaXoa,
            this.colCongCu});
            this.gvChiTietBangGia.GridControl = this.gridControl1;
            this.gvChiTietBangGia.Name = "gvChiTietBangGia";
            this.gvChiTietBangGia.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvChiTietBangGia.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvChiTietBangGia.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvChiTietBangGia.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvChiTietBangGia.OptionsFind.AlwaysVisible = true;
            this.gvChiTietBangGia.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvChiTietBangGia.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            this.gvChiTietBangGia.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvDonViTinh_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIDBangGia
            // 
            this.colIDBangGia.Caption = "Bảng Giá";
            this.colIDBangGia.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIDBangGia.FieldName = "IDBangGia";
            this.colIDBangGia.Name = "colIDBangGia";
            this.colIDBangGia.OptionsColumn.ReadOnly = true;
            this.colIDBangGia.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colIDBangGia.Visible = true;
            this.colIDBangGia.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.cFBangGiaBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "TenBangGia";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // cFBangGiaBindingSource
            // 
            this.cFBangGiaBindingSource.DataMember = "CF_BangGia";
            this.cFBangGiaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colIDHangHoa
            // 
            this.colIDHangHoa.Caption = "Hàng Hóa";
            this.colIDHangHoa.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colIDHangHoa.FieldName = "IDHangHoa";
            this.colIDHangHoa.Name = "colIDHangHoa";
            this.colIDHangHoa.OptionsColumn.ReadOnly = true;
            this.colIDHangHoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colIDHangHoa.Visible = true;
            this.colIDHangHoa.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.cFHangHoaBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "TenHangHoa";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            // 
            // cFHangHoaBindingSource
            // 
            this.cFHangHoaBindingSource.DataMember = "CF_HangHoa";
            this.cFHangHoaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colGiaCu
            // 
            this.colGiaCu.Caption = "Giá Củ";
            this.colGiaCu.DisplayFormat.FormatString = "N0";
            this.colGiaCu.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaCu.FieldName = "GiaCu";
            this.colGiaCu.Name = "colGiaCu";
            this.colGiaCu.OptionsColumn.ReadOnly = true;
            this.colGiaCu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colGiaCu.Visible = true;
            this.colGiaCu.VisibleIndex = 2;
            // 
            // colGiaMoi
            // 
            this.colGiaMoi.Caption = "Giá Mới";
            this.colGiaMoi.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colGiaMoi.DisplayFormat.FormatString = "N0";
            this.colGiaMoi.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colGiaMoi.FieldName = "GiaMoi";
            this.colGiaMoi.Name = "colGiaMoi";
            this.colGiaMoi.Visible = true;
            this.colGiaMoi.VisibleIndex = 3;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colDaXoa
            // 
            this.colDaXoa.Caption = "Hiển Thị";
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsColumn.ReadOnly = true;
            this.colDaXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 4;
            // 
            // colCongCu
            // 
            this.colCongCu.Caption = "Công Cụ";
            this.colCongCu.ColumnEdit = this.btXoavaDaXoa;
            this.colCongCu.Name = "colCongCu";
            this.colCongCu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCongCu.Visible = true;
            this.colCongCu.VisibleIndex = 5;
            // 
            // btXoavaDaXoa
            // 
            this.btXoavaDaXoa.AutoHeight = false;
            this.btXoavaDaXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btXoavaDaXoa.Name = "btXoavaDaXoa";
            this.btXoavaDaXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoavaDaXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btXoavaDaXoa_ButtonClick);
            // 
            // cF_ChiTietBangGiaTableAdapter
            // 
            this.cF_ChiTietBangGiaTableAdapter.ClearBeforeFill = true;
            // 
            // cF_BangGiaTableAdapter
            // 
            this.cF_BangGiaTableAdapter.ClearBeforeFill = true;
            // 
            // cF_HangHoaTableAdapter
            // 
            this.cF_HangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // frmChiTietBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 470);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmChiTietBangGia";
            this.Text = "Chi Tiết Bảng Giá";
            this.Load += new System.EventHandler(this.fmChiTietBangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFChiTietBangGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChiTietBangGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBangGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChiTietBangGia;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoavaDaXoa;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFChiTietBangGiaBindingSource;
        private quanlycafeDataSetTableAdapters.CF_ChiTietBangGiaTableAdapter cF_ChiTietBangGiaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBangGia;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaCu;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaMoi;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colCongCu;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource cFBangGiaBindingSource;
        private quanlycafeDataSetTableAdapters.CF_BangGiaTableAdapter cF_BangGiaTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource cFHangHoaBindingSource;
        private quanlycafeDataSetTableAdapters.CF_HangHoaTableAdapter cF_HangHoaTableAdapter;
    }
}