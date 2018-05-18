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

namespace AnGiang.Layout.DanhMuc
{
    public partial class frmChuyenMon : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenMon()
        {
            InitializeComponent();
        }

        private void frmChuyenMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.dvChuyenMon' table. You can move, or remove it, as needed.
            this.dvChuyenMonTableAdapter.Fill(this.anGiangDataSet.dvChuyenMon);

        }
    }
}