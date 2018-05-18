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
            this.gridViewChuyenMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.dvChuyenMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dvChuyenMonTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.dvChuyenMonTableAdapter();
            this.colIDChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChuyenMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChuyenMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvChuyenMonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlChuyenMon
            // 
            this.gridControlChuyenMon.DataSource = this.dvChuyenMonBindingSource;
            this.gridControlChuyenMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlChuyenMon.Location = new System.Drawing.Point(0, 0);
            this.gridControlChuyenMon.MainView = this.gridViewChuyenMon;
            this.gridControlChuyenMon.Name = "gridControlChuyenMon";
            this.gridControlChuyenMon.Size = new System.Drawing.Size(863, 441);
            this.gridControlChuyenMon.TabIndex = 0;
            this.gridControlChuyenMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewChuyenMon});
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
            this.gridViewChuyenMon.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dvChuyenMonBindingSource
            // 
            this.dvChuyenMonBindingSource.DataMember = "dvChuyenMon";
            this.dvChuyenMonBindingSource.DataSource = this.anGiangDataSet;
            // 
            // dvChuyenMonTableAdapter
            // 
            this.dvChuyenMonTableAdapter.ClearBeforeFill = true;
            // 
            // colIDChuyenMon
            // 
            this.colIDChuyenMon.FieldName = "IDChuyenMon";
            this.colIDChuyenMon.Name = "colIDChuyenMon";
            this.colIDChuyenMon.Visible = true;
            this.colIDChuyenMon.VisibleIndex = 0;
            // 
            // colMaChuyenMon
            // 
            this.colMaChuyenMon.FieldName = "MaChuyenMon";
            this.colMaChuyenMon.Name = "colMaChuyenMon";
            this.colMaChuyenMon.Visible = true;
            this.colMaChuyenMon.VisibleIndex = 1;
            // 
            // colTenChuyenMon
            // 
            this.colTenChuyenMon.FieldName = "TenChuyenMon";
            this.colTenChuyenMon.Name = "colTenChuyenMon";
            this.colTenChuyenMon.Visible = true;
            this.colTenChuyenMon.VisibleIndex = 2;
            // 
            // colNgayTao
            // 
            this.colNgayTao.FieldName = "NgayTao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.Visible = true;
            this.colNgayTao.VisibleIndex = 3;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 4;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 5;
            // 
            // colDonViID
            // 
            this.colDonViID.FieldName = "DonViID";
            this.colDonViID.Name = "colDonViID";
            this.colDonViID.Visible = true;
            this.colDonViID.VisibleIndex = 6;
            // 
            // frmChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 441);
            this.Controls.Add(this.gridControlChuyenMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChuyenMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChuyenMon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChuyenMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlChuyenMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChuyenMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvChuyenMonBindingSource)).EndInit();
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