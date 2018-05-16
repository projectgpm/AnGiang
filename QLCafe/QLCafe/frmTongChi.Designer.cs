namespace QLCafe
{
    partial class frmTongChi
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFTongChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvTongChi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TextNumber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colNgayChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Date = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoavaDaXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.cF_TongChiTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_TongChiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFTongChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFTongChiBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gvTongChi;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoavaDaXoa,
            this.TextNumber,
            this.Date});
            this.gridControl1.Size = new System.Drawing.Size(670, 439);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTongChi});
            // 
            // cFTongChiBindingSource
            // 
            this.cFTongChiBindingSource.DataMember = "CF_TongChi";
            this.cFTongChiBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvTongChi
            // 
            this.gvTongChi.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvTongChi.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gvTongChi.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gvTongChi.Appearance.DetailTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.DetailTip.Options.UseFont = true;
            this.gvTongChi.Appearance.Empty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.Empty.Options.UseFont = true;
            this.gvTongChi.Appearance.EvenRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.EvenRow.Options.UseFont = true;
            this.gvTongChi.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gvTongChi.Appearance.FilterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.FilterPanel.Options.UseFont = true;
            this.gvTongChi.Appearance.FixedLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.FixedLine.Options.UseFont = true;
            this.gvTongChi.Appearance.FocusedCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.FocusedCell.Options.UseFont = true;
            this.gvTongChi.Appearance.FocusedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.FocusedRow.Options.UseFont = true;
            this.gvTongChi.Appearance.FooterPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.FooterPanel.Options.UseFont = true;
            this.gvTongChi.Appearance.GroupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.GroupButton.Options.UseFont = true;
            this.gvTongChi.Appearance.GroupFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.GroupFooter.Options.UseFont = true;
            this.gvTongChi.Appearance.GroupPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.GroupPanel.Options.UseFont = true;
            this.gvTongChi.Appearance.GroupRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.GroupRow.Options.UseFont = true;
            this.gvTongChi.Appearance.HeaderPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTongChi.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvTongChi.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvTongChi.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gvTongChi.Appearance.HorzLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.HorzLine.Options.UseFont = true;
            this.gvTongChi.Appearance.OddRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.OddRow.Options.UseFont = true;
            this.gvTongChi.Appearance.Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.Preview.Options.UseFont = true;
            this.gvTongChi.Appearance.Row.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.Row.Options.UseFont = true;
            this.gvTongChi.Appearance.RowSeparator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.RowSeparator.Options.UseFont = true;
            this.gvTongChi.Appearance.SelectedRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.SelectedRow.Options.UseFont = true;
            this.gvTongChi.Appearance.TopNewRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.TopNewRow.Options.UseFont = true;
            this.gvTongChi.Appearance.VertLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.VertLine.Options.UseFont = true;
            this.gvTongChi.Appearance.ViewCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gvTongChi.Appearance.ViewCaption.Options.UseFont = true;
            this.gvTongChi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colLoaiChi,
            this.colTienChi,
            this.colNgayChi,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colCongCu});
            this.gvTongChi.GridControl = this.gridControl1;
            this.gvTongChi.Name = "gvTongChi";
            this.gvTongChi.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvTongChi.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvTongChi.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvTongChi.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvTongChi.OptionsFind.AlwaysVisible = true;
            this.gvTongChi.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            this.gvTongChi.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvTongChi.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gvBangGia_ValidateRow);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colLoaiChi
            // 
            this.colLoaiChi.FieldName = "LoaiChi";
            this.colLoaiChi.Name = "colLoaiChi";
            this.colLoaiChi.Visible = true;
            this.colLoaiChi.VisibleIndex = 0;
            // 
            // colTienChi
            // 
            this.colTienChi.ColumnEdit = this.TextNumber;
            this.colTienChi.FieldName = "TienChi";
            this.colTienChi.Name = "colTienChi";
            this.colTienChi.Visible = true;
            this.colTienChi.VisibleIndex = 1;
            // 
            // TextNumber
            // 
            this.TextNumber.AutoHeight = false;
            this.TextNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TextNumber.Mask.BeepOnError = true;
            this.TextNumber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TextNumber.Name = "TextNumber";
            // 
            // colNgayChi
            // 
            this.colNgayChi.ColumnEdit = this.Date;
            this.colNgayChi.FieldName = "NgayChi";
            this.colNgayChi.Name = "colNgayChi";
            this.colNgayChi.Visible = true;
            this.colNgayChi.VisibleIndex = 2;
            // 
            // Date
            // 
            this.Date.AutoHeight = false;
            this.Date.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Date.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Date.Name = "Date";
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.OptionsEditForm.VisibleIndex = -1;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 3;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 4;
            // 
            // colCongCu
            // 
            this.colCongCu.Caption = "Công Cụ";
            this.colCongCu.ColumnEdit = this.btXoavaDaXoa;
            this.colCongCu.Name = "colCongCu";
            this.colCongCu.OptionsColumn.AllowMove = false;
            this.colCongCu.OptionsEditForm.StartNewRow = true;
            this.colCongCu.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colCongCu.OptionsFilter.AllowAutoFilter = false;
            this.colCongCu.OptionsFilter.AllowFilter = false;
            this.colCongCu.Visible = true;
            this.colCongCu.VisibleIndex = 5;
            // 
            // btXoavaDaXoa
            // 
            this.btXoavaDaXoa.AutoHeight = false;
            this.btXoavaDaXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "Xóa", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btXoavaDaXoa.Name = "btXoavaDaXoa";
            this.btXoavaDaXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btXoavaDaXoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btXoavaDaXoa_ButtonClick);
            // 
            // cF_TongChiTableAdapter
            // 
            this.cF_TongChiTableAdapter.ClearBeforeFill = true;
            // 
            // frmTongChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 439);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmTongChi";
            this.Text = "frmTongChi";
            this.Load += new System.EventHandler(this.frmTongChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFTongChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTongChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTongChi;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoavaDaXoa;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFTongChiBindingSource;
        private quanlycafeDataSetTableAdapters.CF_TongChiTableAdapter cF_TongChiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiChi;
        private DevExpress.XtraGrid.Columns.GridColumn colTienChi;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TextNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayChi;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit Date;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colCongCu;
    }
}