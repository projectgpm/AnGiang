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
            this.gridControlChucDanh = new DevExpress.XtraGrid.GridControl();
            this.gridViewChucDanh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.nvChucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvChucDanhTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvChucDanhTableAdapter();
            this.colIDChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSoChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongBanID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucDanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlChucDanh
            // 
            this.gridControlChucDanh.DataSource = this.nvChucDanhBindingSource;
            this.gridControlChucDanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChucDanh.Location = new System.Drawing.Point(0, 0);
            this.gridControlChucDanh.MainView = this.gridViewChucDanh;
            this.gridControlChucDanh.Name = "gridControlChucDanh";
            this.gridControlChucDanh.Size = new System.Drawing.Size(926, 539);
            this.gridControlChucDanh.TabIndex = 0;
            this.gridControlChucDanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChucDanh});
            // 
            // gridViewChucDanh
            // 
            this.gridViewChucDanh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDChucDanh,
            this.colMaChucDanh,
            this.colTenChucDanh,
            this.colHeSoChucDanh,
            this.colGhiChu,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colPhongBanID});
            this.gridViewChucDanh.GridControl = this.gridControlChucDanh;
            this.gridViewChucDanh.Name = "gridViewChucDanh";
            this.gridViewChucDanh.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            // colIDChucDanh
            // 
            this.colIDChucDanh.FieldName = "IDChucDanh";
            this.colIDChucDanh.Name = "colIDChucDanh";
            this.colIDChucDanh.Visible = true;
            this.colIDChucDanh.VisibleIndex = 0;
            // 
            // colMaChucDanh
            // 
            this.colMaChucDanh.FieldName = "MaChucDanh";
            this.colMaChucDanh.Name = "colMaChucDanh";
            this.colMaChucDanh.Visible = true;
            this.colMaChucDanh.VisibleIndex = 1;
            // 
            // colTenChucDanh
            // 
            this.colTenChucDanh.FieldName = "TenChucDanh";
            this.colTenChucDanh.Name = "colTenChucDanh";
            this.colTenChucDanh.Visible = true;
            this.colTenChucDanh.VisibleIndex = 2;
            // 
            // colHeSoChucDanh
            // 
            this.colHeSoChucDanh.FieldName = "HeSoChucDanh";
            this.colHeSoChucDanh.Name = "colHeSoChucDanh";
            this.colHeSoChucDanh.Visible = true;
            this.colHeSoChucDanh.VisibleIndex = 3;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 4;
            // 
            // colNgayTao
            // 
            this.colNgayTao.FieldName = "NgayTao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.Visible = true;
            this.colNgayTao.VisibleIndex = 5;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 6;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 7;
            // 
            // colPhongBanID
            // 
            this.colPhongBanID.FieldName = "PhongBanID";
            this.colPhongBanID.Name = "colPhongBanID";
            this.colPhongBanID.Visible = true;
            this.colPhongBanID.VisibleIndex = 8;
            // 
            // frmChucDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 539);
            this.Controls.Add(this.gridControlChucDanh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChucDanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucDanh";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChucDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucDanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlChucDanh;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChucDanh;
        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource nvChucDanhBindingSource;
        private AnGiangDataSetTableAdapters.nvChucDanhTableAdapter nvChucDanhTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSoChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBanID;
    }
}