using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using GPMLibrary;

namespace AnGiang.Report
{
    public partial class r_BaoCaoLuongXiNghiep : DevExpress.XtraReports.UI.XtraReport
    {
        public r_BaoCaoLuongXiNghiep()
        {
            InitializeComponent();
        }

        private int i = 1;
        private List<string> listCheck = new List<string>();
        private void xrTableCell51_TextChanged(object sender, EventArgs e)
        {
            XRTableCell c = sender as XRTableCell;
            if (!string.IsNullOrEmpty(c.Text) && !listCheck.Contains(c.Text))
            {
                listCheck.Add(Tooler.Tools.ToRoman(i));
                string temp = Tooler.Tools.ToRoman(i);
                i++;
                c.Text = temp;
            }
           
        }

    }
}
