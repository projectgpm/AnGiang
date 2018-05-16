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
    public partial class frmQLDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public frmQLDanhMuc()
        {
            InitializeComponent();
            //load việt sub hệ thống
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
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        #endregion

        //dùng để gọi các form trong menu lên
        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            switch(e.Document.ControlName)
            {
                case "donvitinh":
                    e.Control = new frmDonViTinh();
                    break;
                case "banggia":
                    e.Control = new frmBangGia();
                    break;
                case "quanlykhuvuc":
                    e.Control = new frmKhuVuc();
                    break;
                case "quanlyban":
                    e.Control = new frmBan();
                    break;
                case "nhomhanghoa":
                    e.Control = new frmNhomHangHoa();
                    break;
                case "hanghoa":
                    e.Control = new frmHangHoa();
                    break;
                case "quanlychi":                  
                    e.Control = new frmTongChi();
                    break;
                default:
                    break;
            }
        }

        //dùng để load lại database sau khi mở lại
        //private void windowsUIView1_QueryDocumentActions(object sender, DevExpress.XtraBars.Docking2010.Views.WindowsUI.QueryDocumentActionsEventArgs e)
        //{
        //    switch (e.Document.Control.Name)
        //    {
        //        case "frmKhuVuc":
        //            frmKhuVuc fkv = new frmKhuVuc();
        //            fkv.frmKhuVucload();
        //            break;
        //        case "frmBan":
        //            frmBan fb = new frmBan();
        //            fb.frmbanload();
        //            break;
        //        case "frmHangHoa":
        //            frmHangHoa fhh = new frmHangHoa();
        //            fhh.reload();
        //            break;
        //    }
            
        //}

        //xóa các nút trên navigation nếu không dùng đến
        //private void windowsUIView1_ContentContainerActionCustomization(object sender, DevExpress.XtraBars.Docking2010.Views.WindowsUI.ContentContainerActionCustomizationEventArgs e)
        //{
        //    if(e.ContentContainer.Caption=="Trở Lại")
        //    {
        //    }
        //    var exitItem = e.Actions.First((a) => a.Caption == "Exit");
        //    e.Remove(exitItem);           
        //}

        //nút thoát

        private void thoatTile_Click(object sender, DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileClickEventArgs e)
        {
            this.Close();
        }
    }
}