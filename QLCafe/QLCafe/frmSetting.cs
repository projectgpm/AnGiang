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
using QLCafe.Properties;

namespace QLCafe
{
    public partial class frmSetting : DevExpress.XtraEditors.XtraForm
    {
        public bool checkSuccess = false;
        public frmSetting()
        {
            InitializeComponent();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            txtsizeBan.Value = Settings.Default.SizeBan;
            txtsizeHangHoa.Value = Settings.Default.SizeHangHoa;
            txtChieuDaiB.Value = Settings.Default.SizeTenKhuVuc;
            txtChieuDaiHH.Value = Settings.Default.SizeTenNhomHang;
            cbkieubanhienthi.SelectedIndex = Settings.Default.StyleItemBan == TileItemSize.Wide ? 0 : 1;
            cbkieuhanghoahienthi.SelectedIndex = Settings.Default.StyleItemHangHoa == TileItemSize.Wide ? 0 : 1;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            checkSuccess = false;
            this.Close();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            Settings.Default.SizeBan = (int)txtsizeBan.Value;
            Settings.Default.SizeHangHoa = (int)txtsizeHangHoa.Value;
            Settings.Default.SizeTenKhuVuc = (int)txtChieuDaiB.Value;
            Settings.Default.SizeTenNhomHang = (int)txtChieuDaiHH.Value;         
            Settings.Default.Save();
            checkSuccess = true;
            this.Close();
        }

        private void cbkieubanhienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbkieubanhienthi.SelectedIndex==0)
            {
                Settings.Default.StyleItemBan = TileItemSize.Wide;
            }else
            {
                Settings.Default.StyleItemBan = TileItemSize.Default;
            }
            Settings.Default.Save();
        }

        private void cbkieuhanghoahienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbkieuhanghoahienthi.SelectedIndex == 0)
            {
                Settings.Default.StyleItemHangHoa = TileItemSize.Wide;
            }
            else
            {
                Settings.Default.StyleItemHangHoa = TileItemSize.Default;
            }
            Settings.Default.Save();
        }
    }
}