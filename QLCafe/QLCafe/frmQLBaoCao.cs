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
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Docking2010;

namespace QLCafe
{
    public partial class frmQLBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmQLBaoCao()
        {
            InitializeComponent();
            DocumentManagerLocalizer.Active = new MyDocumentManagerLocalizer();
        }

        #region Việt sub hệ thống
        class MyDocumentManagerLocalizer : DocumentManagerLocalizer
        {
            public override string GetLocalizedString(DocumentManagerStringId id)
            {
                switch (id)
                {
                    case DocumentManagerStringId.CommandExit:
                        return "Thoát";
                    case DocumentManagerStringId.CommandBack:
                        return "Trở Lại";
                    case DocumentManagerStringId.LoadingIndicatorCaption:
                        return "Đang Tải Dữ Liệu";
                    case DocumentManagerStringId.LoadingIndicatorDescription:
                        return "Vui lòng đợi một lát...";
                    case DocumentManagerStringId.CommandOverview:
                        return "Xem tổng quát";
                    case DocumentManagerStringId.CommandRotate:
                        return "Xoay";
                    case DocumentManagerStringId.CommandFlip:
                        return "Chia Đôi";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        #endregion

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
                    e.Control = new frmBaoCao();
        }

        private void windowsUIView1_ContentContainerActionCustomization(object sender, ContentContainerActionCustomizationEventArgs e)
        {
            try
            {
                var exitItem = e.Actions.First((a) => a.Caption == "Xem tổng quát");
                e.Remove(exitItem);
            }
            catch { }
        }

        private void frmQLBangKe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                string help = Application.StartupPath + "\\help.chm";
                Help.ShowHelp(this, help);
            }
        }
    }
}