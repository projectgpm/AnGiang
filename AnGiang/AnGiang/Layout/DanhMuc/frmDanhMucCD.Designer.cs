namespace AnGiang.Layout.DanhMuc
{
    partial class frmDanhMucCD
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
            this.nvDanhMucCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvDanhMucCDTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvDanhMucCDTableAdapter();
            this.tableAdapterManager = new AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager();
            this.nvDanhMucCDGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhMucCD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDanhMucCD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucCD)).BeginInit();
            this.SuspendLayout();
            // 
            // anGiangDataSet
            // 
            this.anGiangDataSet.DataSetName = "AnGiangDataSet";
            this.anGiangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nvDanhMucCDBindingSource
            // 
            this.nvDanhMucCDBindingSource.DataMember = "nvDanhMucCD";
            this.nvDanhMucCDBindingSource.DataSource = this.anGiangDataSet;
            // 
            // nvDanhMucCDTableAdapter
            // 
            this.nvDanhMucCDTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.nvDanhMucCDTableAdapter = this.nvDanhMucCDTableAdapter;
            this.tableAdapterManager.nvNhanVienTableAdapter = null;
            this.tableAdapterManager.tlDinhMucTableAdapter = null;
            this.tableAdapterManager.TrinhDoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nvDanhMucCDGridControl
            // 
            this.nvDanhMucCDGridControl.DataSource = this.nvDanhMucCDBindingSource;
            this.nvDanhMucCDGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nvDanhMucCDGridControl.Location = new System.Drawing.Point(0, 0);
            this.nvDanhMucCDGridControl.MainView = this.gridViewDanhMucCD;
            this.nvDanhMucCDGridControl.Name = "nvDanhMucCDGridControl";
            this.nvDanhMucCDGridControl.Size = new System.Drawing.Size(1081, 438);
            this.nvDanhMucCDGridControl.TabIndex = 1;
            this.nvDanhMucCDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhMucCD});
            // 
            // gridViewDanhMucCD
            // 
            this.gridViewDanhMucCD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDanhMucCD,
            this.colTenChucDanh,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa});
            this.gridViewDanhMucCD.GridControl = this.nvDanhMucCDGridControl;
            this.gridViewDanhMucCD.Name = "gridViewDanhMucCD";
            this.gridViewDanhMucCD.NewItemRowText = "Nhấn đây vào để thêm mới";
            this.gridViewDanhMucCD.OptionsBehavior.AutoUpdateTotalSummary = false;
            this.gridViewDanhMucCD.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.gridViewDanhMucCD.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gridViewDanhMucCD.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridViewDanhMucCD.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewDanhMucCD.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewDanhMucCD.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridViewDanhMucCD.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewDanhMucCD_ValidateRow);
            // 
            // colIDDanhMucCD
            // 
            this.colIDDanhMucCD.FieldName = "IDDanhMucCD";
            this.colIDDanhMucCD.Name = "colIDDanhMucCD";
            this.colIDDanhMucCD.OptionsColumn.AllowEdit = false;
            // 
            // colTenChucDanh
            // 
            this.colTenChucDanh.Caption = "Tên chức danh";
            this.colTenChucDanh.FieldName = "TenChucDanh";
            this.colTenChucDanh.Name = "colTenChucDanh";
            this.colTenChucDanh.OptionsColumn.AllowEdit = false;
            this.colTenChucDanh.Visible = true;
            this.colTenChucDanh.VisibleIndex = 0;
            this.colTenChucDanh.Width = 350;
            // 
            // colNgayTao
            // 
            this.colNgayTao.Caption = "Ngày tạo";
            this.colNgayTao.FieldName = "NgayTao";
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.OptionsColumn.AllowEdit = false;
            this.colNgayTao.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayTao.Visible = true;
            this.colNgayTao.VisibleIndex = 1;
            this.colNgayTao.Width = 290;
            // 
            // colNgayCapNhat
            // 
            this.colNgayCapNhat.Caption = "Ngày cập nhật";
            this.colNgayCapNhat.FieldName = "NgayCapNhat";
            this.colNgayCapNhat.Name = "colNgayCapNhat";
            this.colNgayCapNhat.OptionsColumn.AllowEdit = false;
            this.colNgayCapNhat.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colNgayCapNhat.Visible = true;
            this.colNgayCapNhat.VisibleIndex = 2;
            this.colNgayCapNhat.Width = 421;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsColumn.AllowEdit = false;
            // 
            // frmDanhMucCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 438);
            this.Controls.Add(this.nvDanhMucCDGridControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhMucCD";
            this.Text = "frmDanhMucCD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhMucCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhMucCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnGiangDataSet anGiangDataSet;
        private System.Windows.Forms.BindingSource nvDanhMucCDBindingSource;
        private AnGiangDataSetTableAdapters.nvDanhMucCDTableAdapter nvDanhMucCDTableAdapter;
        private AnGiangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nvDanhMucCDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhMucCD;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDanhMucCD;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
    }
}