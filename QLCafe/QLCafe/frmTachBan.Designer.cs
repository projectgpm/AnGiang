namespace QLCafe
{
    partial class frmTachBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTachBan));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFChiTietHoaDonTempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHangHoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrongLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDChiNhanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.lbChiTiet = new DevExpress.XtraEditors.LabelControl();
            this.lbTTTachBan = new DevExpress.XtraEditors.LabelControl();
            this.cF_ChiTietHoaDon_TempTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_ChiTietHoaDon_TempTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFChiTietHoaDonTempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFChiTietHoaDonTempBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1});
            this.gridControl1.Size = new System.Drawing.Size(247, 297);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cFChiTietHoaDonTempBindingSource
            // 
            this.cFChiTietHoaDonTempBindingSource.DataMember = "CF_ChiTietHoaDon_Temp";
            this.cFChiTietHoaDonTempBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDHoaDon,
            this.colIDHangHoa,
            this.colTenHangHoa,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien,
            this.colIDBan,
            this.colTrongLuong,
            this.colIDChiNhanh});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFilter.AllowColumnMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            this.gridView1.OptionsFilter.AllowFilterIncrementalSearch = false;
            this.gridView1.OptionsFilter.AllowMRUFilterList = false;
            this.gridView1.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
            this.gridView1.OptionsFind.AllowFindPanel = false;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIDHoaDon
            // 
            this.colIDHoaDon.FieldName = "IDHoaDon";
            this.colIDHoaDon.Name = "colIDHoaDon";
            this.colIDHoaDon.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIDHangHoa
            // 
            this.colIDHangHoa.FieldName = "IDHangHoa";
            this.colIDHangHoa.Name = "colIDHangHoa";
            this.colIDHangHoa.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colTenHangHoa
            // 
            this.colTenHangHoa.Caption = "Hàng Hóa";
            this.colTenHangHoa.FieldName = "TenHangHoa";
            this.colTenHangHoa.Name = "colTenHangHoa";
            this.colTenHangHoa.OptionsColumn.AllowEdit = false;
            this.colTenHangHoa.OptionsColumn.AllowFocus = false;
            this.colTenHangHoa.OptionsColumn.ReadOnly = true;
            this.colTenHangHoa.Visible = true;
            this.colTenHangHoa.VisibleIndex = 0;
            this.colTenHangHoa.Width = 126;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng";
            this.colSoLuong.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.OptionsColumn.AllowMove = false;
            this.colSoLuong.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSoLuong.OptionsColumn.FixedWidth = true;
            this.colSoLuong.OptionsFilter.AllowAutoFilter = false;
            this.colSoLuong.OptionsFilter.AllowFilter = false;
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            this.colSoLuong.Width = 76;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Mask.BeepOnError = true;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            this.repositoryItemSpinEdit1.NullText = "0";
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn Giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành Tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIDBan
            // 
            this.colIDBan.FieldName = "IDBan";
            this.colIDBan.Name = "colIDBan";
            this.colIDBan.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colTrongLuong
            // 
            this.colTrongLuong.FieldName = "TrongLuong";
            this.colTrongLuong.Name = "colTrongLuong";
            this.colTrongLuong.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIDChiNhanh
            // 
            this.colIDChiNhanh.FieldName = "IDChiNhanh";
            this.colIDChiNhanh.Name = "colIDChiNhanh";
            this.colIDChiNhanh.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(3, 65);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(251, 301);
            this.panelControl1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.59061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.4094F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(263, 424);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.tableLayoutPanel2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(3, 378);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(257, 43);
            this.panelControl2.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnDongY, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(253, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnDongY
            // 
            this.btnDongY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDongY.Image = ((System.Drawing.Image)(resources.GetObject("btnDongY.Image")));
            this.btnDongY.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDongY.Location = new System.Drawing.Point(3, 3);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(120, 33);
            this.btnDongY.TabIndex = 0;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(129, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(121, 33);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Hủy";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panelControl1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelControl3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.07317F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.92683F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 369);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.lbChiTiet);
            this.panelControl3.Controls.Add(this.lbTTTachBan);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(3, 3);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(251, 56);
            this.panelControl3.TabIndex = 2;
            // 
            // lbChiTiet
            // 
            this.lbChiTiet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbChiTiet.Location = new System.Drawing.Point(2, 25);
            this.lbChiTiet.Name = "lbChiTiet";
            this.lbChiTiet.Size = new System.Drawing.Size(247, 29);
            this.lbChiTiet.TabIndex = 1;
            this.lbChiTiet.Text = "Hãy chọn số lượng món ăn cần tách ra cho";
            // 
            // lbTTTachBan
            // 
            this.lbTTTachBan.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lbTTTachBan.Appearance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbTTTachBan.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbTTTachBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTTTachBan.Location = new System.Drawing.Point(2, 2);
            this.lbTTTachBan.Name = "lbTTTachBan";
            this.lbTTTachBan.Size = new System.Drawing.Size(247, 23);
            this.lbTTTachBan.TabIndex = 0;
            this.lbTTTachBan.Text = "Tách từ bàn A ra bàn B";
            // 
            // cF_ChiTietHoaDon_TempTableAdapter
            // 
            this.cF_ChiTietHoaDon_TempTableAdapter.ClearBeforeFill = true;
            // 
            // frmTachBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 424);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTachBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tách Bàn";
            this.Load += new System.EventHandler(this.frmTachBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFChiTietHoaDonTempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFChiTietHoaDonTempBindingSource;
        private quanlycafeDataSetTableAdapters.CF_ChiTietHoaDon_TempTableAdapter cF_ChiTietHoaDon_TempTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colIDHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHangHoa;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBan;
        private DevExpress.XtraGrid.Columns.GridColumn colTrongLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colIDChiNhanh;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl lbChiTiet;
        private DevExpress.XtraEditors.LabelControl lbTTTachBan;
    }
}