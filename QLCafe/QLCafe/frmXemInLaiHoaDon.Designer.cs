namespace QLCafe
{
    partial class frmXemInLaiHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemInLaiHoaDon));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioVao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioRa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbBan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachCanTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachThanhToan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienThua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHinhThucGiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTienGiamGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.documentViewerBarManager1 = new DevExpress.XtraPrinting.Preview.DocumentViewerBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cF_HoaDonTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_HoaDonTableAdapter();
            this.cF_BanTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_BanTableAdapter();
            this.cF_NguoiDungTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(753, 561);
            this.splitContainerControl1.SplitterPosition = 435;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFHoaDonBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbBan,
            this.cbNhanVien});
            this.gridControl1.Size = new System.Drawing.Size(435, 561);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cFHoaDonBindingSource
            // 
            this.cFHoaDonBindingSource.DataMember = "CF_HoaDon";
            this.cFHoaDonBindingSource.DataSource = this.quanlycafeDataSet;
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
            this.colGioVao,
            this.colGioRa,
            this.colIDBan,
            this.colMaHoaDon,
            this.colIDNhanVien,
            this.colTongTien,
            this.colGiamGia,
            this.colKhachCanTra,
            this.colKhachThanhToan,
            this.colTienThua,
            this.colHinhThucGiamGia,
            this.colTienGiamGia});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "........";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colGioVao
            // 
            this.colGioVao.Caption = "Giờ Vào";
            this.colGioVao.FieldName = "GioVao";
            this.colGioVao.Name = "colGioVao";
            this.colGioVao.Visible = true;
            this.colGioVao.VisibleIndex = 4;
            // 
            // colGioRa
            // 
            this.colGioRa.Caption = "Giờ Ra";
            this.colGioRa.FieldName = "GioRa";
            this.colGioRa.Name = "colGioRa";
            this.colGioRa.Visible = true;
            this.colGioRa.VisibleIndex = 5;
            // 
            // colIDBan
            // 
            this.colIDBan.Caption = "Bàn";
            this.colIDBan.ColumnEdit = this.cbBan;
            this.colIDBan.FieldName = "IDBan";
            this.colIDBan.Name = "colIDBan";
            this.colIDBan.Visible = true;
            this.colIDBan.VisibleIndex = 2;
            this.colIDBan.Width = 70;
            // 
            // cbBan
            // 
            this.cbBan.AutoHeight = false;
            this.cbBan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbBan.DataSource = this.cFBanBindingSource;
            this.cbBan.DisplayMember = "TenBan";
            this.cbBan.KeyMember = "ID;IDKhuVuc;TrangThai;NgayCapNhat;IDChiNhanh;DaXoa;MaBan";
            this.cbBan.Name = "cbBan";
            this.cbBan.ValueMember = "ID";
            // 
            // cFBanBindingSource
            // 
            this.cFBanBindingSource.DataMember = "CF_Ban";
            this.cFBanBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.Caption = "Hóa Đơn";
            this.colMaHoaDon.FieldName = "MaHoaDon";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Visible = true;
            this.colMaHoaDon.VisibleIndex = 0;
            // 
            // colIDNhanVien
            // 
            this.colIDNhanVien.Caption = "Nhân Viên";
            this.colIDNhanVien.ColumnEdit = this.cbNhanVien;
            this.colIDNhanVien.FieldName = "IDNhanVien";
            this.colIDNhanVien.Name = "colIDNhanVien";
            this.colIDNhanVien.Visible = true;
            this.colIDNhanVien.VisibleIndex = 1;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.AutoHeight = false;
            this.cbNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbNhanVien.DataSource = this.cFNguoiDungBindingSource;
            this.cbNhanVien.DisplayMember = "TenNguoiDung";
            this.cbNhanVien.KeyMember = "ID;TenNguoiDung;TenDangNhap;SDT;MatKhau;Email;IDNhomNguoiDung;NgayCapNhat;DaXoa;I" +
    "DChiNhanh";
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.ValueMember = "ID";
            // 
            // cFNguoiDungBindingSource
            // 
            this.cFNguoiDungBindingSource.DataMember = "CF_NguoiDung";
            this.cFNguoiDungBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 3;
            // 
            // colGiamGia
            // 
            this.colGiamGia.Caption = "Giảm Giá";
            this.colGiamGia.FieldName = "GiamGia";
            this.colGiamGia.Name = "colGiamGia";
            this.colGiamGia.Visible = true;
            this.colGiamGia.VisibleIndex = 11;
            // 
            // colKhachCanTra
            // 
            this.colKhachCanTra.Caption = "Số Tiền Khách Cần Trả";
            this.colKhachCanTra.FieldName = "KhachCanTra";
            this.colKhachCanTra.Name = "colKhachCanTra";
            this.colKhachCanTra.Visible = true;
            this.colKhachCanTra.VisibleIndex = 7;
            // 
            // colKhachThanhToan
            // 
            this.colKhachThanhToan.Caption = "Số Tiền Khách Đưa";
            this.colKhachThanhToan.FieldName = "KhachThanhToan";
            this.colKhachThanhToan.Name = "colKhachThanhToan";
            this.colKhachThanhToan.Visible = true;
            this.colKhachThanhToan.VisibleIndex = 6;
            // 
            // colTienThua
            // 
            this.colTienThua.Caption = "Thối Lại";
            this.colTienThua.FieldName = "TienThua";
            this.colTienThua.Name = "colTienThua";
            this.colTienThua.Visible = true;
            this.colTienThua.VisibleIndex = 9;
            // 
            // colHinhThucGiamGia
            // 
            this.colHinhThucGiamGia.Caption = "Hình Thức TT";
            this.colHinhThucGiamGia.FieldName = "HinhThucGiamGia";
            this.colHinhThucGiamGia.Name = "colHinhThucGiamGia";
            this.colHinhThucGiamGia.Visible = true;
            this.colHinhThucGiamGia.VisibleIndex = 8;
            // 
            // colTienGiamGia
            // 
            this.colTienGiamGia.Caption = "Phụ Thu";
            this.colTienGiamGia.FieldName = "TienGiamGia";
            this.colTienGiamGia.Name = "colTienGiamGia";
            this.colTienGiamGia.Visible = true;
            this.colTienGiamGia.VisibleIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.documentViewer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.51337F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.486631F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // documentViewer1
            // 
            this.documentViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentViewer1.HorizontalScrollBarVisibility = DevExpress.XtraEditors.ViewInfo.ScrollBarVisibility.Hidden;
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(3, 3);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(307, 512);
            this.documentViewer1.Status = "Chưa có hóa đơn.";
            this.documentViewer1.TabIndex = 0;
            this.documentViewer1.VerticalScrollBarVisibility = DevExpress.XtraEditors.ViewInfo.ScrollBarVisibility.Hidden;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 521);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(307, 37);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "In Lại Hóa Đơn";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // documentViewerBarManager1
            // 
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlTop);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlBottom);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlLeft);
            this.documentViewerBarManager1.DockControls.Add(this.barDockControlRight);
            this.documentViewerBarManager1.DocumentViewer = this.documentViewer1;
            this.documentViewerBarManager1.Form = this;
            this.documentViewerBarManager1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("documentViewerBarManager1.ImageStream")));
            this.documentViewerBarManager1.MaxItemId = 58;
            this.documentViewerBarManager1.PreviewBar = null;
            this.documentViewerBarManager1.TransparentEditors = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(753, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 561);
            this.barDockControlBottom.Size = new System.Drawing.Size(753, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 561);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(753, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 561);
            // 
            // cF_HoaDonTableAdapter
            // 
            this.cF_HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // cF_BanTableAdapter
            // 
            this.cF_BanTableAdapter.ClearBeforeFill = true;
            // 
            // cF_NguoiDungTableAdapter
            // 
            this.cF_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // frmXemInLaiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 561);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmXemInLaiHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem lại hóa đơn và In";
            this.Load += new System.EventHandler(this.frmXemInLaiHoaDoncs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerBarManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraPrinting.Preview.DocumentViewerBarManager documentViewerBarManager1;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFHoaDonBindingSource;
        private quanlycafeDataSetTableAdapters.CF_HoaDonTableAdapter cF_HoaDonTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colGioVao;
        private DevExpress.XtraGrid.Columns.GridColumn colGioRa;
        private DevExpress.XtraGrid.Columns.GridColumn colIDBan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colGiamGia;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachCanTra;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachThanhToan;
        private DevExpress.XtraGrid.Columns.GridColumn colTienThua;
        private DevExpress.XtraGrid.Columns.GridColumn colHinhThucGiamGia;
        private DevExpress.XtraGrid.Columns.GridColumn colTienGiamGia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbBan;
        private System.Windows.Forms.BindingSource cFBanBindingSource;
        private quanlycafeDataSetTableAdapters.CF_BanTableAdapter cF_BanTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cbNhanVien;
        private System.Windows.Forms.BindingSource cFNguoiDungBindingSource;
        private quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter cF_NguoiDungTableAdapter;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}