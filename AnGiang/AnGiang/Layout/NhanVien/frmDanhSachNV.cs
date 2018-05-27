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
using DevExpress.XtraGrid;

namespace AnGiang.Layout.NhanVien
{
    public partial class frmDanhSachNV : DevExpress.XtraEditors.XtraForm
    {
        public frmDanhSachNV()
        {
            InitializeComponent();
           
        }

       

        private void frmDanhSachNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.dvPhongBan' table. You can move, or remove it, as needed.
            this.dvPhongBanTableAdapter.Fill(this.anGiangDataSet.dvPhongBan);
            // TODO: This line of code loads data into the 'anGiangDataSet.TrinhDo' table. You can move, or remove it, as needed.
            this.trinhDoTableAdapter.Fill(this.anGiangDataSet.TrinhDo);

            xuC_NhanVien1.nvNhanVienGridControl.Visible = false;
            gridControlNhanVien.DataSource = xuC_NhanVien1.nvNhanVienBindingSource;
            xuC_NhanVien1.nvNhanVienGridControl.ForceInitialize();
            gridControlNhanVien.ForceInitialize();
            flyoutPanel1.ShowPopup();
            flyoutPanel1.HidePopup();
        }

        private void gridControlNhanVien_DoubleClick(object sender, EventArgs e)
        {           
            flyoutPanel1.ShowPopup();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            flyoutPanel1.HidePopup();
        }

      
    }
}