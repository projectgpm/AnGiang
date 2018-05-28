namespace AnGiang.Layout.DanhMuc
{
    partial class frmChucDanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucDanh));
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.nvChucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvChucDanhTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvChucDanhTableAdapter();
            this.tableAdapterManager = new AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager();
            this.nvChucDanhGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewChucDanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhMucCDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlsDanhMucCD = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.nvDanhMucCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenChucDanh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.nvDanhMucCDTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvDanhMucCDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsDanhMucCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nvChucDanhBindingSource
            // 
            this.nvChucDanhBindingSource.DataMember = "nvChucDanh";
            this.nvChucDanhBindingSource.DataSource = this.anGiangDataSet;
            // 
            // nvChucDanhTableAdapter
            // 
            this.nvChucDanhTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ccChamCongTableAdapter = null;
            this.tableAdapterManager.ccChiTietTableAdapter = null;
            this.tableAdapterManager.ccKyHieuTableAdapter = null;
            this.tableAdapterManager.ccXemChamCongTableAdapter = null;
            this.tableAdapterManager.dvChuyenMonTableAdapter = null;
            this.tableAdapterManager.dvDonViTableAdapter = null;
            this.tableAdapterManager.dvPhongBanTableAdapter = null;
            this.tableAdapterManager.lgBangLuongTableAdapter = null;
            this.tableAdapterManager.lgLuongTableAdapter = null;
            this.tableAdapterManager.lskLoaiSuKienTableAdapter = null;
            this.tableAdapterManager.lskSuKienTableAdapter = null;
            this.tableAdapterManager.nvChucDanhTableAdapter = this.nvChucDanhTableAdapter;
            this.tableAdapterManager.nvDanhMucCDTableAdapter = null;
            this.tableAdapterManager.nvNhanVienTableAdapter = null;
            this.tableAdapterManager.tlDinhMucTableAdapter = null;
            this.tableAdapterManager.TrinhDoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nvChucDanhGridControl
            // 
            this.nvChucDanhGridControl.DataSource = this.nvChucDanhBindingSource;
            this.nvChucDanhGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvChucDanhGridControl.Location = new System.Drawing.Point(0, 0);
            this.nvChucDanhGridControl.MainView = this.gridViewChucDanh;
            this.nvChucDanhGridControl.Name = "nvChucDanhGridControl";
            this.nvChucDanhGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlsDanhMucCD,
            this.beXoa});
            this.nvChucDanhGridControl.Size = new System.Drawing.Size(1080, 663);
            this.nvChucDanhGridControl.TabIndex = 1;
            this.nvChucDanhGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChucDanh});
            // 
            // gridViewChucDanh
            // 
            this.gridViewChucDanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDChucDanh,
            this.colMaChucDanh,
            this.colTenChucDanh,
            this.colGhiChu,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colDanhMucCDID,
            this.colXoa});
            this.gridViewChucDanh.GridControl = this.nvChucDanhGridControl;
            this.gridViewChucDanh.Name = "gridViewChucDanh";
            this.gridViewChucDanh.NewItemRowText = "Nhấn vào đây để thêm mới";
            this.gridViewChucDanh.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gridViewChucDanh.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewChucDanh.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewChucDanh.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewChucDanh.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewChucDanh.OptionsEditForm.EditFormColumnCount = 2;
            this.gridViewChucDanh.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewChucDanh.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewChucDanh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewChucDanh.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDanhMucCDID, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridViewChucDanh.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridViewChucDanh.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewChucDanh_RowCellClick);
            this.gridViewChucDanh.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gridView1_InitNewRow);
            this.gridViewChucDanh.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colIDChucDanh
            // 
            this.colIDChucDanh.FieldName = "IDChucDanh";
            this.colIDChucDanh.Name = "colIDChucDanh";
            this.colIDChucDanh.OptionsColumn.AllowEdit = false;
            // 
            // colMaChucDanh
            // 
            this.colMaChucDanh.Caption = "Mã chức danh";
            this.colMaChucDanh.FieldName = "MaChucDanh";
            this.colMaChucDanh.Name = "colMaChucDanh";
            this.colMaChucDanh.OptionsColumn.AllowEdit = false;
            this.colMaChucDanh.Visible = true;
            this.colMaChucDanh.VisibleIndex = 0;
            this.colMaChucDanh.Width = 325;
            // 
            // colTenChucDanh
            // 
            this.colTenChucDanh.Caption = "Tên chức danh";
            this.colTenChucDanh.FieldName = "TenChucDanh";
            this.colTenChucDanh.Name = "colTenChucDanh";
            this.colTenChucDanh.OptionsColumn.AllowEdit = false;
            this.colTenChucDanh.Visible = true;
            this.colTenChucDanh.VisibleIndex = 1;
            this.colTenChucDanh.Width = 341;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.OptionsEditForm.VisibleIndex = 9;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            this.colGhiChu.Width = 540;
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
            // colDanhMucCDID
            // 
            this.colDanhMucCDID.Caption = "Danh mục chức danh";
            this.colDanhMucCDID.ColumnEdit = this.rlsDanhMucCD;
            this.colDanhMucCDID.FieldName = "DanhMucCDID";
            this.colDanhMucCDID.Name = "colDanhMucCDID";
            this.colDanhMucCDID.OptionsColumn.AllowEdit = false;
            this.colDanhMucCDID.Visible = true;
            this.colDanhMucCDID.VisibleIndex = 2;
            this.colDanhMucCDID.Width = 382;
            // 
            // rlsDanhMucCD
            // 
            this.rlsDanhMucCD.AutoHeight = false;
            this.rlsDanhMucCD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlsDanhMucCD.DataSource = this.nvDanhMucCDBindingSource;
            this.rlsDanhMucCD.DisplayMember = "TenChucDanh";
            this.rlsDanhMucCD.Name = "rlsDanhMucCD";
            this.rlsDanhMucCD.ValueMember = "IDDanhMucCD";
            this.rlsDanhMucCD.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // nvDanhMucCDBindingSource
            // 
            this.nvDanhMucCDBindingSource.DataMember = "nvDanhMucCD";
            this.nvDanhMucCDBindingSource.DataSource = this.anGiangDataSet;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenChucDanh1});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colTenChucDanh1
            // 
            this.colTenChucDanh1.Caption = "Tên chức danh";
            this.colTenChucDanh1.FieldName = "TenChucDanh";
            this.colTenChucDanh1.Name = "colTenChucDanh1";
            this.colTenChucDanh1.Visible = true;
            this.colTenChucDanh1.VisibleIndex = 0;
            // 
            // colXoa
            // 
            this.colXoa.ColumnEdit = this.beXoa;
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 4;
            this.colXoa.Width = 42;
            // 
            // beXoa
            // 
            this.beXoa.AutoHeight = false;
            this.beXoa.ContextImage = ((System.Drawing.Image)(resources.GetObject("beXoa.ContextImage")));
            this.beXoa.Name = "beXoa";
            this.beXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // nvDanhMucCDTableAdapter
            // 
            this.nvDanhMucCDTableAdapter.ClearBeforeFill = true;
            // 
            // frmChucDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 663);
            this.Controls.Add(this.nvChucDanhGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChucDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucDanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChucDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsDanhMucCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource nvChucDanhBindingSource;
        private AnGiangDataSetTableAdapters.nvChucDanhTableAdapter nvChucDanhTableAdapter;
        private AnGiangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nvChucDanhGridControl;
        private DevExpress.XtraGrid.Columns.GridColumn colIDChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhMucCDID;
        private System.Windows.Forms.BindingSource nvDanhMucCDBindingSource;
        private AnGiangDataSetTableAdapters.nvDanhMucCDTableAdapter nvDanhMucCDTableAdapter;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewChucDanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit rlsDanhMucCD;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucDanh1;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit beXoa;
    }
}