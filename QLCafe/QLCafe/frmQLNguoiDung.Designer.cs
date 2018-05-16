namespace QLCafe
{
    partial class frmQLNguoiDung
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
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.splitGroup1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.SplitGroup(this.components);
            this.qlnguoidung = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.lichsuthaydoigia = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document1Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.tile1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnguoidung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichsuthaydoigia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.View = this.windowsUIView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView1});
            // 
            // windowsUIView1
            // 
            this.windowsUIView1.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.windowsUIView1.Appearance.Options.UseBackColor = true;
            this.windowsUIView1.AppearanceActionsBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.windowsUIView1.AppearanceActionsBar.Options.UseBackColor = true;
            this.windowsUIView1.AppearanceActionsBarButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.windowsUIView1.AppearanceActionsBarButton.Options.UseBackColor = true;
            this.windowsUIView1.AppearanceCaption.BackColor = System.Drawing.Color.DarkSlateGray;
            this.windowsUIView1.AppearanceCaption.Options.UseBackColor = true;
            this.windowsUIView1.AppearanceSearchPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.windowsUIView1.AppearanceSearchPanel.Options.UseBackColor = true;
            this.windowsUIView1.AppearanceSplashScreen.BackColor = System.Drawing.Color.DarkSlateGray;
            this.windowsUIView1.AppearanceSplashScreen.Options.UseBackColor = true;
            this.windowsUIView1.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.splitGroup1});
            this.windowsUIView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.qlnguoidung,
            this.lichsuthaydoigia});
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document1Tile,
            this.tile1});
            this.windowsUIView1.ContentContainerActionCustomization += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.ContentContainerActionCustomizationEventHandler(this.windowsUIView1_ContentContainerActionCustomization);
            this.windowsUIView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            // 
            // splitGroup1
            // 
            this.splitGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.qlnguoidung,
            this.lichsuthaydoigia});
            this.splitGroup1.Name = "splitGroup1";
            // 
            // qlnguoidung
            // 
            this.qlnguoidung.Caption = "Người Dùng";
            this.qlnguoidung.ControlName = "qlnguoidung";
            // 
            // lichsuthaydoigia
            // 
            this.lichsuthaydoigia.Caption = "Lịch Sử Thay Đổi Giá";
            this.lichsuthaydoigia.ControlName = "lichsuthaydoigia";
            // 
            // document1Tile
            // 
            this.document1Tile.Document = this.qlnguoidung;
            this.document1Tile.Name = "document1Tile";
            // 
            // tile1
            // 
            this.tile1.Document = this.lichsuthaydoigia;
            this.tile1.Name = "tile1";
            // 
            // frmQLNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 558);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmQLNguoiDung";
            this.Text = "Quản Lý Người Dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmQLNguoiDung_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlnguoidung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichsuthaydoigia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document1Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document qlnguoidung;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.SplitGroup splitGroup1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document lichsuthaydoigia;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile tile1;
    }
}