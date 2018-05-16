namespace QLCafe
{
    partial class frmQLBangKe
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
            this.qlbangke = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.document1Tile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbangke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).BeginInit();
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
            this.qlbangke});
            this.windowsUIView1.TileContainerProperties.ShowCaption = false;
            this.windowsUIView1.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.document1Tile});
            this.windowsUIView1.ContentContainerActionCustomization += new DevExpress.XtraBars.Docking2010.Views.WindowsUI.ContentContainerActionCustomizationEventHandler(this.windowsUIView1_ContentContainerActionCustomization);
            this.windowsUIView1.QueryControl += new DevExpress.XtraBars.Docking2010.Views.QueryControlEventHandler(this.windowsUIView1_QueryControl);
            // 
            // splitGroup1
            // 
            this.splitGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.qlbangke});
            this.splitGroup1.Name = "splitGroup1";
            // 
            // qlbangke
            // 
            this.qlbangke.Caption = "Quản Lý Bảng Kê";
            this.qlbangke.ControlName = "qlbangke";
            // 
            // document1Tile
            // 
            this.document1Tile.Document = this.qlbangke;
            this.document1Tile.Name = "document1Tile";
            // 
            // frmQLBangKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 472);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmQLBangKe";
            this.Text = "Quản Lý Bảng Kê";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmQLBangKe_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlbangke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1Tile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView1;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document qlbangke;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile document1Tile;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.SplitGroup splitGroup1;
    }
}