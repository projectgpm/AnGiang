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
using QLCafe.DAO;

namespace QLCafe
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            txtValue.EditValue += btn.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtValue.EditValue != null || !string.IsNullOrEmpty(txtValue.EditValue.ToString()))
            txtValue.EditValue = txtValue.Text.Remove(txtValue.Text.Length - 1);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            setValue_WithOut = (int)txtValue.EditValue;
            this.Close();
        }

        public static int setValue_WithOut;

        private void txtValue_KeyDown(object sender, KeyEventArgs e)
        {
            DataProvider.Instance.checkKeyPad(e);
        }
        
    }
}