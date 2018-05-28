namespace AnGiang.Layout.DanhMuc
{
    partial class frmChuyenMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenMon));
            this.gridControlChuyenMon = new DevExpress.XtraGrid.GridControl();
            this.dvChuyenMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.gridViewChuyenMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dvChuyenMonTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.dvChuyenMonTableAdapter();
            this.colXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.beXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChuyenMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvChuyenMonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChuyenMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlChuyenMon
            // 
            this.gridControlChuyenMon.DataSource = this.dvChuyenMonBindingSource;
            this.gridControlChuyenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChuyenMon.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlChuyenMon.Location = new System.Drawing.Point(0, 0);
            this.gridControlChuyenMon.MainView = this.gridViewChuyenMon;
            this.gridControlChuyenMon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlChuyenMon.Name = "gridControlChuyenMon";
            this.gridControlChuyenMon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.beXoa});
            this.gridControlChuyenMon.Size = new System.Drawing.Size(1007, 543);
            this.gridControlChuyenMon.TabIndex = 0;
            this.gridControlChuyenMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChuyenMon});
            // 
            // dvChuyenMonBindingSource
            // 
            this.dvChuyenMonBindingSource.DataMember = "dvChuyenMon";
            this.dvChuyenMonBindingSource.DataSource = this.anGiangDataSet;
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewChuyenMon
            // 
            this.gridViewChuyenMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDChuyenMon,
            this.colMaChuyenMon,
            this.colTenChuyenMon,
            this.colXoa,
            this.colDonViID});
            this.gridViewChuyenMon.GridControl = this.gridControlChuyenMon;
            this.gridViewChuyenMon.Name = "gridViewChuyenMon";
            this.gridViewChuyenMon.NewItemRowText = "Nhấn vào đây để thêm mới";
            this.gridViewChuyenMon.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridViewChuyenMon.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewChuyenMon.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewChuyenMon.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewChuyenMon.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewChuyenMon.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewChuyenMon.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colIDChuyenMon
            // 
            this.colIDChuyenMon.FieldName = "IDChuyenMon";
            this.colIDChuyenMon.Name = "colIDChuyenMon";
            this.colIDChuyenMon.OptionsColumn.AllowEdit = false;
            // 
            // colMaChuyenMon
            // 
            this.colMaChuyenMon.Caption = "Mã chuyên môn";
            this.colMaChuyenMon.FieldName = "MaChuyenMon";
            this.colMaChuyenMon.Name = "colMaChuyenMon";
            this.colMaChuyenMon.OptionsColumn.AllowEdit = false;
            this.colMaChuyenMon.Visible = true;
            this.colMaChuyenMon.VisibleIndex = 0;
            this.colMaChuyenMon.Width = 411;
            // 
            // colTenChuyenMon
            // 
            this.colTenChuyenMon.Caption = "Tên chuyên môn";
            this.colTenChuyenMon.FieldName = "TenChuyenMon";
            this.colTenChuyenMon.Name = "colTenChuyenMon";
            this.colTenChuyenMon.OptionsColumn.AllowEdit = false;
            this.colTenChuyenMon.Visible = true;
            this.colTenChuyenMon.VisibleIndex = 1;
            this.colTenChuyenMon.Width = 1178;
            // 
            // colDonViID
            // 
            this.colDonViID.Caption = "Đơn vị";
            this.colDonViID.FieldName = "DonViID";
            this.colDonViID.Name = "colDonViID";
            this.colDonViID.OptionsColumn.AllowEdit = false;
            // 
            // dvChuyenMonTableAdapter
            // 
            this.dvChuyenMonTableAdapter.ClearBeforeFill = true;
            // 
            // colXoa
            // 
            this.colXoa.Name = "colXoa";
            this.colXoa.Visible = true;
            this.colXoa.VisibleIndex = 2;
            this.colXoa.Width = 41;
            // 
            // beXoa
            // 
            this.beXoa.AutoHeight = false;
            this.beXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beXoa.ContextImage = ((System.Drawing.Image)(resources.GetObject("beXoa.ContextImage")));
            this.beXoa.Name = "beXoa";
            // 
            // frmChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 543);
            this.Controls.Add(this.gridControlChuyenMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChuyenMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenMon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChuyenMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChuyenMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvChuyenMonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChuyenMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beXoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlChuyenMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChuyenMon;
        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource dvChuyenMonBindingSource;
        private AnGiangDataSetTableAdapters.dvChuyenMonTableAdapter dvChuyenMonTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDChuyenMon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChuyenMon;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChuyenMon;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViID;
        private DevExpress.XtraGrid.Columns.GridColumn colXoa;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit beXoa;
    }
}