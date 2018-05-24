namespace AnGiang.Layout.NhanVien
{
    partial class frmThemNhanVien
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
            this.xuC_NhanVien1 = new AnGiang.Layout.GPMController.XUC_NhanVien();
            this.SuspendLayout();
            // 
            // xuC_NhanVien1
            // 
            this.xuC_NhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuC_NhanVien1.Location = new System.Drawing.Point(0, 0);
            this.xuC_NhanVien1.Name = "xuC_NhanVien1";
            this.xuC_NhanVien1.Size = new System.Drawing.Size(1223, 732);
            this.xuC_NhanVien1.TabIndex = 0;
            // 
            // frmThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 732);
            this.Controls.Add(this.xuC_NhanVien1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThemNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GPMController.XUC_NhanVien xuC_NhanVien1;

    }
}