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
            this.gridControlChuyenMon = new DevExpress.XtraGrid.GridControl();
            this.dvChuyenMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.gridViewChuyenMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dvChuyenMonTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.dvChuyenMonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChuyenMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvChuyenMonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChuyenMon)).BeginInit();
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
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa,
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
            this.colMaChuyenMon.Width = 268;
            // 
            // colTenChuyenMon
            // 
            this.colTenChuyenMon.Caption = "Tên chuyên môn";
            this.colTenChuyenMon.FieldName = "TenChuyenMon";
            this.colTenChuyenMon.Name = "colTenChuyenMon";
            this.colTenChuyenMon.OptionsColumn.AllowEdit = false;
            this.colTenChuyenMon.Visible = true;
            this.colTenChuyenMon.VisibleIndex = 1;
            this.colTenChuyenMon.Width = 719;
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
            this.colDonViID.Caption = "Đơn vị";
            this.colDonViID.FieldName = "DonViID";
            this.colDonViID.Name = "colDonViID";
            this.colDonViID.OptionsColumn.AllowEdit = false;
            // 
            // dvChuyenMonTableAdapter
            // 
            this.dvChuyenMonTableAdapter.ClearBeforeFill = true;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViID;
    }
}