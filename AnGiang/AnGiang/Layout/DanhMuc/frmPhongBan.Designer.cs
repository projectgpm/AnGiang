namespace AnGiang.Layout.DanhMuc
{
    partial class frmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.gridControlPhongBan = new DevExpress.XtraGrid.GridControl();
            this.dvPhongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anGiangDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.gridViewPhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPhongBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dvPhongBanTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.dvPhongBanTableAdapter();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlPhongBan
            // 
            this.gridControlPhongBan.DataSource = this.dvPhongBanBindingSource;
            this.gridControlPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPhongBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlPhongBan.Location = new System.Drawing.Point(0, 0);
            this.gridControlPhongBan.MainView = this.gridViewPhongBan;
            this.gridControlPhongBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlPhongBan.Name = "gridControlPhongBan";
            this.gridControlPhongBan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.beXoa});
            this.gridControlPhongBan.Size = new System.Drawing.Size(1063, 709);
            this.gridControlPhongBan.TabIndex = 0;
            this.gridControlPhongBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPhongBan});
            // 
            // dvPhongBanBindingSource
            // 
            this.dvPhongBanBindingSource.DataMember = "dvPhongBan";
            this.dvPhongBanBindingSource.DataSource = this.anGiangDataSetBindingSource;
            // 
            // anGiangDataSetBindingSource
            // 
            this.anGiangDataSetBindingSource.DataSource = this.anGiangDataSet;
            this.anGiangDataSetBindingSource.Position = 0;
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewPhongBan
            // 
            this.gridViewPhongBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDPhongBan,
            this.colMaPhongBan,
            this.colTenPhongBan,
            this.colGhiChu,
            this.colXoa,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colDonViID});
            this.gridViewPhongBan.GridControl = this.gridControlPhongBan;
            this.gridViewPhongBan.Name = "gridViewPhongBan";
            this.gridViewPhongBan.NewItemRowText = "Nhấn vào đây để thêm mới";
            this.gridViewPhongBan.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridViewPhongBan.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewPhongBan.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewPhongBan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewPhongBan.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewPhongBan.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewPhongBan.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewPhongBan.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewPhongBan_RowCellClick);
            this.gridViewPhongBan.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewPhongBan_ValidateRow);
            // 
            // colIDPhongBan
            // 
            this.colIDPhongBan.FieldName = "IDPhongBan";
            this.colIDPhongBan.Name = "colIDPhongBan";
            this.colIDPhongBan.OptionsColumn.AllowEdit = false;
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.Caption = "Mã phòng ban";
            this.colMaPhongBan.FieldName = "MaPhongBan";
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.OptionsColumn.AllowEdit = false;
            this.colMaPhongBan.Visible = true;
            this.colMaPhongBan.VisibleIndex = 0;
            this.colMaPhongBan.Width = 217;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.Caption = "Tên phòng ban";
            this.colTenPhongBan.FieldName = "TenPhongBan";
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.OptionsColumn.AllowEdit = false;
            this.colTenPhongBan.Visible = true;
            this.colTenPhongBan.VisibleIndex = 1;
            this.colTenPhongBan.Width = 637;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 2;
            this.colGhiChu.Width = 726;
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
            // colDonViID
            // 
            this.colDonViID.FieldName = "DonViID";
            this.colDonViID.Name = "colDonViID";
            this.colDonViID.OptionsColumn.AllowEdit = false;
            // 
            // dvPhongBanTableAdapter
            // 
            this.dvPhongBanTableAdapter.ClearBeforeFill = true;
            // 
            // colXoa
            // 
            this.colXoa.ColumnEdit = this.beXoa;
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 3;
            this.colXoa.Width = 50;
            // 
            // beXoa
            // 
            this.beXoa.AutoHeight = false;
            this.beXoa.ContextImage = ((System.Drawing.Image)(resources.GetObject("beXoa.ContextImage")));
            this.beXoa.Name = "beXoa";
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 709);
            this.Controls.Add(this.gridControlPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPhongBan";
            this.Text = "frmPhongBan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPhongBan;
        private System.Windows.Forms.BindingSource anGiangDataSetBindingSource;
        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource dvPhongBanBindingSource;
        private AnGiangDataSetTableAdapters.dvPhongBanTableAdapter dvPhongBanTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViID;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit beXoa;
    }
}