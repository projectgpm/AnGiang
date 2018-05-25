using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using AnGiang.Report;
using GPMLibrary;

namespace AnGiang.Layout.GPMController
{
    public partial class XUC_XemLuong : DevExpress.XtraEditors.XtraUserControl
    {

        private int _nam;
        public int nam
        {
            get { return _nam; }
            set { _nam = value; }
        }
        private int _thang;
        public int thang
        {
            get { return _thang; }
            set { _thang = value; }
        }
        private double _tongsotien;
        public double tongsotien
        {
            get { return _tongsotien; }
            set { _tongsotien = value; }
        }
        public XUC_XemLuong()
        {
            InitializeComponent();
        }
        public XUC_XemLuong(int nam,int thang,double tongsotien)
        {
            this.tongsotien = tongsotien;
            this.nam = nam;
            this.thang = thang;
        }

        private void XUC_XemLuong_Load(object sender, EventArgs e)
        {
           
        }
        
        
    }
}
