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
using DevExpress.Utils;

namespace ApplicationGPM.GPMController
{
    [ToolboxItem(true)]
    public partial class MyFlyoutControl : FlyoutPanel
    {
        protected override FlyoutPanelToolForm CreateToolFormCore(Control owner, FlyoutPanel content, FlyoutPanelOptions options)
        {
            MyFlyoutPanelToolForm f = new MyFlyoutPanelToolForm(owner, content, options);
            return f;
        }

    }

    public class MyFlyoutPanelToolForm : FlyoutPanelToolForm
    {

        const int WS_EX_TOOLWINDOW = 0x00000080;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public MyFlyoutPanelToolForm(Control owner, FlyoutPanel panel, FlyoutPanelOptions options)
            : base(owner, panel, options)
        {

        }

        protected override bool IsTopMost
        {
            get
            {
                return true;
            }
        }
    }
}
