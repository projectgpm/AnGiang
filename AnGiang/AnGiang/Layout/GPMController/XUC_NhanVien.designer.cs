namespace AnGiang.Layout.GPMController
{
    partial class XUC_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label heSoChucDanhLabel;
            System.Windows.Forms.Label chucDanhIDLabel;
            System.Windows.Forms.Label maNhanVienLabel;
            System.Windows.Forms.Label ngayNghiViecLabel;
            System.Windows.Forms.Label tGPCKKLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label heSoLuongLabel;
            System.Windows.Forms.Label trinhDoIDLabel;
            System.Windows.Forms.Label phongBanIDLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label ngayLamViecLabel;
            System.Windows.Forms.Label ghiChuLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label cMNDLabel;
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.trinhDoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anGiangDataSet = new AnGiang.AnGiangDataSet();
            this.nvChucDanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvDanhMucCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dvPhongBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nvNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dvPhongBanTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.dvPhongBanTableAdapter();
            this.trinhDoTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.TrinhDoTableAdapter();
            this.nvNhanVienTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvNhanVienTableAdapter();
            this.tableAdapterManager = new AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager();
            this.nvChucDanhTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvChucDanhTableAdapter();
            this.nvDanhMucCDTableAdapter = new AnGiang.AnGiangDataSetTableAdapters.nvDanhMucCDTableAdapter();
            this.nvNhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhongBanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rlsPhongBan = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ngayNghiViecDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ngayLamViecDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ngaySinhdateEdit = new DevExpress.XtraEditors.DateEdit();
            this.gioiTinhSpinEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoTenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maNhanVienTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dienThoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.trinhDoIDSpinEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.HinhAnhPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.chucDanhIDSpinEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayCapNhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDaXoa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDanhMucCDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tGPCKKSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.heSoChucDanhSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.heSoLuongTextEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ghiChuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phongBanIDSpinEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            heSoChucDanhLabel = new System.Windows.Forms.Label();
            chucDanhIDLabel = new System.Windows.Forms.Label();
            maNhanVienLabel = new System.Windows.Forms.Label();
            ngayNghiViecLabel = new System.Windows.Forms.Label();
            tGPCKKLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            heSoLuongLabel = new System.Windows.Forms.Label();
            trinhDoIDLabel = new System.Windows.Forms.Label();
            phongBanIDLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            ngayLamViecLabel = new System.Windows.Forms.Label();
            ghiChuLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayNghiViecDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayNghiViecDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayLamViecDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayLamViecDateEdit.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhdateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhdateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhanVienTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienThoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnhPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucDanhIDSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGPCKKSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoChucDanhSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanIDSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // heSoChucDanhLabel
            // 
            heSoChucDanhLabel.AutoSize = true;
            heSoChucDanhLabel.Location = new System.Drawing.Point(26, 340);
            heSoChucDanhLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            heSoChucDanhLabel.Name = "heSoChucDanhLabel";
            heSoChucDanhLabel.Size = new System.Drawing.Size(106, 13);
            heSoChucDanhLabel.TabIndex = 43;
            heSoChucDanhLabel.Text = "14. Hệ số chức danh";
            // 
            // chucDanhIDLabel
            // 
            chucDanhIDLabel.AutoSize = true;
            chucDanhIDLabel.Location = new System.Drawing.Point(26, 388);
            chucDanhIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            chucDanhIDLabel.Name = "chucDanhIDLabel";
            chucDanhIDLabel.Size = new System.Drawing.Size(78, 13);
            chucDanhIDLabel.TabIndex = 43;
            chucDanhIDLabel.Text = "16. Chức danh";
            // 
            // maNhanVienLabel
            // 
            maNhanVienLabel.AutoSize = true;
            maNhanVienLabel.Location = new System.Drawing.Point(24, 7);
            maNhanVienLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            maNhanVienLabel.Name = "maNhanVienLabel";
            maNhanVienLabel.Size = new System.Drawing.Size(84, 13);
            maNhanVienLabel.TabIndex = 2;
            maNhanVienLabel.Text = "1. Mã nhân viên";
            // 
            // ngayNghiViecLabel
            // 
            ngayNghiViecLabel.AutoSize = true;
            ngayNghiViecLabel.Location = new System.Drawing.Point(26, 292);
            ngayNghiViecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngayNghiViecLabel.Name = "ngayNghiViecLabel";
            ngayNghiViecLabel.Size = new System.Drawing.Size(77, 13);
            ngayNghiViecLabel.TabIndex = 18;
            ngayNghiViecLabel.Text = "12. Phòng ban";
            // 
            // tGPCKKLabel
            // 
            tGPCKKLabel.AutoSize = true;
            tGPCKKLabel.Location = new System.Drawing.Point(24, 364);
            tGPCKKLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tGPCKKLabel.Name = "tGPCKKLabel";
            tGPCKKLabel.Size = new System.Drawing.Size(118, 13);
            tGPCKKLabel.TabIndex = 43;
            tGPCKKLabel.Text = "15. Thời gian tính PCKK";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(26, 171);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 13);
            label1.TabIndex = 30;
            label1.Text = "8. Trình Độ";
            // 
            // heSoLuongLabel
            // 
            heSoLuongLabel.AutoSize = true;
            heSoLuongLabel.Location = new System.Drawing.Point(26, 316);
            heSoLuongLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            heSoLuongLabel.Name = "heSoLuongLabel";
            heSoLuongLabel.Size = new System.Drawing.Size(83, 13);
            heSoLuongLabel.TabIndex = 43;
            heSoLuongLabel.Text = "13. Hệ số lương";
            // 
            // trinhDoIDLabel
            // 
            trinhDoIDLabel.AutoSize = true;
            trinhDoIDLabel.Location = new System.Drawing.Point(26, 196);
            trinhDoIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            trinhDoIDLabel.Name = "trinhDoIDLabel";
            trinhDoIDLabel.Size = new System.Drawing.Size(86, 13);
            trinhDoIDLabel.TabIndex = 30;
            trinhDoIDLabel.Text = "9. Ngày làm việc";
            // 
            // phongBanIDLabel
            // 
            phongBanIDLabel.AutoSize = true;
            phongBanIDLabel.Location = new System.Drawing.Point(26, 244);
            phongBanIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            phongBanIDLabel.Name = "phongBanIDLabel";
            phongBanIDLabel.Size = new System.Drawing.Size(61, 13);
            phongBanIDLabel.TabIndex = 26;
            phongBanIDLabel.Text = "11. Ghi chú";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(24, 27);
            hoTenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(52, 13);
            hoTenLabel.TabIndex = 4;
            hoTenLabel.Text = "2. Họ tên";
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(24, 51);
            dienThoaiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(69, 13);
            dienThoaiLabel.TabIndex = 6;
            dienThoaiLabel.Text = "3. Điện thoại";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(24, 75);
            gioiTinhLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(58, 13);
            gioiTinhLabel.TabIndex = 8;
            gioiTinhLabel.Text = "4. Giới tính";
            // 
            // ngayLamViecLabel
            // 
            ngayLamViecLabel.AutoSize = true;
            ngayLamViecLabel.Location = new System.Drawing.Point(24, 220);
            ngayLamViecLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ngayLamViecLabel.Name = "ngayLamViecLabel";
            ngayLamViecLabel.Size = new System.Drawing.Size(96, 13);
            ngayLamViecLabel.TabIndex = 16;
            ngayLamViecLabel.Text = "10. Ngày nghĩ việc";
            // 
            // ghiChuLabel
            // 
            ghiChuLabel.AutoSize = true;
            ghiChuLabel.Location = new System.Drawing.Point(26, 147);
            ghiChuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ghiChuLabel.Name = "ghiChuLabel";
            ghiChuLabel.Size = new System.Drawing.Size(67, 13);
            ghiChuLabel.TabIndex = 14;
            ghiChuLabel.Text = "7. Ngày sinh";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(24, 99);
            diaChiLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(52, 13);
            diaChiLabel.TabIndex = 10;
            diaChiLabel.Text = "5. Địa chỉ";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(24, 123);
            cMNDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(49, 13);
            cMNDLabel.TabIndex = 12;
            cMNDLabel.Text = "6. CMND";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.bbiCancel});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(991, 116);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Tùy chỉnh In";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            this.bsiRecordsCount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "Thêm mới";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Cập nhật";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Xóa";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Lưu lại";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageUri.Uri = "Save";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bbiCancel
            // 
            this.bbiCancel.Caption = "Hủy";
            this.bbiCancel.Id = 20;
            this.bbiCancel.ImageUri.Uri = "Reset";
            this.bbiCancel.Name = "bbiCancel";
            this.bbiCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancel_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Công cụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Chức năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Báo cáo & In";
            // 
            // trinhDoBindingSource
            // 
            this.trinhDoBindingSource.DataMember = "TrinhDo";
            this.trinhDoBindingSource.DataSource = this.anGiangDataSet;
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
            // nvDanhMucCDBindingSource
            // 
            this.nvDanhMucCDBindingSource.DataMember = "nvDanhMucCD";
            this.nvDanhMucCDBindingSource.DataSource = this.anGiangDataSet;
            // 
            // dvPhongBanBindingSource
            // 
            this.dvPhongBanBindingSource.DataMember = "dvPhongBan";
            this.dvPhongBanBindingSource.DataSource = this.anGiangDataSet;
            // 
            // nvNhanVienBindingSource
            // 
            this.nvNhanVienBindingSource.DataMember = "nvNhanVien";
            this.nvNhanVienBindingSource.DataSource = this.anGiangDataSet;
            // 
            // dvPhongBanTableAdapter
            // 
            this.dvPhongBanTableAdapter.ClearBeforeFill = true;
            // 
            // trinhDoTableAdapter
            // 
            this.trinhDoTableAdapter.ClearBeforeFill = true;
            // 
            // nvNhanVienTableAdapter
            // 
            this.nvNhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.dvPhongBanTableAdapter = this.dvPhongBanTableAdapter;
            this.tableAdapterManager.lgBangLuongTableAdapter = null;
            this.tableAdapterManager.lgLuongTableAdapter = null;
            this.tableAdapterManager.lskLoaiSuKienTableAdapter = null;
            this.tableAdapterManager.lskSuKienTableAdapter = null;
            this.tableAdapterManager.nvChucDanhTableAdapter = null;
            this.tableAdapterManager.nvDanhMucCDTableAdapter = null;
            this.tableAdapterManager.nvNhanVienTableAdapter = this.nvNhanVienTableAdapter;
            this.tableAdapterManager.tlDinhMucTableAdapter = null;
            this.tableAdapterManager.TrinhDoTableAdapter = this.trinhDoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AnGiang.AnGiangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nvChucDanhTableAdapter
            // 
            this.nvChucDanhTableAdapter.ClearBeforeFill = true;
            // 
            // nvDanhMucCDTableAdapter
            // 
            this.nvDanhMucCDTableAdapter.ClearBeforeFill = true;
            // 
            // nvNhanVienGridControl
            // 
            this.nvNhanVienGridControl.DataSource = this.nvNhanVienBindingSource;
            this.nvNhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.nvNhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.nvNhanVienGridControl.Location = new System.Drawing.Point(0, 116);
            this.nvNhanVienGridControl.MainView = this.gridView1;
            this.nvNhanVienGridControl.Margin = new System.Windows.Forms.Padding(2);
            this.nvNhanVienGridControl.MenuManager = this.ribbonControl;
            this.nvNhanVienGridControl.Name = "nvNhanVienGridControl";
            this.nvNhanVienGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rlsPhongBan});
            this.nvNhanVienGridControl.Size = new System.Drawing.Size(341, 410);
            this.nvNhanVienGridControl.TabIndex = 101;
            this.nvNhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDNhanVien,
            this.colMaNhanVien,
            this.colHoTen,
            this.colDaXoa,
            this.colPhongBanID});
            this.gridView1.GridControl = this.nvNhanVienGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // colIDNhanVien
            // 
            this.colIDNhanVien.FieldName = "IDNhanVien";
            this.colIDNhanVien.Name = "colIDNhanVien";
            this.colIDNhanVien.OptionsColumn.AllowEdit = false;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã nhân viên";
            this.colMaNhanVien.FieldName = "MaNhanVien";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.OptionsColumn.AllowEdit = false;
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            this.colMaNhanVien.Width = 91;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.OptionsColumn.AllowEdit = false;
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            this.colHoTen.Width = 177;
            // 
            // colDaXoa
            // 
            this.colDaXoa.FieldName = "DaXoa";
            this.colDaXoa.Name = "colDaXoa";
            this.colDaXoa.OptionsColumn.AllowEdit = false;
            // 
            // colPhongBanID
            // 
            this.colPhongBanID.Caption = "Phòng ban";
            this.colPhongBanID.ColumnEdit = this.rlsPhongBan;
            this.colPhongBanID.FieldName = "PhongBanID";
            this.colPhongBanID.Name = "colPhongBanID";
            this.colPhongBanID.OptionsColumn.AllowEdit = false;
            this.colPhongBanID.Visible = true;
            this.colPhongBanID.VisibleIndex = 2;
            this.colPhongBanID.Width = 166;
            // 
            // rlsPhongBan
            // 
            this.rlsPhongBan.AutoHeight = false;
            this.rlsPhongBan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rlsPhongBan.DataSource = this.dvPhongBanBindingSource;
            this.rlsPhongBan.DisplayMember = "TenPhongBan";
            this.rlsPhongBan.Name = "rlsPhongBan";
            this.rlsPhongBan.ValueMember = "IDPhongBan";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.29022F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.70978F));
            this.tableLayoutPanel4.Controls.Add(this.panelControl2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(341, 116);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(650, 410);
            this.tableLayoutPanel4.TabIndex = 102;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(heSoChucDanhLabel);
            this.panelControl2.Controls.Add(chucDanhIDLabel);
            this.panelControl2.Controls.Add(maNhanVienLabel);
            this.panelControl2.Controls.Add(ngayNghiViecLabel);
            this.panelControl2.Controls.Add(tGPCKKLabel);
            this.panelControl2.Controls.Add(label1);
            this.panelControl2.Controls.Add(heSoLuongLabel);
            this.panelControl2.Controls.Add(trinhDoIDLabel);
            this.panelControl2.Controls.Add(phongBanIDLabel);
            this.panelControl2.Controls.Add(hoTenLabel);
            this.panelControl2.Controls.Add(dienThoaiLabel);
            this.panelControl2.Controls.Add(gioiTinhLabel);
            this.panelControl2.Controls.Add(ngayLamViecLabel);
            this.panelControl2.Controls.Add(ghiChuLabel);
            this.panelControl2.Controls.Add(diaChiLabel);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(153, 406);
            this.panelControl2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ngayNghiViecDateEdit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ngayLamViecDateEdit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chucDanhIDSpinEdit, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.tGPCKKSpinEdit, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.heSoChucDanhSpinEdit, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.heSoLuongTextEdit, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.ghiChuTextEdit, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.phongBanIDSpinEdit, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(157, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 410);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ngayNghiViecDateEdit
            // 
            this.ngayNghiViecDateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngayNghiViecDateEdit.EditValue = null;
            this.ngayNghiViecDateEdit.Location = new System.Drawing.Point(2, 219);
            this.ngayNghiViecDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ngayNghiViecDateEdit.MenuManager = this.ribbonControl;
            this.ngayNghiViecDateEdit.Name = "ngayNghiViecDateEdit";
            this.ngayNghiViecDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayNghiViecDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayNghiViecDateEdit.Properties.MinValue = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.ngayNghiViecDateEdit.Properties.NullValuePrompt = "dd/mm/yyyy";
            this.ngayNghiViecDateEdit.Size = new System.Drawing.Size(489, 20);
            this.ngayNghiViecDateEdit.TabIndex = 42;
            // 
            // ngayLamViecDateEdit
            // 
            this.ngayLamViecDateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngayLamViecDateEdit.EditValue = null;
            this.ngayLamViecDateEdit.Location = new System.Drawing.Point(2, 195);
            this.ngayLamViecDateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ngayLamViecDateEdit.MenuManager = this.ribbonControl;
            this.ngayLamViecDateEdit.Name = "ngayLamViecDateEdit";
            this.ngayLamViecDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayLamViecDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayLamViecDateEdit.Properties.MinValue = new System.DateTime(1990, 12, 31, 0, 0, 0, 0);
            this.ngayLamViecDateEdit.Properties.NullValuePrompt = "dd/mm/yyyy";
            this.ngayLamViecDateEdit.Size = new System.Drawing.Size(489, 20);
            this.ngayLamViecDateEdit.TabIndex = 41;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.HinhAnhPictureEdit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(493, 193);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.ngaySinhdateEdit, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.gioiTinhSpinEdit, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cMNDTextEdit, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.diaChiTextEdit, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.hoTenTextEdit, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.maNhanVienTextEdit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dienThoaiTextEdit, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.trinhDoIDSpinEdit, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(308, 193);
            this.tableLayoutPanel2.TabIndex = 46;
            // 
            // ngaySinhdateEdit
            // 
            this.ngaySinhdateEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngaySinhdateEdit.EditValue = null;
            this.ngaySinhdateEdit.Location = new System.Drawing.Point(2, 146);
            this.ngaySinhdateEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ngaySinhdateEdit.MenuManager = this.ribbonControl;
            this.ngaySinhdateEdit.Name = "ngaySinhdateEdit";
            this.ngaySinhdateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhdateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhdateEdit.Properties.MinValue = new System.DateTime(1900, 12, 31, 0, 0, 0, 0);
            this.ngaySinhdateEdit.Properties.NullValuePrompt = "dd/mm/yyyy";
            this.ngaySinhdateEdit.Size = new System.Drawing.Size(304, 20);
            this.ngaySinhdateEdit.TabIndex = 39;
            // 
            // gioiTinhSpinEdit
            // 
            this.gioiTinhSpinEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gioiTinhSpinEdit.EditValue = "-- Chọn giới tính --";
            this.gioiTinhSpinEdit.Location = new System.Drawing.Point(2, 74);
            this.gioiTinhSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.gioiTinhSpinEdit.MenuManager = this.ribbonControl;
            this.gioiTinhSpinEdit.Name = "gioiTinhSpinEdit";
            this.gioiTinhSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gioiTinhSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.gioiTinhSpinEdit.Properties.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.gioiTinhSpinEdit.Properties.PopupFormSize = new System.Drawing.Size(150, 0);
            this.gioiTinhSpinEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.gioiTinhSpinEdit.Size = new System.Drawing.Size(304, 20);
            this.gioiTinhSpinEdit.TabIndex = 36;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cMNDTextEdit.Location = new System.Drawing.Point(2, 122);
            this.cMNDTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.cMNDTextEdit.MenuManager = this.ribbonControl;
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Size = new System.Drawing.Size(304, 20);
            this.cMNDTextEdit.TabIndex = 38;
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diaChiTextEdit.Location = new System.Drawing.Point(2, 98);
            this.diaChiTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.diaChiTextEdit.MenuManager = this.ribbonControl;
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(304, 20);
            this.diaChiTextEdit.TabIndex = 37;
            // 
            // hoTenTextEdit
            // 
            this.hoTenTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoTenTextEdit.Location = new System.Drawing.Point(2, 26);
            this.hoTenTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.hoTenTextEdit.MenuManager = this.ribbonControl;
            this.hoTenTextEdit.Name = "hoTenTextEdit";
            this.hoTenTextEdit.Size = new System.Drawing.Size(304, 20);
            this.hoTenTextEdit.TabIndex = 34;
            // 
            // maNhanVienTextEdit
            // 
            this.maNhanVienTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maNhanVienTextEdit.Location = new System.Drawing.Point(2, 2);
            this.maNhanVienTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.maNhanVienTextEdit.MenuManager = this.ribbonControl;
            this.maNhanVienTextEdit.Name = "maNhanVienTextEdit";
            this.maNhanVienTextEdit.Size = new System.Drawing.Size(304, 20);
            this.maNhanVienTextEdit.TabIndex = 33;
            // 
            // dienThoaiTextEdit
            // 
            this.dienThoaiTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dienThoaiTextEdit.Location = new System.Drawing.Point(2, 50);
            this.dienThoaiTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.dienThoaiTextEdit.MenuManager = this.ribbonControl;
            this.dienThoaiTextEdit.Name = "dienThoaiTextEdit";
            this.dienThoaiTextEdit.Size = new System.Drawing.Size(304, 20);
            this.dienThoaiTextEdit.TabIndex = 35;
            // 
            // trinhDoIDSpinEdit
            // 
            this.trinhDoIDSpinEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trinhDoIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.trinhDoIDSpinEdit.Location = new System.Drawing.Point(2, 170);
            this.trinhDoIDSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.trinhDoIDSpinEdit.MenuManager = this.ribbonControl;
            this.trinhDoIDSpinEdit.Name = "trinhDoIDSpinEdit";
            this.trinhDoIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trinhDoIDSpinEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTrinhDo", "Mã trình độ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTrinhDo", "Tên trình độ")});
            this.trinhDoIDSpinEdit.Properties.DataSource = this.trinhDoBindingSource;
            this.trinhDoIDSpinEdit.Properties.DisplayMember = "TenTrinhDo";
            this.trinhDoIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.trinhDoIDSpinEdit.Properties.NullText = "-- Chọn trình độ --";
            this.trinhDoIDSpinEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.trinhDoIDSpinEdit.Properties.ValueMember = "IDTrinhDo";
            this.trinhDoIDSpinEdit.Size = new System.Drawing.Size(304, 20);
            this.trinhDoIDSpinEdit.TabIndex = 40;
            this.trinhDoIDSpinEdit.Popup += new System.EventHandler(this.trinhDoIDSpinEdit_Popup);
            // 
            // HinhAnhPictureEdit
            // 
            this.HinhAnhPictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HinhAnhPictureEdit.EditValue = global::AnGiang.Properties.Resources.no_avatar;
            this.HinhAnhPictureEdit.Location = new System.Drawing.Point(310, 2);
            this.HinhAnhPictureEdit.Margin = new System.Windows.Forms.Padding(2);
            this.HinhAnhPictureEdit.MenuManager = this.ribbonControl;
            this.HinhAnhPictureEdit.Name = "HinhAnhPictureEdit";
            this.HinhAnhPictureEdit.Properties.InitialImage = null;
            this.HinhAnhPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.HinhAnhPictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.HinhAnhPictureEdit.Properties.ZoomAccelerationFactor = 1D;
            this.HinhAnhPictureEdit.Properties.ZoomPercent = 90D;
            this.HinhAnhPictureEdit.Size = new System.Drawing.Size(181, 189);
            this.HinhAnhPictureEdit.TabIndex = 47;
            // 
            // chucDanhIDSpinEdit
            // 
            this.chucDanhIDSpinEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chucDanhIDSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.chucDanhIDSpinEdit.Location = new System.Drawing.Point(2, 387);
            this.chucDanhIDSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.chucDanhIDSpinEdit.MenuManager = this.ribbonControl;
            this.chucDanhIDSpinEdit.Name = "chucDanhIDSpinEdit";
            this.chucDanhIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.chucDanhIDSpinEdit.Properties.DataSource = this.nvChucDanhBindingSource;
            this.chucDanhIDSpinEdit.Properties.DisplayMember = "TenChucDanh";
            this.chucDanhIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.chucDanhIDSpinEdit.Properties.NullText = "";
            this.chucDanhIDSpinEdit.Properties.NullValuePrompt = "-- Chọn chức danh --";
            this.chucDanhIDSpinEdit.Properties.PopupFormSize = new System.Drawing.Size(500, 0);
            this.chucDanhIDSpinEdit.Properties.ValueMember = "IDChucDanh";
            this.chucDanhIDSpinEdit.Properties.View = this.gridLookUpEdit1View;
            this.chucDanhIDSpinEdit.Size = new System.Drawing.Size(489, 20);
            this.chucDanhIDSpinEdit.TabIndex = 48;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDChucDanh,
            this.colMaChucDanh,
            this.colTenChucDanh,
            this.colGhiChu,
            this.colNgayTao,
            this.colNgayCapNhat,
            this.colDaXoa1,
            this.colDanhMucCDID});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIDChucDanh
            // 
            this.colIDChucDanh.FieldName = "IDChucDanh";
            this.colIDChucDanh.Name = "colIDChucDanh";
            this.colIDChucDanh.OptionsColumn.AllowEdit = false;
            // 
            // colMaChucDanh
            // 
            this.colMaChucDanh.Caption = "Mã chức danh";
            this.colMaChucDanh.FieldName = "MaChucDanh";
            this.colMaChucDanh.Name = "colMaChucDanh";
            this.colMaChucDanh.OptionsColumn.AllowEdit = false;
            this.colMaChucDanh.Visible = true;
            this.colMaChucDanh.VisibleIndex = 0;
            // 
            // colTenChucDanh
            // 
            this.colTenChucDanh.Caption = "Tên chức danh";
            this.colTenChucDanh.FieldName = "TenChucDanh";
            this.colTenChucDanh.Name = "colTenChucDanh";
            this.colTenChucDanh.OptionsColumn.AllowEdit = false;
            this.colTenChucDanh.Visible = true;
            this.colTenChucDanh.VisibleIndex = 1;
            // 
            // colGhiChu
            // 
            this.colGhiChu.FieldName = "GhiChu";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.OptionsColumn.AllowEdit = false;
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
            // colDaXoa1
            // 
            this.colDaXoa1.FieldName = "DaXoa";
            this.colDaXoa1.Name = "colDaXoa1";
            this.colDaXoa1.OptionsColumn.AllowEdit = false;
            // 
            // colDanhMucCDID
            // 
            this.colDanhMucCDID.Caption = "Danh mục";
            this.colDanhMucCDID.FieldName = "DanhMucCDID";
            this.colDanhMucCDID.Name = "colDanhMucCDID";
            this.colDanhMucCDID.OptionsColumn.AllowEdit = false;
            this.colDanhMucCDID.Visible = true;
            this.colDanhMucCDID.VisibleIndex = 2;
            // 
            // tGPCKKSpinEdit
            // 
            this.tGPCKKSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.tGPCKKSpinEdit.Location = new System.Drawing.Point(2, 363);
            this.tGPCKKSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.tGPCKKSpinEdit.MenuManager = this.ribbonControl;
            this.tGPCKKSpinEdit.Name = "tGPCKKSpinEdit";
            this.tGPCKKSpinEdit.Size = new System.Drawing.Size(154, 20);
            this.tGPCKKSpinEdit.TabIndex = 47;
            // 
            // heSoChucDanhSpinEdit
            // 
            this.heSoChucDanhSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.heSoChucDanhSpinEdit.Location = new System.Drawing.Point(2, 339);
            this.heSoChucDanhSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.heSoChucDanhSpinEdit.MenuManager = this.ribbonControl;
            this.heSoChucDanhSpinEdit.Name = "heSoChucDanhSpinEdit";
            this.heSoChucDanhSpinEdit.Size = new System.Drawing.Size(154, 20);
            this.heSoChucDanhSpinEdit.TabIndex = 46;
            // 
            // heSoLuongTextEdit
            // 
            this.heSoLuongTextEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.heSoLuongTextEdit.Location = new System.Drawing.Point(2, 315);
            this.heSoLuongTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.heSoLuongTextEdit.MenuManager = this.ribbonControl;
            this.heSoLuongTextEdit.Name = "heSoLuongTextEdit";
            this.heSoLuongTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.heSoLuongTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.heSoLuongTextEdit.Size = new System.Drawing.Size(154, 20);
            this.heSoLuongTextEdit.TabIndex = 45;
            // 
            // ghiChuTextEdit
            // 
            this.ghiChuTextEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ghiChuTextEdit.Location = new System.Drawing.Point(2, 243);
            this.ghiChuTextEdit.Margin = new System.Windows.Forms.Padding(2);
            this.ghiChuTextEdit.MenuManager = this.ribbonControl;
            this.ghiChuTextEdit.Name = "ghiChuTextEdit";
            this.ghiChuTextEdit.Size = new System.Drawing.Size(489, 20);
            this.ghiChuTextEdit.TabIndex = 43;
            // 
            // phongBanIDSpinEdit
            // 
            this.phongBanIDSpinEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phongBanIDSpinEdit.Location = new System.Drawing.Point(2, 291);
            this.phongBanIDSpinEdit.Margin = new System.Windows.Forms.Padding(2);
            this.phongBanIDSpinEdit.MenuManager = this.ribbonControl;
            this.phongBanIDSpinEdit.Name = "phongBanIDSpinEdit";
            this.phongBanIDSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.phongBanIDSpinEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaPhongBan", "Mã phòng ban"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenPhongBan", "Tên phòng ban")});
            this.phongBanIDSpinEdit.Properties.DataSource = this.dvPhongBanBindingSource;
            this.phongBanIDSpinEdit.Properties.DisplayMember = "TenPhongBan";
            this.phongBanIDSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.phongBanIDSpinEdit.Properties.NullText = "-- Chọn phòng ban --";
            this.phongBanIDSpinEdit.Properties.ValueMember = "IDPhongBan";
            this.phongBanIDSpinEdit.Size = new System.Drawing.Size(489, 20);
            this.phongBanIDSpinEdit.TabIndex = 44;
            this.phongBanIDSpinEdit.Popup += new System.EventHandler(this.phongBanIDSpinEdit_Popup);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(2, 267);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(489, 20);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "Phòng ban và Hệ số lương";
            // 
            // XUC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.nvNhanVienGridControl);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "XUC_NhanVien";
            this.Size = new System.Drawing.Size(991, 526);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anGiangDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvChucDanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvDanhMucCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPhongBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvNhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlsPhongBan)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayNghiViecDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayNghiViecDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayLamViecDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayLamViecDateEdit.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhdateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhdateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNhanVienTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dienThoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trinhDoIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnhPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucDanhIDSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tGPCKKSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoChucDanhSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heSoLuongTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBanIDSpinEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.BindingSource dvPhongBanBindingSource;
        private AnGiangDataSet anGiangDataSet;
        private AnGiangDataSetTableAdapters.dvPhongBanTableAdapter dvPhongBanTableAdapter;
        private System.Windows.Forms.BindingSource trinhDoBindingSource;
        private AnGiangDataSetTableAdapters.TrinhDoTableAdapter trinhDoTableAdapter;
        private AnGiangDataSetTableAdapters.nvNhanVienTableAdapter nvNhanVienTableAdapter;
        private AnGiangDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem bbiCancel;
        private System.Windows.Forms.BindingSource nvChucDanhBindingSource;
        private AnGiangDataSetTableAdapters.nvChucDanhTableAdapter nvChucDanhTableAdapter;
        private System.Windows.Forms.BindingSource nvDanhMucCDBindingSource;
        private AnGiangDataSetTableAdapters.nvDanhMucCDTableAdapter nvDanhMucCDTableAdapter;
        public System.Windows.Forms.BindingSource nvNhanVienBindingSource;
        public DevExpress.XtraGrid.GridControl nvNhanVienGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa;
        private DevExpress.XtraGrid.Columns.GridColumn colPhongBanID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit rlsPhongBan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.DateEdit ngayNghiViecDateEdit;
        private DevExpress.XtraEditors.DateEdit ngayLamViecDateEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.DateEdit ngaySinhdateEdit;
        private DevExpress.XtraEditors.ComboBoxEdit gioiTinhSpinEdit;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit hoTenTextEdit;
        private DevExpress.XtraEditors.TextEdit maNhanVienTextEdit;
        private DevExpress.XtraEditors.TextEdit dienThoaiTextEdit;
        private DevExpress.XtraEditors.LookUpEdit trinhDoIDSpinEdit;
        private DevExpress.XtraEditors.PictureEdit HinhAnhPictureEdit;
        private DevExpress.XtraEditors.GridLookUpEdit chucDanhIDSpinEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIDChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colTenChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayCapNhat;
        private DevExpress.XtraGrid.Columns.GridColumn colDaXoa1;
        private DevExpress.XtraGrid.Columns.GridColumn colDanhMucCDID;
        private DevExpress.XtraEditors.SpinEdit tGPCKKSpinEdit;
        private DevExpress.XtraEditors.SpinEdit heSoChucDanhSpinEdit;
        private DevExpress.XtraEditors.SpinEdit heSoLuongTextEdit;
        private DevExpress.XtraEditors.TextEdit ghiChuTextEdit;
        private DevExpress.XtraEditors.LookUpEdit phongBanIDSpinEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
