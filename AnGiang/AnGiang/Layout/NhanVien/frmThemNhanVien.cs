using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace AnGiang.Layout.NhanVien
{
    public partial class frmThemNhanVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();

            //BindingList<Customer> dataSource = GetDataSource();
            //gridControl.DataSource = dataSource;
            //bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            //gridControl.ShowRibbonPrintPreview();
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'anGiangDataSet.nvNhanVien' table. You can move, or remove it, as needed.
          

        }
    }
}