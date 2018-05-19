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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhongBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlPhongBan
            // 
            this.gridControlPhongBan.DataSource = this.dvPhongBanBindingSource;
            this.gridControlPhongBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPhongBan.Location = new System.Drawing.Point(0, 0);
            this.gridControlPhongBan.MainView = this.gridViewPhongBan;
            this.gridControlPhongBan.Name = "gridControlPhongBan";
            this.gridControlPhongBan.Size = new System.Drawing.Size(911, 576);
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
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa,
            this.colDonViID});
            this.gridViewPhongBan.GridControl = this.gridControlPhongBan;
            this.gridViewPhongBan.Name = "gridViewPhongBan";
            this.gridViewPhongBan.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colIDPhongBan
            // 
            this.colIDPhongBan.FieldName = "IDPhongBan";
            this.colIDPhongBan.Name = "colIDPhongBan";
            this.colIDPhongBan.Visible = true;
            this.colIDPhongBan.VisibleIndex = 0;
            // 
            // colMaPhongBan
            // 
            this.colMaPhongBan.FieldName = "MaPhongBan";
            this.colMaPhongBan.Name = "colMaPhongBan";
            this.colMaPhongBan.Visible = true;
            this.colMaPhongBan.VisibleIndex = 1;
            // 
            // colTenPhongBan
            // 
            this.colTenPhongBan.FieldName = "TenPhongBan";
            this.colTenPhongBan.Name = "colTenPhongBan";
            this.colTenPhongBan.Visible = true;
            this.colTenPhongBan.VisibleIndex = 2;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            // 
            // colNgayTao
            // 
            this.colNgayTao.FieldName = "NgayTao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.Visible = true;
            this.colNgayTao.VisibleIndex = 4;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 5;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.Visible = true;
            this.colDaXoa.VisibleIndex = 6;
            // 
            // colDonViID
            // 
            this.colDonViID.FieldName = "DonViID";
            this.colDonViID.Name = "colDonViID";
            this.colDonViID.Visible = true;
            this.colDonViID.VisibleIndex = 7;
            // 
            // dvPhongBanTableAdapter
            // 
            this.dvPhongBanTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 576);
            this.Controls.Add(this.gridControlPhongBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPhongBan";
            this.Text = "frmPhongBan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPhongBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPhongBan)).EndInit();
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
    }
}