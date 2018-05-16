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
using QLCafe.DAO;

namespace QLCafe
{
    public partial class frmChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public frmChiNhanh()
        {
            InitializeComponent();
            cF_ChiNhanhTableAdapter1.Fill(quanlycafeDataSet1.CF_ChiNhanh);
            txtTenQuan.Text = quanlycafeDataSet1.CF_ChiNhanh.FindByID(0).TenChiNhanh;
            txtDiaChi.Text = quanlycafeDataSet1.CF_ChiNhanh.FindByID(0).DiaChi;
            txtSoDT.Text = quanlycafeDataSet1.CF_ChiNhanh.FindByID(0).DienThoai;          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkUp = DataProvider.Instance.ExecuteNoneQuery("rp_UpdateChiNhanh @id , @TenChiNhanh , @DienThoai , @DiaChi", new object[] { 0, txtTenQuan.Text, txtSoDT.Text, txtDiaChi.Text  });
            if (checkUp > 0)
            {
                XtraMessageBox.Show("Cập nhật thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (checkUp == -1) { XtraMessageBox.Show("Cập nhật thất bại!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }


    }
}