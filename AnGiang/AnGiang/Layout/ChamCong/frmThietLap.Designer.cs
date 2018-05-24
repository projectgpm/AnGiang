namespace AnGiang.Layout.ChamCong
{
    partial class frmThietLap
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
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.tlDinhMucBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlDinhMucTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.tlDinhMucTableAdapter();
            this.tableAdapterManager = new AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager();
            this.tlDinhMucGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewThietLap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDinhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDinhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDinhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHeSoDinhMuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDinhMucBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDinhMucGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThietLap)).BeginInit();
            this.SuspendLayout();
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tlDinhMucBindingSource
            // 
            this.tlDinhMucBindingSource.DataMember = "tlDinhMuc";
            this.tlDinhMucBindingSource.DataSource = this.anGiangDataSet;
            // 
            // tlDinhMucTableAdapter
            // 
            this.tlDinhMucTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ccChamCongTableAdapter = null;
            this.tableAdapterManager.ccChiTietTableAdapter = null;
            this.tableAdapterManager.ccKyHieuTableAdapter = null;
            this.tableAdapterManager.dvChuyenMonTableAdapter = null;
            this.tableAdapterManager.dvDonViTableAdapter = null;
            this.tableAdapterManager.dvPhongBanTableAdapter = null;
            this.tableAdapterManager.lgLuongTableAdapter = null;
            this.tableAdapterManager.lskLoaiSuKienTableAdapter = null;
            this.tableAdapterManager.lskSuKienTableAdapter = null;
            this.tableAdapterManager.nvChucDanhTableAdapter = null;
            this.tableAdapterManager.nvDanhMucCDTableAdapter = null;
            this.tableAdapterManager.nvNhanVienTableAdapter = null;
            this.tableAdapterManager.tlDinhMucTableAdapter = this.tlDinhMucTableAdapter;
            this.tableAdapterManager.TrinhDoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tlDinhMucGridControl
            // 
            this.tlDinhMucGridControl.DataSource = this.tlDinhMucBindingSource;
            this.tlDinhMucGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDinhMucGridControl.Location = new System.Drawing.Point(0, 0);
            this.tlDinhMucGridControl.MainView = this.gridViewThietLap;
            this.tlDinhMucGridControl.Name = "tlDinhMucGridControl";
            this.tlDinhMucGridControl.Size = new System.Drawing.Size(1215, 545);
            this.tlDinhMucGridControl.TabIndex = 1;
            this.tlDinhMucGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThietLap});
            // 
            // gridViewThietLap
            // 
            this.gridViewThietLap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDinhMuc,
            this.colMaDinhMuc,
            this.colTenDinhMuc,
            this.colHeSoDinhMuc,
            this.colGhiChu,
            this.colNgayTao,
            this.colNgayCapNhat});
            this.gridViewThietLap.GridControl = this.tlDinhMucGridControl;
            this.gridViewThietLap.Name = "gridViewThietLap";
            this.gridViewThietLap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colIDDinhMuc
            // 
            this.colIDDinhMuc.FieldName = "IDDinhMuc";
            this.colIDDinhMuc.Name = "colIDDinhMuc";
            this.colIDDinhMuc.OptionsColumn.AllowEdit = false;
            this.colIDDinhMuc.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colMaDinhMuc
            // 
            this.colMaDinhMuc.Caption = "Mã định mức";
            this.colMaDinhMuc.FieldName = "MaDinhMuc";
            this.colMaDinhMuc.Name = "colMaDinhMuc";
            this.colMaDinhMuc.OptionsColumn.AllowEdit = false;
            this.colMaDinhMuc.Visible = true;
            this.colMaDinhMuc.VisibleIndex = 0;
            this.colMaDinhMuc.Width = 298;
            // 
            // colTenDinhMuc
            // 
            this.colTenDinhMuc.Caption = "Tên định mức";
            this.colTenDinhMuc.FieldName = "TenDinhMuc";
            this.colTenDinhMuc.Name = "colTenDinhMuc";
            this.colTenDinhMuc.OptionsColumn.AllowEdit = false;
            this.colTenDinhMuc.Visible = true;
            this.colTenDinhMuc.VisibleIndex = 1;
            this.colTenDinhMuc.Width = 457;
            // 
            // colHeSoDinhMuc
            // 
            this.colHeSoDinhMuc.Caption = "Hệ số định mức";
            this.colHeSoDinhMuc.FieldName = "HeSoDinhMuc";
            this.colHeSoDinhMuc.Name = "colHeSoDinhMuc";
            this.colHeSoDinhMuc.OptionsColumn.AllowEdit = false;
            this.colHeSoDinhMuc.Visible = true;
            this.colHeSoDinhMuc.VisibleIndex = 2;
            this.colHeSoDinhMuc.Width = 201;
            // 
            // colGhiChu
            // 
            this.colGhiChu.Caption = "Ghi chú";
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
            this.colGhiChu.Visible = true;
            this.colGhiChu.VisibleIndex = 3;
            this.colGhiChu.Width = 239;
            // 
            // colNgayTao
            // 
            this.colNgayTao.FieldName = "NgayTao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.OptionsColumn.AllowEdit = false;
            this.colNgayTao.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsColumn.AllowEdit = false;
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // frmThietLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 545);
            this.Controls.Add(this.tlDinhMucGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThietLap";
            this.Text = "frmThietLap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThietLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDinhMucBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlDinhMucGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThietLap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource tlDinhMucBindingSource;
        private AnGiangDataSetTableAdapters.tlDinhMucTableAdapter tlDinhMucTableAdapter;
        private AnGiangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl tlDinhMucGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThietLap;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDinhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDinhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDinhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colHeSoDinhMuc;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
    }
}