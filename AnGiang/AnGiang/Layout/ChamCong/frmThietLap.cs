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

namespace AnGiang.Layout.ChamCong
{
    public partial class frmThietLap : DevExpress.XtraEditors.XtraForm
    {
        public frmThietLap()
        {
            InitializeComponent();
        }

        private void tlDinhMucBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tlDinhMucBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.anGiangDataSet);

        }

        private void frmThietLap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.tlDinhMuc' table. You can move, or remove it, as needed.
            this.tlDinhMucTableAdapter.Fill(this.anGiangDataSet.tlDinhMuc);

        }
    }
}