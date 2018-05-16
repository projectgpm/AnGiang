using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLCafe.BUS;
using QLCafe.DTO;
using DevExpress.SpreadsheetSource.Implementation;
using QLCafe.DAO;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;
using QLCafe.Properties;
using DevExpress.XtraPrinting.Localization;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using QLCafe.Report;
using System.Diagnostics;
using System.Data;
using DevExpress.LookAndFeel;
using System.Configuration;

namespace QLCafe
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        TabNavigationPage allPage = new TabNavigationPage();
        TabNavigationPage banAllPage = new TabNavigationPage();


       

        public frmBanHang()
        {
            InitializeComponent();
       }
            


        #region Sự kiện khác
        private void timer1_Tick(object sender, EventArgs e)
        {
            statusTime.Caption = "Giờ: " + DateTime.Now.ToLongTimeString();
        }

        private void flyoutPanel1_Hidden(object sender, DevExpress.Utils.FlyoutPanelEventArgs e)
        {
            btnNhap.Enabled = true;
            txtHoten.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtThoiGian.Text = string.Empty;
        }
        #endregion


        #region Việt sub hệ thống
        class MyPreviewLocalizer : PreviewLocalizer
        {
            public override string GetLocalizedString(PreviewStringId id)
            {
                switch (id)
                {
                    case PreviewStringId.WaitForm_Caption:
                        return "Vui lòng đợi một lát";
                    case PreviewStringId.Msg_CreatingDocument:
                        return "Đang tải hóa đơn ...";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        public class MyLocalizer : Localizer
        {
            public override string GetLocalizedString(StringId id)
            {
                switch (id)
                {
                    case StringId.InvalidValueText:
                        return "Giá trị không hợp lệ";
                    case StringId.XtraMessageBoxYesButtonText:
                        return "Có";
                    case StringId.XtraMessageBoxCancelButtonText:
                        return "Trở lại";
                    case StringId.XtraMessageBoxOkButtonText:
                        return "Đồng ý";
                    case StringId.XtraMessageBoxNoButtonText:
                        return "Không";
                    case StringId.OK:
                        return "Thực hiện";
                    case StringId.Cancel:
                        return "Hủy bỏ";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        #endregion


        #region Xử lý Load dữ liệu
        void loadAll()
        {

            allPage.Controls.Clear();
            banAllPage.Controls.Clear();
            if (cF_BanTableAdapter.GetData() != null && cF_HangHoaTableAdapter1.GetData() != null)
            {
                LoadAllBanInGroup();
                //LoadDanhSachBan();
                loadAllInGroup();
                LoadDanhSachHangHoa();
            }
            else
            {
                XtraMessageBox.Show("Hiện chưa có dữ liệu để load được bán hàng!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        void loadControlFirst()
        {
            PreviewLocalizer.Active = new MyPreviewLocalizer();
            Localizer.Active = new MyLocalizer();

           
            
            //tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            //tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);

            allPage.Caption = "Tất cả";
            allPage.Tag = "-1";
            allPage.Name = "AllHangHhoa";
            banAllPage.Caption = "Tất cả";
            banAllPage.Tag = "-1";
            banAllPage.Name = "AllBan";
            loadAll();
            this.cF_BanTableAdapter.Fill(this.quanlycafeDataSet.CF_Ban);
            this.cF_NguoiDungTableAdapter.Fill(this.quanlycafeDataSet.CF_NguoiDung);
            this.cF_LichSuThaoTacTableAdapter.Fill(this.quanlycafeDataSet.CF_LichSuThaoTac);
            ButtonEnable("FalseAll");
            statusNgay.Caption = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            statusTenDangNhap.Caption = "Nhân viên: " + frmDangNhap.NguoiDung.Tennguoidung;
            this.cF_ChiNhanhTableAdapter1.Fill(this.quanlycafeDataSet.CF_ChiNhanh);
            barThongTinQuan.Caption = cF_ChiNhanhTableAdapter1.GetData().FindByID(0).TenChiNhanh + " - " + cF_ChiNhanhTableAdapter1.GetData().FindByID(0).DiaChi;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            //if (frmDangNhap.NguoiDung == null)
            //{
            //    using (frmDangNhap fdangnhap = new frmDangNhap())
            //    {
                    //fdangnhap.ShowDialog();
                    loadControlFirst();
            //    }
            //}
           
        }

        public void LoadHoaDon()
        {
            gridView1.ViewCaption = "DANH SÁCH MÓN ĂN " + tenBan.ToUpper();
            loadMotCaiBan(iDBan, btntemp);
            cF_LichSuThaoTacTableAdapter.Fill(quanlycafeDataSet.CF_LichSuThaoTac);
            iDHoaDon = DataProvider.Instance.ExecuteScalar("SELECT ID FROM CF_HoaDon WHERE TrangThai=0 and IDBan=" + iDBan);
            if (iDHoaDon == null) {
                ButtonEnable("FalseAll");
                btnNhap.Text = "Đặt";
                btnNhap.Enabled = true;
                lbtongtien1.Text = "0";
                lbphuthu1.Text = "0"; //phụ thu
                lbgiamgia1.Text = "0";
                lbkhachcantra1.Text = "0";
                lbphuthuUnit.Text = "đ";
                lbgiamgiaUnit.Text = "%";
                if (bantemp.Trangthai == 4)
                {
                    btnThanhToan.Enabled = true;
                    btnThanhToan.Text = "Hoàn Tác";
                }
                else
                {
                    btnThanhToan.Enabled = false;
                    btnThanhToan.Text = "Thanh Toán";
                }
                this.cF_ChiTietHoaDon_TempTableAdapter.FillByIDHoaDon(this.quanlycafeDataSet.CF_ChiTietHoaDon_Temp, 0);
            } else 
            {
                DTO_HoaDon hd = new DTO_HoaDon(cF_HoaDonTableAdapter1.GetData().FindByID(int.Parse(iDHoaDon.ToString())));
                lbtongtien1.Text = hd.TongTien.ToString("N0");
                //phụ thu
                if (hd.Tiengiamgia >= 0 && hd.Tiengiamgia <= 100)
                { 
                    lbphuthu1.Text = hd.Tiengiamgia.ToString();
                    lbphuthuUnit.Text = "%";
                } else
                {
                    lbphuthu1.Text = hd.Tiengiamgia.ToString("N0");
                    lbphuthuUnit.Text = "đ";
                }
                if (hd.GiamGia >= 0 && hd.GiamGia <= 100)
                { 
                    lbgiamgia1.Text = hd.GiamGia.ToString();
                    lbgiamgiaUnit.Text = "%";
                }else
                {
                    lbgiamgia1.Text = hd.GiamGia.ToString("N0");
                    lbgiamgiaUnit.Text = "đ";
                }
                lbkhachcantra1.Text = hd.KhachCanTra.ToString("N0");

                if (bantemp.Maban.Contains("+"))
                { 
                    ButtonEnable("TrueGhep");
                    KiemTraNutGhep = true;
                }
                else if (tabPaneXemAll.SelectedPage == tabNavigationPageDanhSachHangHoa)
                {
                    ButtonEnable("FalseAll");
                }else
                { 
                    ButtonEnable("TrueAll");
                    KiemTraNutGhep = false;
                }
                this.cF_ChiTietHoaDon_TempTableAdapter.FillByIDHoaDon(this.quanlycafeDataSet.CF_ChiTietHoaDon_Temp, int.Parse(iDHoaDon.ToString()));
                
            }           
           
        }

        #region xử lý load danh sách bàn
        public void loadLocBan(int TrangThai)
        {
                NavigationPageBase tab = xtraTabControlDanhSachBan.Pages[xtraTabControlDanhSachBan.SelectedPageIndex];
                if (tab.Controls.Count > 0)
                {
                    TileControl flayout = tab.Controls[0] as TileControl;
                    foreach (TileGroup tig in flayout.Groups)
                    foreach (TileItem item in tig.Items)
                    {
                        DTO_BAN ban = item.Tag as DTO_BAN;
                        if (ban.Trangthai == 4)
                            loadMotCaiBan(ban.Id, item);

                        if (TrangThai < 0)
                        {
                            item.Visible = true;
                        }
                        else if (TrangThai == 5)
                        {
                            if (!item.Checked)
                                item.Visible = false;
                        }
                        else if (ban.Trangthai == TrangThai)
                        {
                            item.Visible = true;
                        }
                        else
                        {
                            item.Visible = false;
                        }
                    }
                }
           
        }
        public void LoadAllBanInGroup()
        {
            DataTable dt = DAO_KhuVuc.DanhSachKhuVuc(0);
            if (dt == null || dt.Rows.Count <= 0)
                return;
            TileControl layout = new TileControl();
            layout.Orientation = System.Windows.Forms.Orientation.Vertical;
            layout.Dock = DockStyle.Fill;
            layout.AllowDrag = true;
            layout.AllowSelectedItem = false;
            layout.AllowSelectedItemBorder = false;
            layout.ItemCheckMode = TileItemCheckMode.Single;
            layout.IndentBetweenItems = 5;
            layout.ShowGroupText = true;
            layout.ShowText = false;
            layout.AllowSelectedItemBorder = false;
            layout.AllowDragTilesBetweenGroups = false;
            layout.AppearanceItem.Normal.BorderColor = Color.DarkGray;
            layout.Margin = new System.Windows.Forms.Padding(0);
            layout.Padding = new System.Windows.Forms.Padding(5);
            layout.ItemPadding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            layout.ItemSize = Settings.Default.SizeBan;
            xtraTabControlDanhSachBan.Controls.Add(banAllPage);
            xtraTabControlDanhSachBan.Pages.Add(banAllPage);

            foreach (DataRow dr in dt.Rows)
            {
                TileGroup tig = new TileGroup();
                tig.Name = "khuvuctilegroup" + dr["id"].ToString();
                tig.Text = dr["TenKhuVuc"].ToString();
                tig.Tag = dr["id"].ToString();
                layout.Groups.Add(tig);
            }

            foreach (TileGroup tg in layout.Groups)
            {
                DataTable db = new DataTable();
                if (tg.Tag != null)
                    db = DAO_BAN.Instance.DanhSachBan(tg.Tag.ToString());
                if (db != null && db.Rows.Count > 0)
                {
                    foreach (DataRow item in db.Rows)
                    {

                        TileItem ti = new TileItem();
                        ti.ItemSize = Settings.Default.StyleItemBan;
                        ti.AllowHtmlText = DefaultBoolean.False;
                        ti.RightItemClick += btn_Click;
                        ti.ItemClick += btn_Click;
                        ti.ItemDoubleClick += btn_ItemDoubleClick;
                        ti.AllowSelectAnimation = true;
                        ti.AppearanceItem.Normal.BorderColor = Color.DarkGray;
                        ti.AppearanceItem.Normal.BackColor = Color.White;
                        DTO_BAN btemp = new DTO_BAN(item);
                        ti.Tag = btemp;
                        loadbanTrangthai(ti);
                        tg.Items.Add(ti);
                    }
                }
            }
            banAllPage.Controls.Add(layout);

        }
        public void LoadDanhSachBan()
        {
            DataTable dt = BUS_KhuVuc.DanhSachBanTheoKhuVuc(0);
            if (dt.Rows.Count < 0)
            {
                XtraMessageBox.Show("Danh sách bàn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataRow dr in dt.Rows)
            {
                TabNavigationPage tabNavigationPageKhuVuc = new TabNavigationPage();
                tabNavigationPageKhuVuc.Caption = dr["TenKhuVuc"].ToString().Length > Settings.Default.SizeTenKhuVuc ? dr["TenKhuVuc"].ToString().Substring(0, Settings.Default.SizeTenKhuVuc) + ".." : dr["TenKhuVuc"].ToString();
                tabNavigationPageKhuVuc.Tag = dr["ID"].ToString();
                tabNavigationPageKhuVuc.Name = "khuvuc" + dr["ID"].ToString();
                xtraTabControlDanhSachBan.Controls.Add(tabNavigationPageKhuVuc);
                xtraTabControlDanhSachBan.Pages.Add(tabNavigationPageKhuVuc);
            }

            foreach (TabNavigationPage tab in xtraTabControlDanhSachBan.Pages)
            {
                int idKV = int.Parse(tab.Tag.ToString());
                TileControl layout = new TileControl();
                layout.Orientation = System.Windows.Forms.Orientation.Vertical;
                layout.Dock = DockStyle.Fill;
                layout.AllowDrag = false;
                layout.AllowSelectedItem = false;
                layout.AllowSelectedItemBorder = false;
                layout.ItemCheckMode = TileItemCheckMode.Single;
                layout.IndentBetweenItems = 5;
                layout.ShowGroupText = false;
                layout.ShowText = false;
                layout.AllowSelectedItemBorder = false;
                layout.AllowDragTilesBetweenGroups = false;
                layout.AppearanceItem.Selected.BorderColor = Color.DarkSlateGray;
                layout.Margin = new System.Windows.Forms.Padding(0);
                layout.Padding = new System.Windows.Forms.Padding(5);
                layout.ItemPadding = new System.Windows.Forms.Padding(8, 0, 8, 8);
                layout.ItemSize = Settings.Default.SizeBan;
                LoadBanKhuVucTrangThai(idKV, layout);
                tab.Controls.Add(layout);
            }
            if (xtraTabControlDanhSachBan.Pages.Count > 0)
                xtraTabControlDanhSachBan.SelectedPageIndex = 0;

        }
        public void LoadBanKhuVucTrangThai(int IDKhuVuc, TileControl layout)
        {
            DataTable db = new DataTable();
            if (IDKhuVuc > 0)
                db = DAO_BAN.Instance.DanhSachBan(IDKhuVuc.ToString());
            else
                return;
                if (db.Rows.Count > 0)
                {
                    TileGroup tig = new TileGroup();
                    foreach (DataRow item in db.Rows)
                    {
                        TileItem ti = new TileItem();
                        ti.RightItemClick += btn_Click;
                        ti.ItemClick += btn_Click;
                        ti.ItemDoubleClick += btn_ItemDoubleClick;
                        ti.AllowSelectAnimation = true;
                        ti.ItemSize = Settings.Default.StyleItemBan;
                        ti.AppearanceItem.Normal.BackColor = Color.White;
                        ti.AppearanceItem.Normal.BorderColor = Color.Transparent;
                        ti.AllowHtmlText = DefaultBoolean.False;
                        DTO_BAN btemp = new DTO_BAN(item);
                        ti.Tag = btemp;
                        loadbanTrangthai(ti);
                        tig.Items.Add(ti);
                    }
                    layout.Groups.Add(tig);
            }
        }
        public void loadMotCaiBan(int IDBan, TileItem btnsp)
        {
            DTO_BAN ban1 = new DTO_BAN(cF_BanTableAdapter.GetData().FindByID(IDBan));
            DTO_BAN ban2 = btnsp.Tag as DTO_BAN;
            btnsp.Tag = ban1;
            bantemp = ban1;
            if (ban1.Trangthai != ban2.Trangthai || checkChangedValueBan)
            { 
                loadbanTrangthai(btnsp);
                checkChangedValueBan = false;
            }
        }
        void loadbanTrangthai(TileItem btnsp)
        {

            DTO_BAN ban1 = btnsp.Tag as DTO_BAN;
            if (btnsp.Elements != null && btnsp.Elements.Count > 0)
            {
                btnsp.Elements.Clear();
            }
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            tileItemElement1.Appearance.Normal.Options.UseBackColor = true;
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Height = 30;
            tileItemElement1.StretchHorizontal = true;
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement1.Appearance.Normal.ForeColor = Color.White;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            tileItemElement2.Appearance.Normal.FontSizeDelta = 1;
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Height = 95;
            tileItemElement2.Appearance.Normal.ForeColor = Color.DarkBlue;
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            tileItemElement3.Appearance.Normal.FontSizeDelta = 1;
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Appearance.Normal.ForeColor = Color.DarkRed;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            tileItemElement1.Text = "Trống";
            tileItemElement2.Text = "";
            tileItemElement3.Text = "Tổng: 0 đ";
            tileItemElement4.Image = global::QLCafe.Properties.Resources.BanTrong_48;
            DataTable tbnew = new DataTable();
            switch (ban1.Trangthai)
            {
                case 0:                   
                    tileItemElement2.Text = ban1.Tenban;
                    btnsp.Enabled = true;
                    tileItemElement1.Appearance.Normal.BackColor = Color.DarkGray;
                    btnsp.Elements.Add(tileItemElement1);
                    btnsp.Elements.Add(tileItemElement2);
                    btnsp.Elements.Add(tileItemElement3);
                    btnsp.Elements.Add(tileItemElement4);
                    break;
                case 1:
                    DTO_DatBan datban = new DTO_DatBan(cF_DatBanTableAdapter.GetData(ban1.Id)[0]);
                    // Access the controller that manages tooltips for all controls:
                    ToolTipController defaultTooltipController = DevExpress.Utils.ToolTipController.DefaultController;
                    // Create and customize a SuperToolTip:
                    SuperToolTip sTooltip = new SuperToolTip();
                    SuperToolTipSetupArgs args = new SuperToolTipSetupArgs();
                    args.Title.Text = "Thông tin chi tiết: ";
                    args.Contents.Text = "- Họ tên: " + datban.TenKhachHang + "\n- ĐT: " + datban.DienThoai;
                    args.ShowFooterSeparator = true;
                    //..or enable this feature for all tooltips:
                    //defaultTooltipController.AllowHtmlText = true;

                    // Respond to clicking hyperlinks in tooltips:
                    defaultTooltipController.HyperlinkClick += defaultTooltipController_HyperlinkClick;
                    args.Footer.Text = ban1.Tenban;
                    sTooltip.Setup(args);
                    // Enable HTML Text Formatting for the created SuperToolTip:
                    sTooltip.AllowHtmlText = DefaultBoolean.True;
                   
                    btnsp.SuperTip = sTooltip;
                    tileItemElement1.Appearance.Normal.BackColor = Color.DarkGoldenrod;
                    tileItemElement1.Text="Đặt lúc: "+ datban.GioDat.ToString("h:mm tt");
                    tileItemElement2.Text = ban1.Tenban ;
                    btnsp.Elements.Add(tileItemElement1);
                    btnsp.Elements.Add(tileItemElement2);
                    btnsp.Elements.Add(tileItemElement3);
                    btnsp.Elements.Add(tileItemElement4);
                    break;
                case 2:                  
                        tbnew = cF_HoaDonTableAdapter1.GetData().Where(q => q.IDBan == ban1.Id && q.TrangThai == 0).CopyToDataTable();
                        if (tbnew != null && tbnew.Rows.Count > 0)
                        { 
                            DTO_HoaDon hd = new DTO_HoaDon(tbnew.Rows[0]);
                            tileItemElement1.Text = "Giờ vào: " + hd.GioVao.ToString("hh:ss tt");
                            tileItemElement3.Text = "Tổng: " + hd.KhachCanTra.ToString("N0")+" đ";
                        }
                                     
                    if (ban1.Maban.Contains("+"))
                    {
                        tileItemElement2.Text = ban1.Tenban + " (+)";
                    }
                    else
                    {
                        tileItemElement2.Text = ban1.Tenban;
                    }
                    tileItemElement4.Image = global::QLCafe.Properties.Resources.BanCo_48;
                    tileItemElement1.Appearance.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(166)))), ((int)(((byte)(223)))));
                    btnsp.Elements.Add(tileItemElement1);
                    btnsp.Elements.Add(tileItemElement2);
                    btnsp.Elements.Add(tileItemElement3);
                    btnsp.Elements.Add(tileItemElement4);
                    break;
                case 3:
                    tileItemElement1.Appearance.Normal.BackColor =Color.DarkCyan;
                    DTO_BAN banduocghep = new DTO_BAN(cF_BanTableAdapter.GetData().FindByID(int.Parse(ban1.Maban)));
                    btnsp.Enabled = false;
                    tileItemElement1.Text ="Ghép với " + banduocghep.Tenban;
                    tileItemElement4.Image = global::QLCafe.Properties.Resources.BanCo_48;
                    tileItemElement2.Text = ban1.Tenban;                                      
                    btnsp.Elements.Add(tileItemElement1);
                    btnsp.Elements.Add(tileItemElement2);
                    btnsp.Elements.Add(tileItemElement3);
                    btnsp.Elements.Add(tileItemElement4);
                    break;
                case 4:
                    tileItemElement1.Appearance.Normal.BackColor = Color.DarkRed;
                    tileItemElement2.Text = ban1.Tenban;
                       tbnew  = cF_HoaDonTableAdapter1.GetData();
                        if (tbnew != null && tbnew.Rows.Count > 0)
                        {
                            DTO_HoaDon hd = new DTO_HoaDon(tbnew.Rows[tbnew.Rows.Count-1]);
                            tileItemElement1.Text = "Thanh toán: " + ban1.NgayCapNhat.ToString("h:mm tt");
                            tileItemElement3.Text = "Tổng: " + hd.TongTien.ToString("N0")+" đ";
                        }
                    btnsp.Elements.Add(tileItemElement1);
                    btnsp.Elements.Add(tileItemElement2);
                    btnsp.Elements.Add(tileItemElement3);
                    btnsp.Elements.Add(tileItemElement4);
                    break;
            }
        }
       
        #endregion

        #region xử lý load danh sách hàng hóa

        public void LoadDanhSachHangHoa()
        {
            DataTable dt = BUS_NhomHang.DanhSachNhomHang();
            foreach (DataRow dr in dt.Rows)
            {
                TabNavigationPage tabNavigationPageNhomHang = new TabNavigationPage();
                tabNavigationPageNhomHang.Caption = dr["TenNhom"].ToString().Length > Settings.Default.SizeTenNhomHang ? dr["TenNhom"].ToString().Substring(0, Settings.Default.SizeTenNhomHang) + ".." : dr["TenNhom"].ToString();
                tabNavigationPageNhomHang.Tag = dr["ID"].ToString();
                tabNavigationPageNhomHang.Name = "nhh" + dr["ID"].ToString();
                xtraTabControlDanhSachHangHoa.Controls.Add(tabNavigationPageNhomHang);
                xtraTabControlDanhSachHangHoa.Pages.Add(tabNavigationPageNhomHang);
            }

            foreach (TabNavigationPage tab in xtraTabControlDanhSachHangHoa.Pages)
            {
                TileControl layout = new TileControl();
                layout.Orientation = System.Windows.Forms.Orientation.Vertical;
                layout.Dock = DockStyle.Fill;
                layout.AllowDrag = false;
                layout.AllowSelectedItem = false;
                layout.AutoSelectFocusedItem = false;
                layout.IndentBetweenItems = 3;
                layout.AllowSelectedItemBorder = false;
                layout.AllowDragTilesBetweenGroups = false;
                layout.ItemCheckMode = TileItemCheckMode.None;
                layout.ShowText = false;
                layout.ShowGroupText = false;
                layout.AppearanceItem.Selected.BorderColor = Color.DarkBlue;
                layout.Margin = new System.Windows.Forms.Padding(0);
                layout.Padding = new System.Windows.Forms.Padding(0);
                layout.ItemSize = Settings.Default.SizeHangHoa;

                loadHangHoaNhom(tab.Tag.ToString(), layout);
                tab.Controls.Add(layout);
            }
            if (xtraTabControlDanhSachHangHoa.Pages.Count > 0)
                xtraTabControlDanhSachHangHoa.SelectedPageIndex = 0;
        }

        public void loadTimKiemHangHoa(string TenHangHoa)
        {
            DataTable db = null;
            NavigationPageBase tab = xtraTabControlDanhSachHangHoa.Pages[xtraTabControlDanhSachHangHoa.SelectedPageIndex];
            TileControl flayout = tab.Controls[0] as TileControl;
            flayout.Groups.Clear();
            string IDNhomHangHoa = tab.Tag.ToString();
            TileGroup tig = new TileGroup();
            tig.Text = "Tìm kiếm: " + TenHangHoa;
            if (TenHangHoa != string.Empty)
            {
                db = cF_HangHoaTableAdapter1.GetDataByTenHangHoa(TenHangHoa);
            }
            else
            {
                if (int.Parse(IDNhomHangHoa) > 0)
                { db = DAO_HangHoa.DanhSachHangHoa(IDNhomHangHoa); }
                else
                {
                    tab.Controls.Clear();
                    loadAllInGroup();
                    return;
                }
            }

            if (db != null && db.Rows.Count > 0)
            {
                foreach (DataRow dr in db.Rows)
                {
                    TileItem ti = new TileItem();
                    ti.ItemSize = Settings.Default.StyleItemHangHoa;
                    //ti.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Default;
                    ti.TextAlignment = TileItemContentAlignment.MiddleCenter;
                    //ti.ImageAlignment = TileItemContentAlignment.TopLeft;
                    ti.AppearanceItem.Normal.BackColor = Color.White;
                    ti.AllowSelectAnimation = true;
                    ti.RightItemClick += RightItemClick;
                    ti.ItemClick += ItemClick;
                    ti.ItemDoubleClick += ItemClick;
                    ti.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ti.AllowHtmlText = DefaultBoolean.False;
                    ti.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    DTO_HangHoa bthh = new DTO_HangHoa(dr);
                    ti.Tag = bthh;
                    ti.AppearanceItem.Normal.ForeColor = Color.Black;
                    ti.Text = dr["TenHangHoa"].ToString();
                    tig.Items.Add(ti);
                }
                flayout.Groups.Add(tig);
            }
        }

        public void loadHangHoaNhom(string IDNhomHang, TileControl layout)
        {
            DataTable db = BUS_HangHoa.DSHangHoa(IDNhomHang);
            if (db.Rows.Count > 0)
            {
                TileGroup tig = new TileGroup();
                foreach (DataRow dr in db.Rows)
                {
                    TileItem ti = new TileItem();
                    ti.ItemSize = Settings.Default.StyleItemHangHoa;
                    //ti.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Default;
                    ti.TextAlignment = TileItemContentAlignment.MiddleCenter;
                   // ti.ImageAlignment = TileItemContentAlignment.TopLeft;
                    ti.AppearanceItem.Normal.BackColor = Color.White;
                    ti.RightItemClick += RightItemClick;
                    ti.ItemClick += ItemClick;
                    ti.ItemDoubleClick += ItemClick;
                    ti.AllowAnimation = true;
                    ti.AllowHtmlText = DefaultBoolean.False;
                    ti.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ti.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    DTO_HangHoa bthh = new DTO_HangHoa(dr);
                    ti.Tag = bthh;
                    ti.AppearanceItem.Normal.ForeColor = Color.Black;
                    ti.Text = dr["TenHangHoa"].ToString();
                    tig.Items.Add(ti);
                }
                layout.Groups.Add(tig);
            }
        }

        public void loadAllInGroup()
        {
            DataTable dt = BUS_NhomHang.DanhSachNhomHang();
            if (dt == null || dt.Rows.Count <= 0)
                return;
            TileControl layout = new TileControl();
            layout.Orientation = System.Windows.Forms.Orientation.Vertical;
            layout.Dock = DockStyle.Fill;
            layout.AllowDrag = false;
            layout.AllowSelectedItem = false;
            layout.AllowSelectedItemBorder = false;
            layout.AppearanceItem.Selected.BorderColor = Color.DarkBlue;
            layout.IndentBetweenItems = 3;
            layout.ItemCheckMode = TileItemCheckMode.None;
            layout.AllowDragTilesBetweenGroups = false;
            layout.ShowGroupText = true;                      
            layout.AppearanceGroupText.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            layout.AppearanceGroupText.ForeColor = Color.DodgerBlue;
            layout.Margin = new System.Windows.Forms.Padding(0);
            layout.Padding = new System.Windows.Forms.Padding(5);
            layout.ItemPadding = new System.Windows.Forms.Padding(0);
            layout.ItemSize = Settings.Default.SizeHangHoa;
            xtraTabControlDanhSachHangHoa.Controls.Add(allPage);
            xtraTabControlDanhSachHangHoa.Pages.Add(allPage);
            foreach (DataRow dr in dt.Rows)
            {
                TileGroup tig = new TileGroup();
                tig.Name = "nhhtilegroup" + dr["id"].ToString();
                tig.Text = dr["TenNhom"].ToString();
                tig.Tag = dr["id"].ToString();
                layout.Groups.Add(tig);
            }

            foreach (TileGroup tg in layout.Groups)
            {
                DataTable db = BUS_HangHoa.DSHangHoa(tg.Tag.ToString());
                foreach (DataRow dr in db.Rows)
                {
                    TileItem ti = new TileItem();
                    ti.ItemSize = Settings.Default.StyleItemHangHoa;
                    //ti.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Default;
                    //ti.ImageAlignment = TileItemContentAlignment.TopLeft;
                    //ti.AppearanceItem.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    ti.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ti.TextAlignment = TileItemContentAlignment.MiddleCenter;                  
                    ti.AppearanceItem.Normal.BackColor = Color.White;
                    ti.AllowSelectAnimation = true;
                    ti.RightItemClick += RightItemClick;
                    ti.ItemClick += ItemClick;
                    ti.ItemDoubleClick += ItemClick;
                    ti.AllowHtmlText = DefaultBoolean.False;
                    DTO_HangHoa bthh = new DTO_HangHoa(dr);
                    ti.Tag = bthh;
                    ti.AppearanceItem.Normal.ForeColor = Color.Black;
                    ti.Text = dr["TenHangHoa"].ToString();
                    tg.Items.Add(ti);

                }

            }
            allPage.Controls.Add(layout);

        }

        #endregion

        #endregion

        #region Xử lý sự kiện gird

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                string IDHangHoa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDHH).ToString();
                int SoLuongMoi = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSoLuong).ToString());
                DataProvider.Instance.ThayDoiSoLuong(0, iDHoaDon.ToString(), IDHangHoa, SoLuongMoi, frmDangNhap.NguoiDung);
                //loadMotCaiBan(iDBan, btntemp);
                LoadHoaDon();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi hệ thống: " + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }
       
        #endregion

        #region Xử lý sự kiện Click

        #region hiden
        private void lbgiamgia1_Click(object sender, EventArgs e)
        {
            if (iDHoaDon != null)
            {
                DTO_HoaDon hd = new DTO_HoaDon(cF_HoaDonTableAdapter1.GetData().FindByID(int.Parse(iDHoaDon.ToString())));
                txtGiamGia.Value = (int)hd.GiamGia;
                txtPhuThu.Value = hd.Tiengiamgia;
                lbtitleGiamGia.Text = tenBan + " - Giảm giá/Phụ phí";
                fpGiamGia.ShowPopup();
            }
        }
        private void lbphuthu1_Click(object sender, EventArgs e)
        {
            if (iDHoaDon != null)
            {
                DTO_HoaDon hd = new DTO_HoaDon(cF_HoaDonTableAdapter1.GetData().FindByID(int.Parse(iDHoaDon.ToString())));
                txtGiamGia.Value = (int)hd.GiamGia;
                txtPhuThu.Value = hd.Tiengiamgia;
                lbtitleGiamGia.Text = tenBan + " - Giảm giá/Phụ phí";
                fpGiamGia.ShowPopup();
            }
        }
        private void lbkhachcantra1_Click(object sender, EventArgs e)
        {
            if (iDHoaDon != null)
            {
                DTO_HoaDon hd = new DTO_HoaDon(cF_HoaDonTableAdapter1.GetData().FindByID(int.Parse(iDHoaDon.ToString())));
                lbtitleThanhToan.Text = bantemp.Tenban + " - Thanh toán";
                lbSoTienCanTra.Text = hd.KhachCanTra.ToString("N0");
                lbSoTienCanTra.Tag = hd.KhachCanTra;
                txtThoiLai.Value = (int)hd.TienThua;
                txtTienKhachDua.Value = (int)hd.KhachCanTra;
                fpThanhToan.ShowPopup();
            }
        }
        //dùng để mở tooltip
        void defaultTooltipController_HyperlinkClick(object sender, HyperlinkClickEventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = (e.Link);
            process.StartInfo.Verb = "open";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            try
            {
                process.Start();
            }
            catch { }
        }
        //thực hiện thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Text.Contains("Thanh Toán"))
            if (iDHoaDon != null)
            {
                DTO_HoaDon hd = new DTO_HoaDon(cF_HoaDonTableAdapter1.GetData().FindByID(int.Parse(iDHoaDon.ToString())));
                lbtitleThanhToan.Text = bantemp.Tenban + " - Thanh toán";
                lbSoTienCanTra.Text = hd.KhachCanTra.ToString("N0");
                lbSoTienCanTra.Tag = hd.KhachCanTra;
                txtThoiLai.Value = (int)hd.TienThua;
                txtTienKhachDua.Value = (int)hd.KhachCanTra;
                fpThanhToan.ShowPopup();
            }
            if (btnThanhToan.Text.Contains("Hoàn Tác"))
                if (bantemp.Trangthai == 4)
                {
                    DataProvider.Instance.HoanTac(iDBan);
                    btnThanhToan.Text = "Thanh Toán";
                    LoadHoaDon();
                }
                else
                {
                    XtraMessageBox.Show("Bạn không thể thực hiện thao tác hoàn lại ở bàn này", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }
        //hủy việc thanh toán
        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            fpThanhToan.HidePopup();
        }
        //hủy việc giảm giá
        private void btnHuyGiamGia_Click(object sender, EventArgs e)
        {
            fpGiamGia.HidePopup();
        }
        //thực hiện thanh toán
        private void btnXacNhanThanhToan_Click(object sender, EventArgs e)
        {
            if (iDHoaDon != null)
            {
                if (KiemTraNutGhep)
                {
                    btnGhep.PerformClick();
                }
                if (txtThoiLai.Value <= 0 && cbHinhThucThanhToan.EditValue == "Ghi nợ" || txtThoiLai.Value >= 0 && cbHinhThucThanhToan.EditValue != "Ghi nợ")
                    if (txtTienKhachDua.Value > 0)
                    {
                        DataProvider.Instance.ThanhToan(iDHoaDon.ToString(), iDBan.ToString(), cbHinhThucThanhToan.EditValue.ToString(), (float)txtTienKhachDua.Value, (float)txtThoiLai.Value, frmDangNhap.NguoiDung.Id);
                        loadLocBan(-1);
                        if (checkInHoaDon.Checked)
                        {
                            //XtraReport rp = new rpHoaDonBanHang1();
                            //rp.Parameters["ID"].Value = iDHoaDon.ToString();
                            //rp.Parameters["ID"].Visible = false;
                            //rp.Parameters["IDChiNhanh"].Value = frmDangNhap.NguoiDung.Idchinhanh;
                            //rp.Parameters["IDChiNhanh"].Visible = false;
                            //documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                            //rp.CreateDocument();
                            //ReportPrintTool print = new ReportPrintTool(rp);
                            //print.PrinterSettings.Copies = 2;
                            //print.Print();
                        }
                        LoadHoaDon();
                        fpThanhToan.HidePopup();
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa nhập số tiền để thanh toán!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else
            {
                XtraMessageBox.Show("Số tiền thồi bị sai xin hãy kiểm tra lại!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //thực hiện giảm giá
        private void btnXacNhanGiamGia_Click(object sender, EventArgs e)
        {
            if (iDHoaDon != null)
            {
                DataProvider.Instance.GiamGia(iDHoaDon.ToString(), (float)txtPhuThu.Value, (float)txtGiamGia.Value);
                LoadHoaDon();
                fpGiamGia.HidePopup();
            }
        }
        //Xem và in
        private void XemInHoaDon_Click(object sender, EventArgs e)
        {
            frmXemInLaiHoaDon fm = new frmXemInLaiHoaDon();
            fm.ShowDialog();
        }
        //sau khi thay đổi hình thức thanh toán thì sẽ thực hiện
        private void cbHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHinhThucThanhToan.EditValue != "Ghi nợ")
            {
                lbtienthoi.Text = "Số tiền thối lại:";
                txtThoiLai.Value = 0;
            }
            else
            {
                lbtienthoi.Text = "Số tiền nợ:";
                txtThoiLai.Value = -int.Parse(lbSoTienCanTra.Tag.ToString());
            }
        }
        //khi nhấn vào nút kết ca
        private void btnKetCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKetCa fr = new frmKetCa();
            fr.ShowDialog();
        }
        //thoát
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
       }
        //đóng đặt hàng
        private void btnHuyDat_Click(object sender, EventArgs e)
        {
            fpDatBan.HidePopup();
        }
        //chấp nhận đặt bàn
        private void btnXacThucDat_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text != string.Empty && txtSDT.Text != string.Empty)
            {
                DataProvider.Instance.ExecuteQuery("pr_DatBan @IDBan , @TenKhachHang , @DienThoai , @GioDat , @IDNhanVien", new object[] { iDBan, txtHoten.Text, txtSDT.Text, txtThoiGian.Text, frmDangNhap.NguoiDung.Id });
                LoadHoaDon();
                fpDatBan.HidePopup();
            }else
                XtraMessageBox.Show("Bạn chưa nhập Tên người đặt/Số điện thoại!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        //khi nhấn chuột phải vào món ăn
        public void RightItemClick(object sender, TileItemEventArgs e)
        {
            TileItem ti = (sender as TileItem);
            DTO_HangHoa hh = ti.Tag as DTO_HangHoa;
            if (iDBan != 0)
            {
                if (iDHoaDon != null)
                {
                    DataProvider.Instance.ThayDoiSoLuong(1, iDHoaDon.ToString(), hh.ID.ToString(), -1, frmDangNhap.NguoiDung);
                    checkChangedValueBan = true;
                    LoadHoaDon();
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn bàn!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //khi nhấn chuột trái vào món ăn
        public void ItemClick(object sender, TileItemEventArgs e)
        {
            TileItem ti = (sender as TileItem);
            DTO_HangHoa hh = ti.Tag as DTO_HangHoa;
            if (iDBan != 0)
            {
                    DataProvider.Instance.GoiMon(iDBan, hh.ID, 1, frmDangNhap.NguoiDung);
                    checkChangedValueBan = true;
                    LoadHoaDon();
            }
            else
            {
                XtraMessageBox.Show("Bạn chưa chọn bàn!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //khi nhấn vào một cái bàn
        public void btn_Click(object sender, EventArgs e)
        {
            TileItem btnsp = (sender as TileItem);
            DTO_BAN ban = btnsp.Tag as DTO_BAN;
            DataTable data;
            if (ban.Trangthai != 1)
            {
                switch (KiemTraNut)
                {
                    case "nhap":
                        if (XtraMessageBox.Show(string.Format("Bạn có đồng ý nhập {0} sang {1}", tenBan, ban.Tenban), "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DataProvider.Instance.GopBan(iDBan, ban.Id, frmDangNhap.NguoiDung.Id);
                            data = DataProvider.Instance.ExecuteQuery("pro_GetTemp");
                            if (data.Rows.Count > 0)
                            {
                                foreach (DataRow r in data.Rows)
                                {
                                    DataProvider.Instance.ThayDoiSoLuong(1, r["IDHoaDon"].ToString(), r["IDHangHoa"].ToString(), int.Parse(r["SoLuong"].ToString()), frmDangNhap.NguoiDung);
                                }
                            }
                            DataProvider.Instance.ExecuteNoneQuery("DROP TABLE temp");
                            loadMotCaiBan(ban.Id, btnsp);
                            LoadHoaDon();
                            KiemTraNut = string.Empty;
                        }

                        break;
                    case "chuyen":
                        if (XtraMessageBox.Show(string.Format("Bạn có đồng ý chuyển {0} sang {1}", tenBan, ban.Tenban), "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DataProvider.Instance.ChuyenBan(iDBan, ban.Id, frmDangNhap.NguoiDung.Id);
                            loadMotCaiBan(ban.Id, btnsp);
                            LoadHoaDon();
                            btnChuyen.Text = "Chuyển";
                            KiemTraNut = string.Empty;
                        }
                        break;
                    case "tach":
                        Ngoai_IDBan1 = iDBan;
                        Ngoai_IDBan2 = ban.Id;
                        Ngoai_TenBan1 = tenBan;
                        Ngoai_TenBan2 = ban.Tenban;
                        if(iDHoaDon!=null)
                        Ngoai_IDhoadon = int.Parse(iDHoaDon.ToString());
                        frmTachBan f = new frmTachBan();
                        f.ShowDialog();
                        if (frmTachBan.Ngoai_KiemTra)
                        {
                            loadMotCaiBan(ban.Id, btnsp);
                            checkChangedValueBan = true;
                            LoadHoaDon();
                            btnChuyen.Text = "Tách";
                            KiemTraNut = string.Empty;
                        }
                        break;
                    case "ghep":
                        if (XtraMessageBox.Show(string.Format("Bạn có đồng ý ghep {0} sang {1}", tenBan, ban.Tenban), "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            DataProvider.Instance.GhepBan(iDBan, ban.Id, frmDangNhap.NguoiDung.Id, 1);
                            data = DataProvider.Instance.ExecuteQuery("pro_GetTemp");
                            if (data.Rows.Count > 0)
                            {
                                foreach (DataRow r in data.Rows)
                                {
                                    DataProvider.Instance.ThayDoiSoLuong(1, r["IDHoaDon"].ToString(), r["IDHangHoa"].ToString(), int.Parse(r["SoLuong"].ToString()), frmDangNhap.NguoiDung);
                                }
                            }
                            DataProvider.Instance.ExecuteNoneQuery("DROP TABLE temp");
                            loadMotCaiBan(ban.Id, btnsp);
                            LoadHoaDon();
                            btnNhap.Text = "Nhập";
                            btnNhap.Enabled = false;
                            KiemTraNut = string.Empty;
                        }
                        break;
                    default:
                        bantemp = ban;
                        btntemp = btnsp;
                        iDBan = ban.Id;
                        tenBan = ban.Tenban;
                        LoadHoaDon();
                        break;
                }
            }
            else
            {
                if (KiemTraNut==string.Empty)
                {
                    btnNhap.Text = "Hủy đặt";
                    bantemp = ban;
                    btntemp = btnsp;
                    iDBan = ban.Id;
                    ButtonEnable("FalseAll");
                    btnNhap.Enabled = true;
                }
                else
                {
                    XtraMessageBox.Show("Bàn của bạn chọn đã được đặt!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            if (!btnsp.Checked)
                btnsp.Checked = true;
            checkChangedValueBan = false;
        }
        //khi nhấn liên tiếp 2 lần vào cái bàn
        public void btn_ItemDoubleClick(object sender, EventArgs e)
        {
            if (KiemTraNut == string.Empty)
            {
                TileItem btnsp = (sender as TileItem);
                DTO_BAN ban = btnsp.Tag as DTO_BAN;
                bantemp = ban;
                btntemp = btnsp;
                iDBan = ban.Id;
                tenBan = ban.Tenban;
                if (!btnsp.Checked)
                    btnsp.Checked = true;
                tabPaneXemAll.SelectedPage = tabNavigationPageDanhSachHangHoa;
                LoadHoaDon();
            }
        }
        //Khi nhấn vào nút chức năng
        private void btnChucNang_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            DataTable tb = new DataTable();
            ButtonEnable("FalseAll");           
            switch (btn.Name)
            {
                case "btnNhap":
                    if (btnNhap.Text.Contains("Nhập"))
                    {
                        KiemTraNut = "nhap";
                        btnNhap.Text = "Hủy Bỏ";
                        btnNhap.Enabled = true;
                    }
                    else if (btnNhap.Text.Contains("Hủy đặt"))
                    {
                        DataProvider.Instance.ExecuteNoneQuery("DELETE CF_DatBan WHERE IDBan="+iDBan);
                        DataProvider.Instance.ExecuteNoneQuery("Update CF_Ban SET TrangThai=0 WHERE ID=" + iDBan);
                        loadMotCaiBan(iDBan, btntemp);
                        btnNhap.Text = "Đặt";
                        return;
                    }
                    else if (btnNhap.Text.Contains("Hủy Bỏ"))
                    {
                        KiemTraNut = string.Empty;
                        // btnHuyBo.Text = "Nhấn vào đây để hủy bỏ";
                        if (bantemp.Trangthai == 2)
                        {
                            ButtonEnable("TrueAll");
                            return;
                        }
                    }
                    else
                    {
                            lbTenBanDB.Text ="Bạn đang đặt cho "+ bantemp.Tenban;
                            fpDatBan.ShowPopup();
                            btnNhap.Enabled = false;
                        return;
                    }
                    break;
                case "btnChuyen":
                    if (btnChuyen.Text.Contains("Chuyển"))
                    {
                         KiemTraNut = "chuyen";
                         btnChuyen.Text = "Hủy Bỏ";
                         btnChuyen.Enabled = true;
                    }
                    else if (btnChuyen.Text.Contains("Hủy Bỏ"))
                    {
                        KiemTraNut = string.Empty;
                        btnChuyen.Text = "Chuyển";
                        if (bantemp.Trangthai == 2)
                        {
                            ButtonEnable("TrueAll");
                            return;
                        }
                    }
                    break;
                case "btnTach":
                    if (btnTach.Text.Contains("Tách"))
                    {
                        KiemTraNut = "tach";
                        btnTach.Text = "Hủy Bỏ";
                        btnTach.Enabled = true;
                    }
                    else if (btnTach.Text.Contains("Hủy Bỏ"))
                    {
                        KiemTraNut = string.Empty;
                        btnTach.Text = "Tách";
                        if (bantemp.Trangthai == 2)
                        {
                            ButtonEnable("TrueAll");
                            return;
                        }
                    }
                    break;
                case "btnGhep":
                    if (btnGhep.Text.Contains("Ghép"))
                    {
                        KiemTraNut = "ghep";
                        btnGhep.Text = "Hủy Bỏ";
                        btnGhep.Enabled = true;
                    }
                    else if (btnGhep.Text.Contains("Hủy Bỏ"))
                    {
                        KiemTraNut = string.Empty;
                        btnGhep.Text = "Ghép";
                        if (bantemp.Trangthai == 2)
                        {
                            ButtonEnable("TrueAll");
                            return;
                        }
                    }
                    else
                    {
                        tb = DataProvider.Instance.ExecuteQuery("SELECT ID FROM CF_Ban WHERE MaBan=" + iDBan);
                        DataProvider.Instance.GhepBan(0, iDBan, frmDangNhap.NguoiDung.Id, 0);
                        NavigationPageBase tab = xtraTabControlDanhSachBan.Pages[xtraTabControlDanhSachBan.SelectedPageIndex];
                        foreach (DataRow r in tb.Rows)
                        {
                            foreach (Control controlnew in tab.Controls)
                            {
                                TileControl tilenew = controlnew as TileControl;
                                foreach (TileGroup tilegroupnew in tilenew.Groups)
                                {
                                    foreach (TileItem itemnew in tilegroupnew.Items)
                                    {
                                        DTO_BAN bannew = itemnew.Tag as DTO_BAN;
                                        int idnew = int.Parse(r["ID"].ToString());
                                        if (bannew.Id == idnew)
                                        {
                                            loadMotCaiBan(idnew, itemnew);
                                        }
                                    }
                                }
                            }
                        }
                        loadMotCaiBan(iDBan, btntemp);

                        if (bantemp.Trangthai == 2)
                        {
                            ButtonEnable("TrueAll");
                            return;
                        }
                    }
                    break;
                    
            }
       }
        //dùng để kích hoạt hoặc hủy kích hoạt các nút
        void ButtonEnable(string loai)
        {
            switch (loai)
            {
                case "TrueAll":
                    btnChuyen.Enabled = true;
                    btnGhep.Text = "Ghép";
                    btnNhap.Text = "Nhập";
                    btnNhap.Enabled = true;
                    btnGhep.Enabled = true;
                    btnTach.Enabled = true;
                    //btnHuyBo.Enabled = false;
                    btnThanhToan.Enabled = true;
                    break;
                case "FalseAll":
                    btnChuyen.Enabled = false;
                    btnNhap.Enabled = false;
                    btnGhep.Enabled = false;
                    btnTach.Enabled = false;
                    btnThanhToan.Enabled = false;
                    //btnHuyBo.Enabled = false;
                    break;
                case "TrueGhep":
                    btnGhep.Text = "Tách";
                    btnGhep.Enabled = true;
                    btnNhap.Enabled = false;
                    btnTach.Enabled = false;
                    btnChuyen.Enabled = false;
                    //btnHuyBo.Enabled = false;
                    btnThanhToan.Enabled = true;
                    break;

            }



        }
        #endregion

        #region Xử lý sự kiện EditValueChanged
        //khi nhập vào khung phụ thu
        private void txtPhuThu_EditValueChanged(object sender, EventArgs e)
        {
            if (txtPhuThu.Value > 0 && txtPhuThu.Value <= 100)
            {
                lbPhuThu.Text = "%";
            }
            else if (txtPhuThu.Value == 0 || txtPhuThu.Value > 100)
            {
                lbPhuThu.Text = "đ";
            }
        }
        //khi nhập vào khung giảm giá
        private void txtGiamGia_EditValueChanged(object sender, EventArgs e)
        {
            if (txtGiamGia.Value >= 0 && txtGiamGia.Value <= 100)
            {
                lbGiamGia.Text = "%";
            }
            else
            {
                lbGiamGia.Text = "đ";
            }
        }
        //khi nhập vào khung tiền khách đưa
        private void txtTienKhachDua_EditValueChanged(object sender, EventArgs e)
        {
            int SoTienCanTra = int.Parse(lbSoTienCanTra.Tag.ToString());
            if (txtTienKhachDua.Value >= SoTienCanTra)
                txtThoiLai.Value = txtTienKhachDua.Value - SoTienCanTra;
            if (cbHinhThucThanhToan.EditValue == "Ghi nợ")
            {
                txtThoiLai.Value = txtTienKhachDua.Value - SoTienCanTra;
                if (txtThoiLai.Value > 0)
                    lbtienthoi.Text = "Số tiền thối lại:";
                else
                    lbtienthoi.Text = "Số tiền nợ:";
            }
        }
        private void checkInHoaDon_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.CBPrintBill = checkInHoaDon.Checked;
            Settings.Default.Save();
        }
        //dùng để lọc các bàn
        private void ckFilteBan_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit ck = sender as CheckEdit;
            _trangthai = int.Parse(ck.Tag.ToString());
            if (ck.Checked)
            {
                if (xtraTabControlDanhSachBan.Pages.Count>0)
                loadLocBan(_trangthai);
            }
        }
        //dùng để tìm hàng hóa
        private void txtTimHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            loadTimKiemHangHoa(txtTimHangHoa.Text);
        }
        //kiem tra và load theo lọc khi nhấp vào các tab khác nhau của bàn
        private void xtraTabControlDanhSach_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (xtraTabControlDanhSachBan.Pages.Count > 0)
            {
                loadLocBan(_trangthai);
            }         
        }
        void LoadAllBanChanged()
        {
            NavigationPageBase tab = xtraTabControlDanhSachBan.Pages[xtraTabControlDanhSachBan.SelectedPageIndex];
            DataTable tb =new DataTable();
            if (tab.Tag != null)
            {
                if (!tab.Tag.ToString().Contains("-1"))
                    tb = DAO_BAN.Instance.DanhSachBan(tab.Tag.ToString());
                else
                    tb = cF_BanTableAdapter.GetData();

                foreach (Control controlnew in tab.Controls)
                {
                    TileControl tilenew = controlnew as TileControl;
                    foreach (TileGroup tilegroupnew in tilenew.Groups)
                    {
                        foreach (TileItem itemnew in tilegroupnew.Items)
                        {
                            DTO_BAN ban = itemnew.Tag as DTO_BAN;
                            loadMotCaiBan(ban.Id, itemnew);
                        }
                    }
                }
            }
        }
        #endregion


        #region Cac gia tri khoi tao

        public static int Ngoai_IDBan1;
        public static int Ngoai_IDBan2;
        public static string Ngoai_TenBan1;
        public static string Ngoai_TenBan2;
        public static int Ngoai_IDhoadon;
        private bool checkChangedValueBan = false;

        TileItem btntemp;
        DTO_BAN bantemp;

        private bool KiemTraNutGhep = false;
        private object iDHoaDon;

        private string KiemTraNut = string.Empty;

        private int iDBan = 0;

        private string tenBan = string.Empty;

        private int _trangthai=-1;

        #endregion

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmSetting frSetting = new frmSetting();
            frSetting.ShowDialog();
            if (frSetting.checkSuccess)
            {
                SplashScreenManager.ShowForm(typeof(WaitForm2));
                ConfigurationManager.RefreshSection("appSettings");
                xtraTabControlDanhSachBan.Pages.Clear();
                xtraTabControlDanhSachHangHoa.Pages.Clear();
                loadAll();
                SplashScreenManager.CloseForm();
            }
        }

        private void tabPaneXemAll_SelectedPageChanged(object sender, SelectedPageChangedEventArgs e)
        {
            if (tabPaneXemAll.SelectedPage == tabNavigationPageDanhSachHangHoa || iDHoaDon==null)
            {
                ButtonEnable("FalseAll");
                if (btnNhap.Text.Contains("Đặt"))
                    btnNhap.Enabled = true;
            }
            else
            {
                ButtonEnable("TrueAll");
            }
        }

        private void gridView1_ShownEditor(object sender, EventArgs e)
        {
        }


        //private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    var owner = this;
        //    using (var dialog = new DevExpress.Customization.SvgSkinPaletteSelector(owner))
        //    {
        //        dialog.ShowDialog();
        //    }

        //}

        //private void frmBanHang_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    Settings.Default.PaletteName = UserLookAndFeel.Default.ActiveSvgPaletteName;
        //    Settings.Default.SkinName = UserLookAndFeel.Default.SkinName;
        //    Settings.Default.Save();
        //}


        //lay SimpleButton ban tu mot idBan
        //SimpleButton btnsp = xtraTabControlDanhSach.TabPages[xtraTabControlDanhSach.SelectedTabPageIndex].Controls.Find("butn" + IDBan, true)[0] as SimpleButton;
        //XtraMessageBox.Show("Bạn chưa chọn bàn!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        //public void loadCheckItem(TileItem Item)
        //{
        //    NavigationPageBase tab = xtraTabControlDanhSach.Pages[xtraTabControlDanhSach.SelectedPageIndex];
        //    TileControl flayout = tab.Controls[0] as TileControl;
        //    TileGroup tig = flayout.Groups[0] as TileGroup;
        //    foreach (TileItem item in tig.Items)
        //    {
        //        if (item != Item)
        //        {
        //            if (item.Checked)
        //                item.Checked = false;

        //        }
        //        else
        //        {
        //            Item.Checked = true;
        //        }
        //    }
        //}
        //tuy chon mau sac
                    //        col = System.Drawing.ColorTranslator.FromHtml("#0097a7");
                    //btnsp.AppearanceItem.Normal.BackColor = col;
        //layout.AppearanceItem.Pressed.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
    }
}