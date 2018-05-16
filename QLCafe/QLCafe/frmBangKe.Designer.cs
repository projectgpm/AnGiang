namespace QLCafe
{
    partial class frmBangKe
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rbTheoThang = new System.Windows.Forms.RadioButton();
            this.rbTheoNam = new System.Windows.Forms.RadioButton();
            this.rbTuyChon = new System.Windows.Forms.RadioButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dateNgayBD = new DevExpress.XtraEditors.DateEdit();
            this.dateNgayKT = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btXemBKHH = new DevExpress.XtraEditors.SimpleButton();
            this.btXemBKKC = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbChonNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.cFNguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlycafeDataSet = new QLCafe.quanlycafeDataSet();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cF_NguoiDungTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.9774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0226F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 277);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(828, 60);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Tùy Chọn";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.rbTheoThang, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbTheoNam, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rbTuyChon, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(824, 38);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // rbTheoThang
            // 
            this.rbTheoThang.AutoSize = true;
            this.rbTheoThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTheoThang.Location = new System.Drawing.Point(277, 3);
            this.rbTheoThang.Name = "rbTheoThang";
            this.rbTheoThang.Size = new System.Drawing.Size(268, 32);
            this.rbTheoThang.TabIndex = 0;
            this.rbTheoThang.Text = "Theo Tháng";
            this.rbTheoThang.UseVisualStyleBackColor = true;
            this.rbTheoThang.CheckedChanged += new System.EventHandler(this.rbTheoThang_CheckedChanged);
            // 
            // rbTheoNam
            // 
            this.rbTheoNam.AutoSize = true;
            this.rbTheoNam.Checked = true;
            this.rbTheoNam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTheoNam.Location = new System.Drawing.Point(3, 3);
            this.rbTheoNam.Name = "rbTheoNam";
            this.rbTheoNam.Size = new System.Drawing.Size(268, 32);
            this.rbTheoNam.TabIndex = 0;
            this.rbTheoNam.TabStop = true;
            this.rbTheoNam.Text = "Theo Năm";
            this.rbTheoNam.UseVisualStyleBackColor = true;
            this.rbTheoNam.CheckedChanged += new System.EventHandler(this.rbTheoNam_CheckedChanged);
            // 
            // rbTuyChon
            // 
            this.rbTuyChon.AutoSize = true;
            this.rbTuyChon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTuyChon.Location = new System.Drawing.Point(551, 3);
            this.rbTuyChon.Name = "rbTuyChon";
            this.rbTuyChon.Size = new System.Drawing.Size(270, 32);
            this.rbTuyChon.TabIndex = 0;
            this.rbTuyChon.Text = "Tùy Chọn";
            this.rbTuyChon.UseVisualStyleBackColor = true;
            this.rbTuyChon.CheckedChanged += new System.EventHandler(this.rbTuyChon_CheckedChanged);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.tableLayoutPanel3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 69);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(828, 54);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Chọn Ngày Tháng";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tableLayoutPanel3.Controls.Add(this.dateNgayBD, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateNgayKT, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelControl2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(824, 32);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // dateNgayBD
            // 
            this.dateNgayBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateNgayBD.EditValue = null;
            this.dateNgayBD.Enabled = false;
            this.dateNgayBD.Location = new System.Drawing.Point(94, 3);
            this.dateNgayBD.Name = "dateNgayBD";
            this.dateNgayBD.Properties.Appearance.Options.UseFont = true;
            this.dateNgayBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBD.Size = new System.Drawing.Size(314, 20);
            this.dateNgayBD.TabIndex = 0;
            // 
            // dateNgayKT
            // 
            this.dateNgayKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateNgayKT.EditValue = null;
            this.dateNgayKT.Enabled = false;
            this.dateNgayKT.Location = new System.Drawing.Point(505, 3);
            this.dateNgayKT.Name = "dateNgayKT";
            this.dateNgayKT.Properties.Appearance.Options.UseFont = true;
            this.dateNgayKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayKT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayKT.Size = new System.Drawing.Size(316, 20);
            this.dateNgayKT.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(414, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.ShowLineShadow = false;
            this.labelControl1.Size = new System.Drawing.Size(85, 26);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Đến ngày:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 26);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Từ ngày:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btXemBKHH, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btXemBKKC, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 165);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(828, 109);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btXemBKHH
            // 
            this.btXemBKHH.Appearance.Options.UseFont = true;
            this.btXemBKHH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btXemBKHH.Location = new System.Drawing.Point(3, 3);
            this.btXemBKHH.Name = "btXemBKHH";
            this.btXemBKHH.Size = new System.Drawing.Size(408, 103);
            this.btXemBKHH.TabIndex = 2;
            this.btXemBKHH.Text = "Xem Bảng Kê Hàng Hóa";
            this.btXemBKHH.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btXemBKKC
            // 
            this.btXemBKKC.Appearance.Options.UseFont = true;
            this.btXemBKKC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btXemBKKC.Location = new System.Drawing.Point(417, 3);
            this.btXemBKKC.Name = "btXemBKKC";
            this.btXemBKKC.Size = new System.Drawing.Size(408, 103);
            this.btXemBKKC.TabIndex = 3;
            this.btXemBKKC.Text = "Xem Bảng Kê Kết Ca";
            this.btXemBKKC.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 679F));
            this.tableLayoutPanel5.Controls.Add(this.cbChonNhanVien, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelControl3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(828, 30);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // cbChonNhanVien
            // 
            this.cbChonNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbChonNhanVien.Location = new System.Drawing.Point(152, 3);
            this.cbChonNhanVien.Name = "cbChonNhanVien";
            this.cbChonNhanVien.Properties.Appearance.Options.UseFont = true;
            this.cbChonNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbChonNhanVien.Properties.DataSource = this.cFNguoiDungBindingSource;
            this.cbChonNhanVien.Properties.DisplayMember = "TenNguoiDung";
            this.cbChonNhanVien.Properties.KeyMember = "ID";
            this.cbChonNhanVien.Properties.NullText = "";
            this.cbChonNhanVien.Properties.ShowFooter = false;
            this.cbChonNhanVien.Properties.ShowHeader = false;
            this.cbChonNhanVien.Properties.ShowLines = false;
            this.cbChonNhanVien.Properties.ValueMember = "ID";
            this.cbChonNhanVien.Size = new System.Drawing.Size(673, 20);
            this.cbChonNhanVien.TabIndex = 0;
            // 
            // cFNguoiDungBindingSource
            // 
            this.cFNguoiDungBindingSource.DataMember = "CF_NguoiDung";
            this.cFNguoiDungBindingSource.DataSource = this.quanlycafeDataSet;
            // 
            // quanlycafeDataSet
            // 
            this.quanlycafeDataSet.DataSetName = "quanlycafeDataSet";
            this.quanlycafeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(3, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 24);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Chọn Nhân Viên:";
            // 
            // cF_NguoiDungTableAdapter
            // 
            this.cF_NguoiDungTableAdapter.ClearBeforeFill = true;
            // 
            // frmBangKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBangKe";
            this.Text = "Bảng Kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmBKBanHang_In_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayKT.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbChonNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cFNguoiDungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlycafeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton rbTheoThang;
        private System.Windows.Forms.RadioButton rbTheoNam;
        private System.Windows.Forms.RadioButton rbTuyChon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.DateEdit dateNgayBD;
        private DevExpress.XtraEditors.DateEdit dateNgayKT;
        private DevExpress.XtraEditors.SimpleButton btXemBKHH;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.SimpleButton btXemBKKC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraEditors.LookUpEdit cbChonNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private quanlycafeDataSet quanlycafeDataSet;
        private System.Windows.Forms.BindingSource cFNguoiDungBindingSource;
        private quanlycafeDataSetTableAdapters.CF_NguoiDungTableAdapter cF_NguoiDungTableAdapter;

    }
}