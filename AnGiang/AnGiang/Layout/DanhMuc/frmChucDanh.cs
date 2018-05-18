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
    public partial class frmChucDanh : DevExpress.XtraEditors.XtraForm
    {
        public frmChucDanh()
        {
            InitializeComponent();
        }

        private void frmChucDanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.nvChucDanh' table. You can move, or remove it, as needed.
            this.nvChucDanhTableAdapter.Fill(this.anGiangDataSet.nvChucDanh);

        }
    }
}