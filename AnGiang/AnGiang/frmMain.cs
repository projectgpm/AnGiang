using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnGiang
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             XtraForm1 fr = new XtraForm1();
            
            if (!GPMLibrary.Validation.Vals.ActiveChildForm(fr.Name, this))
            {
                fr.MdiParent = this;
                fr.WindowState = FormWindowState.Maximized;
                fr.Show();
            }
        }
    }
}
