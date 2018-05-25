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

namespace AnGiang.Layout.NhanVien
{
    public partial class frmThemNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhanVien()
        {
            InitializeComponent();
            XUC_NhanVien uc = new XUC_NhanVien();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }
    }
}