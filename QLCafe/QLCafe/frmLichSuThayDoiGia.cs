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

namespace QLCafe
{
    public partial class frmLichSuThayDoiGia : DevExpress.XtraEditors.XtraForm
    {
        public frmLichSuThayDoiGia()
        {
            InitializeComponent();
        }

        private void frmLichSuTruyCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_DonViTinh' table. You can move, or remove it, as needed.
            this.cF_DonViTinhTableAdapter.Fill(this.quanlycafeDataSet.CF_DonViTinh);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_HangHoa' table. You can move, or remove it, as needed.
            this.cF_HangHoaTableAdapter.Fill(this.quanlycafeDataSet.CF_HangHoa);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_NguoiDung' table. You can move, or remove it, as needed.
            this.cF_NguoiDungTableAdapter.Fill(this.quanlycafeDataSet.CF_NguoiDung);
            // TODO: This line of code loads data into the 'quanlycafeDataSet.CF_LichSuThayDoiGia' table. You can move, or remove it, as needed.
            this.cF_LichSuThayDoiGiaTableAdapter.Fill(this.quanlycafeDataSet.CF_LichSuThayDoiGia);

        }
    }
}