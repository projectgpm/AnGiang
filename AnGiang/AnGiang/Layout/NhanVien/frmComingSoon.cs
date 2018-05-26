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
    public partial class frmComingSoon : DevExpress.XtraEditors.XtraForm
    {
        public frmComingSoon()
        {
            InitializeComponent();
            XtraMessageBox.Show("Chức năng này đang được phát triển", "Công ty GPM Việt Nam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}