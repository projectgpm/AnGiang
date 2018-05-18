namespace AnGiang.Layout.DanhMuc
{
    partial class frmChucVu
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
            this.gridControlChucVu = new DevExpress.XtraGrid.GridControl();
            this.gridViewChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.nvChucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvChucVuTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvChucVuTableAdapter();
            this.colIDChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSoChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhuCapChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucDanhID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlChucVu
            // 
            this.gridControlChucVu.DataSource = this.nvChucVuBindingSource;
            this.gridControlChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChucVu.Location = new System.Drawing.Point(0, 0);
            this.gridControlChucVu.MainView = this.gridViewChucVu;
            this.gridControlChucVu.Name = "gridControlChucVu";
            this.gridControlChucVu.Size = new System.Drawing.Size(839, 476);
            this.gridControlChucVu.TabIndex = 0;
            this.gridControlChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChucVu});
            // 
            // gridViewChucVu
            // 
            this.gridViewChucVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDChucVu,
            this.colMaChucVu,
            this.colTenChucVu,
            this.colHeSoChucVu,
            this.colPhuCapChucVu,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colChucDanhID});
            this.gridViewChucVu.GridControl = this.gridControlChucVu;
            this.gridViewChucVu.Name = "gridViewChucVu";
            this.gridViewChucVu.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nvChucVuBindingSource
            // 
            this.nvChucVuBindingSource.DataMember = "nvChucVu";
            this.nvChucVuBindingSource.DataSource = this.anGiangDataSet;
            // 
            // nvChucVuTableAdapter
            // 
            this.nvChucVuTableAdapter.ClearBeforeFill = true;
            // 
            // colIDChucVu
            // 
            this.colIDChucVu.FieldName = "IDChucVu";
            this.colIDChucVu.Name = "colIDChucVu";
            this.colIDChucVu.Visible = true;
            this.colIDChucVu.VisibleIndex = 0;
            // 
            // colMaChucVu
            // 
            this.colMaChucVu.FieldName = "MaChucVu";
            this.colMaChucVu.Name = "colMaChucVu";
            this.colMaChucVu.Visible = true;
            this.colMaChucVu.VisibleIndex = 1;
            // 
            // colTenChucVu
            // 
            this.colTenChucVu.FieldName = "TenChucVu";
            this.colTenChucVu.Name = "colTenChucVu";
            this.colTenChucVu.Visible = true;
            this.colTenChucVu.VisibleIndex = 2;
            // 
            // colHeSoChucVu
            // 
            this.colHeSoChucVu.FieldName = "HeSoChucVu";
            this.colHeSoChucVu.Name = "colHeSoChucVu";
            this.colHeSoChucVu.Visible = true;
            this.colHeSoChucVu.VisibleIndex = 3;
            // 
            // colPhuCapChucVu
            // 
            this.colPhuCapChucVu.FieldName = "PhuCapChucVu";
            this.colPhuCapChucVu.Name = "colPhuCapChucVu";
            this.colPhuCapChucVu.Visible = true;
            this.colPhuCapChucVu.VisibleIndex = 4;
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
            // colChucDanhID
            // 
            this.colChucDanhID.FieldName = "ChucDanhID";
            this.colChucDanhID.Name = "colChucDanhID";
            this.colChucDanhID.Visible = true;
            this.colChucDanhID.VisibleIndex = 8;
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 476);
            this.Controls.Add(this.gridControlChucVu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChucVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChucVu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChucVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChucVu;
        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource nvChucVuBindingSource;
        private AnGiangDataSetTableAdapters.nvChucVuTableAdapter nvChucVuTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colIDChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSoChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colPhuCapChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colChucDanhID;
    }
}