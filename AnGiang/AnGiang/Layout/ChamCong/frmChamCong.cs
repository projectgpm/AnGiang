using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using AnGiang.Layout.GPMController;

namespace AnGiang.Layout.ChamCong
{
    public partial class frmChamCong : DevExpress.XtraEditors.XtraForm
    {
        public frmChamCong()
        {
            InitializeComponent();
            XUC_ChamCong uc = new XUC_ChamCong();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void frmChamCong_Load(object sender, EventArgs e)
        {
           
        }
    }
}