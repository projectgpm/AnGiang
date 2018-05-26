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

namespace AnGiang
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }

        private void txtTGCKK_EditValueChanged(object sender, EventArgs e)
        {
            if((int)txtTGCKK.EditValue<0)
            {
                txtTGCKK.EditValue = 0;
            }
        }

        private void txtTGCKK_Leave(object sender, EventArgs e)
        {

        }
    }
}