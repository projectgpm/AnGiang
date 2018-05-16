namespace QLCafe
{
    partial class frmLichSuThayDoiGia
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cFLichSuThayDoiGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.gvDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDNguoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMaHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colGiaCu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaMoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayThayDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btXoavaDaXoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cFHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemLookUpEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cF_LichSuThayDoiGiaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_LichSuThayDoiGiaTableAdapter();
            this.cF_NguoiDungTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter();
            this.cF_HangHoaTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_HangHoaTableAdapter();
            this.cF_DonViTinhTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_DonViTinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFLichSuThayDoiGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFDonViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cFLichSuThayDoiGiaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gvDonViTinh;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btXoavaDaXoa,
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2,
            this.repositoryItemLookUpEdit3,
            this.repositoryItemLookUpEdit4});
            this.gridControl1.Size = new System.Drawing.Size(625, 419);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDonViTinh});
            // 
            // cFLichSuThayDoiGiaBindingSource
            // 
            this.cFLichSuThayDoiGiaBindingSource.DataMember = "CF_LichSuThayDoiGia";
            this.cFLichSuThayDoiGiaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvDonViTinh
            // 
            this.gvDonViTinh.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDonViTinh.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colIDNguoiDung,
            this.colMaHang,
            this.colTenHang,
            this.colIDDVT,
            this.colGiaCu,
            this.colGiaMoi,
            this.colNgayThayDoi});
            this.gvDonViTinh.GridControl = this.gridControl1;
            this.gvDonViTinh.Name = "gvDonViTinh";
            this.gvDonViTinh.NewItemRowText = "Nhấp chuột vào đây để thêm mới";
            this.gvDonViTinh.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDonViTinh.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvDonViTinh.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvDonViTinh.OptionsBehavior.Editable = false;
            this.gvDonViTinh.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace;
            this.gvDonViTinh.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.gvDonViTinh.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gvDonViTinh.OptionsFind.AlwaysVisible = true;
            this.gvDonViTinh.OptionsFind.FindNullPrompt = "Nhập hai dấu \" để tìm chính xác vd: \"abcd\"";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIDNguoiDung
            // 
            this.colIDNguoiDung.Caption = "Tên Người Dùng";
            this.colIDNguoiDung.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colIDNguoiDung.FieldName = "IDNguoiDung";
            this.colIDNguoiDung.Name = "colIDNguoiDung";
            this.colIDNguoiDung.Visible = true;
            this.colIDNguoiDung.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.cFNguoiDungBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "TenNguoiDung";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "ID";
            // 
            // cFNguoiDungBindingSource
            // 
            this.cFNguoiDungBindingSource.DataMember = "CF_NguoiDung";
            this.cFNguoiDungBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colMaHang
            // 
            this.colMaHang.Caption = "Mã Hàng";
            this.colMaHang.FieldName = "MaHang";
            this.colMaHang.Name = "colMaHang";
            this.colMaHang.Visible = true;
            this.colMaHang.VisibleIndex = 1;
            // 
            // colTenHang
            // 
            this.colTenHang.FieldName = "TenHang";
            this.colTenHang.Name = "colTenHang";
            this.colTenHang.Visible = true;
            this.colTenHang.VisibleIndex = 2;
            // 
            // colIDDVT
            // 
            this.colIDDVT.Caption = "Tên Hàng";
            this.colIDDVT.ColumnEdit = this.repositoryItemLookUpEdit4;
            this.colIDDVT.FieldName = "IDDVT";
            this.colIDDVT.Name = "colIDDVT";
            this.colIDDVT.Visible = true;
            this.colIDDVT.VisibleIndex = 3;
            // 
            // repositoryItemLookUpEdit4
            // 
            this.repositoryItemLookUpEdit4.AutoHeight = false;
            this.repositoryItemLookUpEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit4.DataSource = this.cFDonViTinhBindingSource;
            this.repositoryItemLookUpEdit4.DisplayMember = "TenDonViTinh";
            this.repositoryItemLookUpEdit4.Name = "repositoryItemLookUpEdit4";
            this.repositoryItemLookUpEdit4.ValueMember = "ID";
            // 
            // cFDonViTinhBindingSource
            // 
            this.cFDonViTinhBindingSource.DataMember = "CF_DonViTinh";
            this.cFDonViTinhBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // colGiaCu
            // 
            this.colGiaCu.Caption = "Giá Củ";
            this.colGiaCu.FieldName = "GiaCu";
            this.colGiaCu.Name = "colGiaCu";
            this.colGiaCu.Visible = true;
            this.colGiaCu.VisibleIndex = 4;
            // 
            // colGiaMoi
            // 
            this.colGiaMoi.Caption = "Giá Mới";
            this.colGiaMoi.FieldName = "GiaMoi";
            this.colGiaMoi.Name = "colGiaMoi";
            this.colGiaMoi.Visible = true;
            this.colGiaMoi.VisibleIndex = 5;
            // 
            // colNgayThayDoi
            // 
            this.colNgayThayDoi.Caption = "Ngày Thay Đổi";
            this.colNgayThayDoi.FieldName = "NgayThayDoi";
            this.colNgayThayDoi.Name = "colNgayThayDoi";
            this.colNgayThayDoi.Visible = true;
            this.colNgayThayDoi.VisibleIndex = 6;
            // 
            // btXoavaDaXoa
            // 
            this.btXoavaDaXoa.AutoHeight = false;
            this.btXoavaDaXoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Xóa", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Delete", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.Delete), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "Xóa", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Active", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, "Apply", new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "Hủy/Kích hoạt dữ liệu", null, null, true)});
            this.btXoavaDaXoa.Name = "btXoavaDaXoa";
            this.btXoavaDaXoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.DataSource = this.cFHangHoaBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "MaHangHoa";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "ID";
            // 
            // cFHangHoaBindingSource
            // 
            this.cFHangHoaBindingSource.DataMember = "CF_HangHoa";
            this.cFHangHoaBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // repositoryItemLookUpEdit3
            // 
            this.repositoryItemLookUpEdit3.AutoHeight = false;
            this.repositoryItemLookUpEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit3.DataSource = this.cFHangHoaBindingSource;
            this.repositoryItemLookUpEdit3.DisplayMember = "TenHangHoa";
            this.repositoryItemLookUpEdit3.Name = "repositoryItemLookUpEdit3";
            this.repositoryItemLookUpEdit3.ValueMember = "ID";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.gridControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82353F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 425);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // cF_LichSuThayDoiGiaTableAdapter
            // 
            this.cF_LichSuThayDoiGiaTableAdapter.ClearBeforeFill = true;
            // 
            // cF_NguoiDungTableAdapter
            // 
            this.cF_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // cF_HangHoaTableAdapter
            // 
            this.cF_HangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // cF_DonViTinhTableAdapter
            // 
            this.cF_DonViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // frmLichSuThayDoiGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmLichSuThayDoiGia";
            this.Text = "Lịch Sử Thay Đổi Giá";
            this.Load += new System.EventHandler(this.frmLichSuTruyCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFLichSuThayDoiGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFDonViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btXoavaDaXoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDonViTinh;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btXoavaDaXoa;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource cFLichSuThayDoiGiaBindingSource;
        private quanlycafeDataSetTableAdapters.CF_LichSuThayDoiGiaTableAdapter cF_LichSuThayDoiGiaTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colIDNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHang;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaCu;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaMoi;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayThayDoi;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource cFNguoiDungBindingSource;
        private quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter cF_NguoiDungTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource cFHangHoaBindingSource;
        private quanlycafeDataSetTableAdapters.CF_HangHoaTableAdapter cF_HangHoaTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit4;
        private System.Windows.Forms.BindingSource cFDonViTinhBindingSource;
        private quanlycafeDataSetTableAdapters.CF_DonViTinhTableAdapter cF_DonViTinhTableAdapter;
    }
}