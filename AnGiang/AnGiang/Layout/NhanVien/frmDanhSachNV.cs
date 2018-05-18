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

namespace AnGiang.Layout.NhanVien
{
    public partial class frmDanhSachNV : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachNV()
        {
            InitializeComponent();
        }

        private void nvNhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nvNhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.anGiangDataSet);

        }

        private void frmDanhSachNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.dvPhongBan' table. You can move, or remove it, as needed.
            this.dvPhongBanTableAdapter.Fill(this.anGiangDataSet.dvPhongBan);
            // TODO: This line of code loads data into the 'anGiangDataSet.TrinhDo' table. You can move, or remove it, as needed.
            this.trinhDoTableAdapter.Fill(this.anGiangDataSet.TrinhDo);
            // TODO: This line of code loads data into the 'anGiangDataSet.nvNhanVien' table. You can move, or remove it, as needed.
            this.nvNhanVienTableAdapter.Fill(this.anGiangDataSet.nvNhanVien);

        }
    }
}