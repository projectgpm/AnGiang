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

namespace AnGiang.Layout.Luong
{
    public partial class frmDinhMucTienLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmDinhMucTienLuong()
        {
            InitializeComponent();
        }

        private void lgLuongBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lgLuongBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.anGiangDataSet);

        }

        private void frmDinhMucTienLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.lgLuong' table. You can move, or remove it, as needed.
            this.lgLuongTableAdapter.Fill(this.anGiangDataSet.lgLuong);
            //GPMLibrary.Tooler.Tools.
        }
    }
}