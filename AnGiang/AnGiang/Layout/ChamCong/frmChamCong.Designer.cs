namespace AnGiang.Layout.ChamCong
{
    partial class frmChamCong
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
            this.xuC_ChamCong1 = new AnGiang.Layout.GPMController.XUC_ChamCong();
            this.SuspendLayout();
            // 
            // xuC_ChamCong1
            // 
            this.xuC_ChamCong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuC_ChamCong1.Location = new System.Drawing.Point(0, 0);
            this.xuC_ChamCong1.Name = "xuC_ChamCong1";
            this.xuC_ChamCong1.Size = new System.Drawing.Size(696, 420);
            this.xuC_ChamCong1.TabIndex = 0;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 420);
            this.Controls.Add(this.xuC_ChamCong1);
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.ResumeLayout(false);

        }

        #endregion

        private GPMController.XUC_ChamCong xuC_ChamCong1;
    }
}