namespace AnGiang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.C = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.navBarControlLeft = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navDanhSachNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navAddNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navKyHieu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBangChamCong = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navDinhMuc = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.barXemGio = new DevExpress.XtraBars.BarStaticItem();
            this.barXemNgay = new DevExpress.XtraBars.BarStaticItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItem4,
            this.barSubItem5,
            this.barButtonItem2,
            this.C,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barXemGio,
            this.barXemNgay,
            this.skinBarSubItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Danh mục";
            this.barSubItem1.Id = 1;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.C),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Phòng ban";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // C
            // 
            this.C.Caption = "Chức danh";
            this.C.Id = 7;
            this.C.Name = "C";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Chức vụ";
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Chuyên môn";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Chứng từ";
            this.barSubItem2.Id = 2;
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Tổng hợp";
            this.barSubItem3.Id = 3;
            this.barSubItem3.Name = "barSubItem3";
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "Báo cáo";
            this.barSubItem4.Id = 4;
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barSubItem5
            // 
            this.barSubItem5.Caption = "Hệ thống";
            this.barSubItem5.Id = 5;
            this.barSubItem5.Name = "barSubItem5";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barXemNgay),
            new DevExpress.XtraBars.LinkPersistInfo(this.barXemGio)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1367, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 502);
            this.barDockControlBottom.Size = new System.Drawing.Size(1367, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 480);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1367, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 480);
            // 
            // barButtonItem1
            // 
            //this.barButtonItem1.Caption = "barButtonItem1";
            //this.barButtonItem1.Id = 0;
            //this.barButtonItem1.Name = "barButtonItem1";
            //this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // navBarControlLeft
            // 
            this.navBarControlLeft.ActiveGroup = this.navBarGroup1;
            this.navBarControlLeft.BackColor = System.Drawing.Color.White;
            this.navBarControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControlLeft.Font = new System.Drawing.Font("Tahoma", 11F);
            this.navBarControlLeft.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControlLeft.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navDanhSachNhanVien,
            this.navAddNhanVien,
            this.navKyHieu,
            this.navBangChamCong,
            this.navDinhMuc,
            this.navBarItem1});
            this.navBarControlLeft.Location = new System.Drawing.Point(0, 22);
            this.navBarControlLeft.Name = "navBarControlLeft";
            this.navBarControlLeft.OptionsNavPane.ExpandedWidth = 242;
            this.navBarControlLeft.Size = new System.Drawing.Size(242, 480);
            this.navBarControlLeft.TabIndex = 4;
            this.navBarControlLeft.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Nhân sự";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDanhSachNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navAddNhanVien)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navDanhSachNhanVien
            // 
            this.navDanhSachNhanVien.Caption = "Danh sách nhân viên";
            this.navDanhSachNhanVien.ImageUri.Uri = "ListBullets";
            this.navDanhSachNhanVien.Name = "navDanhSachNhanVien";
            // 
            // navAddNhanVien
            // 
            this.navAddNhanVien.Caption = "Thêm nhân viên";
            this.navAddNhanVien.ImageUri.Uri = "Add";
            this.navAddNhanVien.Name = "navAddNhanVien";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Chấm công";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navKyHieu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBangChamCong),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDinhMuc)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navKyHieu
            // 
            this.navKyHieu.Caption = "Ký hiệu chấm công";
            this.navKyHieu.ImageUri.Uri = "CustomizeGrid";
            this.navKyHieu.Name = "navKyHieu";
            // 
            // navBangChamCong
            // 
            this.navBangChamCong.Caption = "Bảng chấm công";
            this.navBangChamCong.ImageUri.Uri = "Today";
            this.navBangChamCong.Name = "navBangChamCong";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Tính lương";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Lập báo cáo nhân sự";
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navDinhMuc
            // 
            this.navDinhMuc.Caption = "Thiết lập định mức";
            this.navDinhMuc.ImageUri.Uri = "CustomizeGrid";
            this.navDinhMuc.Name = "navDinhMuc";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "navBarItem1";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // barXemGio
            // 
            this.barXemGio.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barXemGio.Caption = "Xem giờ";
            this.barXemGio.Glyph = ((System.Drawing.Image)(resources.GetObject("barXemGio.Glyph")));
            this.barXemGio.Id = 10;
            this.barXemGio.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barXemGio.LargeGlyph")));
            this.barXemGio.Name = "barXemGio";
            this.barXemGio.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barXemGio.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barXemNgay
            // 
            this.barXemNgay.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barXemNgay.Caption = "Xem ngày";
            this.barXemNgay.Glyph = ((System.Drawing.Image)(resources.GetObject("barXemNgay.Glyph")));
            this.barXemNgay.Id = 11;
            this.barXemNgay.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barXemNgay.LargeGlyph")));
            this.barXemNgay.Name = "barXemNgay";
            this.barXemNgay.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barXemNgay.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Giao diện";
            this.skinBarSubItem1.Id = 12;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 529);
            this.Controls.Add(this.navBarControlLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " GPM Việt Nam :: Phần mềm quản lý chấm công nhân viên v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControlLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraNavBar.NavBarControl navBarControlLeft;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem C;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraNavBar.NavBarItem navDanhSachNhanVien;
        private DevExpress.XtraNavBar.NavBarItem navAddNhanVien;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navKyHieu;
        private DevExpress.XtraNavBar.NavBarItem navBangChamCong;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navDinhMuc;
        private DevExpress.XtraBars.BarStaticItem barXemNgay;
        private DevExpress.XtraBars.BarStaticItem barXemGio;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;



    }
}

