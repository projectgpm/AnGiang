namespace AnGiang.Layout.Luong
{
    partial class frmDinhMucTienLuong
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
            this.lgLuongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lgLuongTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.lgLuongTableAdapter();
            this.tableAdapterManager = new AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager();
            this.lgLuongGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewDinhMucTienLuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDLgLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuongVung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLuongCoBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienCuoiNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgLuongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgLuongGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDinhMucTienLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lgLuongBindingSource
            // 
            this.lgLuongBindingSource.DataMember = "lgLuong";
            this.lgLuongBindingSource.DataSource = this.anGiangDataSet;
            // 
            // lgLuongTableAdapter
            // 
            this.lgLuongTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.lgLuongTableAdapter = this.lgLuongTableAdapter;
            this.tableAdapterManager.lskLoaiSuKienTableAdapter = null;
            this.tableAdapterManager.lskSuKienTableAdapter = null;
            this.tableAdapterManager.nvChucDanhTableAdapter = null;
            this.tableAdapterManager.nvDanhMucCDTableAdapter = null;
            this.tableAdapterManager.nvNhanVienTableAdapter = null;
            this.tableAdapterManager.tlDinhMucTableAdapter = null;
            this.tableAdapterManager.TrinhDoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lgLuongGridControl
            // 
            this.lgLuongGridControl.DataSource = this.lgLuongBindingSource;
            this.lgLuongGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lgLuongGridControl.Location = new System.Drawing.Point(0, 0);
            this.lgLuongGridControl.MainView = this.gridViewDinhMucTienLuong;
            this.lgLuongGridControl.Name = "lgLuongGridControl";
            this.lgLuongGridControl.Size = new System.Drawing.Size(1245, 600);
            this.lgLuongGridControl.TabIndex = 1;
            this.lgLuongGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDinhMucTienLuong});
            // 
            // gridViewDinhMucTienLuong
            // 
            this.gridViewDinhMucTienLuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDLgLuong,
            this.colLuongVung,
            this.colLuongCoBan,
            this.colTienCuoiNam,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa});
            this.gridViewDinhMucTienLuong.GridControl = this.lgLuongGridControl;
            this.gridViewDinhMucTienLuong.Name = "gridViewDinhMucTienLuong";
            this.gridViewDinhMucTienLuong.NewItemRowText = "Nhấn vào đây để thêm mới";
            this.gridViewDinhMucTienLuong.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridViewDinhMucTienLuong.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewDinhMucTienLuong.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewDinhMucTienLuong.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewDinhMucTienLuong.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colIDLgLuong
            // 
            this.colIDLgLuong.FieldName = "IDLgLuong";
            this.colIDLgLuong.Name = "colIDLgLuong";
            this.colIDLgLuong.OptionsColumn.AllowEdit = false;
            // 
            // colLuongVung
            // 
            this.colLuongVung.Caption = "Lương vùng";
            this.colLuongVung.FieldName = "LuongVung";
            this.colLuongVung.Name = "colLuongVung";
            this.colLuongVung.OptionsColumn.AllowEdit = false;
            this.colLuongVung.Visible = true;
            this.colLuongVung.VisibleIndex = 0;
            // 
            // colLuongCoBan
            // 
            this.colLuongCoBan.Caption = "Lương cơ bản";
            this.colLuongCoBan.FieldName = "LuongCoBan";
            this.colLuongCoBan.Name = "colLuongCoBan";
            this.colLuongCoBan.OptionsColumn.AllowEdit = false;
            this.colLuongCoBan.Visible = true;
            this.colLuongCoBan.VisibleIndex = 1;
            // 
            // colTienCuoiNam
            // 
            this.colTienCuoiNam.Caption = "Tiền cuối năm";
            this.colTienCuoiNam.FieldName = "TienCuoiNam";
            this.colTienCuoiNam.Name = "colTienCuoiNam";
            this.colTienCuoiNam.OptionsColumn.AllowEdit = false;
            this.colTienCuoiNam.Visible = true;
            this.colTienCuoiNam.VisibleIndex = 2;
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
            // frmDinhMucTienLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 600);
            this.Controls.Add(this.lgLuongGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDinhMucTienLuong";
            this.Text = "frmDinhMucTienLuong";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDinhMucTienLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgLuongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgLuongGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDinhMucTienLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource lgLuongBindingSource;
        private AnGiangDataSetTableAdapters.lgLuongTableAdapter lgLuongTableAdapter;
        private AnGiangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lgLuongGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDinhMucTienLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLgLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colLuongVung;
        private DevExpress.XtraGrid.Columns.GridColumn colLuongCoBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTienCuoiNam;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
    }
}