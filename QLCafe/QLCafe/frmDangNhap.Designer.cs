namespace QLCafe
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckluu = new DevExpress.XtraEditors.CheckEdit();
            this.ckeHienMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.txtTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.linkDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLienHe = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnBanHang = new DevExpress.XtraEditors.SimpleButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnQuanTri = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.cF_BanTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_BanTableAdapter();
            this.cF_DatBanTableAdapter = new QLCafe.quanlycafeDataSetTableAdapters.CF_DatBanTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckluu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeHienMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckluu);
            this.groupBox1.Controls.Add(this.ckeHienMatKhau);
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.linkDoiMatKhau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // ckluu
            // 
            this.ckluu.Location = new System.Drawing.Point(327, 28);
            this.ckluu.Name = "ckluu";
            this.ckluu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckluu.Properties.Appearance.Options.UseFont = true;
            this.ckluu.Properties.Caption = "Lưu";
            this.ckluu.Size = new System.Drawing.Size(45, 22);
            this.ckluu.TabIndex = 4;
            this.ckluu.CheckedChanged += new System.EventHandler(this.ckluu_CheckedChanged);
            // 
            // ckeHienMatKhau
            // 
            this.ckeHienMatKhau.Location = new System.Drawing.Point(327, 57);
            this.ckeHienMatKhau.Name = "ckeHienMatKhau";
            this.ckeHienMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckeHienMatKhau.Properties.Appearance.Options.UseFont = true;
            this.ckeHienMatKhau.Properties.Caption = "Xem";
            this.ckeHienMatKhau.Size = new System.Drawing.Size(55, 22);
            this.ckeHienMatKhau.TabIndex = 4;
            this.ckeHienMatKhau.CheckedChanged += new System.EventHandler(this.ckeHienMatKhau_CheckedChanged);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.EditValue = "";
            this.txtTenDangNhap.Location = new System.Drawing.Point(129, 28);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(192, 22);
            this.txtTenDangNhap.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "";
            this.txtMatKhau.Location = new System.Drawing.Point(129, 57);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(192, 22);
            this.txtMatKhau.TabIndex = 3;
            // 
            // linkDoiMatKhau
            // 
            this.linkDoiMatKhau.AutoSize = true;
            this.linkDoiMatKhau.Location = new System.Drawing.Point(126, 82);
            this.linkDoiMatKhau.Name = "linkDoiMatKhau";
            this.linkDoiMatKhau.Size = new System.Drawing.Size(95, 18);
            this.linkDoiMatKhau.TabIndex = 2;
            this.linkDoiMatKhau.TabStop = true;
            this.linkDoiMatKhau.Text = "Đổi mật khẩu";
            this.linkDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLienHe_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG";
            // 
            // linkLienHe
            // 
            this.linkLienHe.AutoSize = true;
            this.linkLienHe.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLienHe.Location = new System.Drawing.Point(162, 239);
            this.linkLienHe.Name = "linkLienHe";
            this.linkLienHe.Size = new System.Drawing.Size(182, 18);
            this.linkLienHe.TabIndex = 5;
            this.linkLienHe.TabStop = true;
            this.linkLienHe.Text = "CÔNG TY GPM VIỆT NAM";
            this.linkLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLienHe_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mọi chi tiết xin liên hệ :";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Blue";
            // 
            // btnBanHang
            // 
            this.btnBanHang.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Appearance.Options.UseFont = true;
            this.btnBanHang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.Image")));
            this.btnBanHang.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnBanHang.Location = new System.Drawing.Point(158, 182);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(106, 30);
            this.btnBanHang.TabIndex = 6;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnQuanTri
            // 
            this.btnQuanTri.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanTri.Appearance.Options.UseFont = true;
            this.btnQuanTri.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanTri.Image")));
            this.btnQuanTri.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnQuanTri.Location = new System.Drawing.Point(33, 182);
            this.btnQuanTri.Name = "btnQuanTri";
            this.btnQuanTri.Size = new System.Drawing.Size(106, 30);
            this.btnQuanTri.TabIndex = 6;
            this.btnQuanTri.Text = "Quản Trị";
            this.btnQuanTri.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThoat.Location = new System.Drawing.Point(284, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 30);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cF_BanTableAdapter
            // 
            this.cF_BanTableAdapter.ClearBeforeFill = true;
            // 
            // cF_DatBanTableAdapter
            // 
            this.cF_DatBanTableAdapter.ClearBeforeFill = true;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnBanHang;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 271);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuanTri);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.linkLienHe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(424, 310);
            this.MinimumSize = new System.Drawing.Size(424, 310);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckluu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckeHienMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkDoiMatKhau;
        private System.Windows.Forms.LinkLabel linkLienHe;
        private System.Windows.Forms.Label label5;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnBanHang;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtTenDangNhap;
        private DevExpress.XtraEditors.CheckEdit ckeHienMatKhau;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraEditors.CheckEdit ckluu;
        private DevExpress.XtraEditors.SimpleButton btnQuanTri;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private quanlycafeDataSetTableAdapters.CF_BanTableAdapter cF_BanTableAdapter;
        private quanlycafeDataSetTableAdapters.CF_DatBanTableAdapter cF_DatBanTableAdapter;


    }
}

