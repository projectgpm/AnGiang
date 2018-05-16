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
using QLCafe.BUS;
using QLCafe.DTO;
using DevExpress.SpreadsheetSource.Implementation;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;
using QLCafe.DAO;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using System.Globalization;
using QLCafe.Report;
using DevExpress.XtraReports.UI;
using DevExpress.DataAccess.Sql;
using QLCafe.Properties;
using DevExpress.XtraPrinting.Localization;
using DevExpress.XtraEditors.Controls;

namespace QLCafe
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {

        public frmBanHang()
        {
            InitializeComponent();
            //load việt sub hệ thống
            PreviewLocalizer.Active = new MyPreviewLocalizer();
            Localizer.Active = new MyLocalizer();
            LoadDanhSachBan();
            LoadDanhSachHangHoa();
            LoadXemhoadon();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Caption = "Giờ hiện tại: " + DateTime.Now.ToLongTimeString();
        }

        #region Việt sub hệ thống
        class MyPreviewLocalizer : PreviewLocalizer
        {
            public override string GetLocalizedString(PreviewStringId id)
            {
                switch (id)
                {
                    case PreviewStringId.WaitForm_Caption:
                        return "Đang Tải Dữ Liệu";
                    case PreviewStringId.Msg_CreatingDocument:
                        return "Vui lòng đợi một lát...";
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
                        return @"Giá trị không hợp lệ";
                    case StringId.XtraMessageBoxYesButtonText:
                        return "Đồng ý";
                    case StringId.XtraMessageBoxCancelButtonText:
                        return "Trở lại";
                    case StringId.XtraMessageBoxNoButtonText:
                        return "Hủy";
                    default:
                        return base.GetLocalizedString(id);
                }
            }
        }

        #endregion


        #region Xử lý Load dữ liệu
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            this.cF_BanTableAdapter.Fill(this.quanlycafeDataSet.CF_Ban);
            this.cF_NguoiDungTableAdapter.Fill(this.quanlycafeDataSet.CF_NguoiDung);
            this.cF_LichSuThaoTacTableAdapter.Fill(this.quanlycafeDataSet.CF_LichSuThaoTac);
            ButtonEnable("FalseAll");
            lblNgay.Caption = "Ngày hôm nay: " + DateTime.Now.ToString("dd/MM/yyyy");
            txtTenDangNhap.Caption = "Nhân viên: " + frmDangNhap.NguoiDung.Tennguoidung;
            this.cF_ChiNhanhTableAdapter1.Fill(this.quanlycafeDataSet.CF_ChiNhanh);
            barThongTinQuan.Caption = cF_ChiNhanhTableAdapter1.GetData().FindByID(0).TenChiNhanh + " - " + cF_ChiNhanhTableAdapter1.GetData().FindByID(0).DiaChi;
        }

        public void LoadXemhoadon()
        {
            try
            {
                rpHoaDonBanHang1_Temp rp = new rpHoaDonBanHang1_Temp();
                rp.Parameters["ID"].Value = iDHoaDon == null ? 0 : iDHoaDon;
                rp.Parameters["ID"].Visible = false;
                rp.Parameters["IDChiNhanh"].Value = frmDangNhap.NguoiDung.Idchinhanh;
                rp.Parameters["IDChiNhanh"].Visible = false;
                documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                rp.CreateDocument();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }

        }

        public void LoadHoaDon()
        {
            gridView1.ViewCaption = "DANH SÁCH MÓN ĂN BÀN " + tenBan;
            iDHoaDon = DataProvider.Instance.ExecuteScalar("SELECT ID FROM CF_HoaDon WHERE TrangThai=0 and IDBan=" + iDBan);
            if (iDHoaDon == null) { iDHoaDon = 0; ButtonEnable("FalseAll"); } else { if (KiemTraNutGhep) { ButtonEnable("TrueGhep"); } else { ButtonEnable("TrueAll"); } }
            this.cF_ChiTietHoaDon_TempTableAdapter.FillByIDHoaDon(this.quanlycafeDataSet.CF_ChiTietHoaDon_Temp, int.Parse(iDHoaDon.ToString()));
            LoadXemhoadon();
            cF_LichSuThaoTacTableAdapter.Fill(quanlycafeDataSet.CF_LichSuThaoTac);
            lblTenBan.Caption = "Tên bàn: " + tenBan;
        }

        public void LoadDanhSachBan()
        {
            xtraTabControlDanhSach.TabPages.Clear();
            DataTable dt = BUS_KhuVuc.DanhSachBanTheoKhuVuc(frmDangNhap.NguoiDung.Idchinhanh);
            if (dt.Rows.Count < 0)
            {
                XtraMessageBox.Show("Danh sách bàn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (DataRow dr in dt.Rows)
            {
                string TenKhuVucNull = dr["TenKhuVuc"].ToString();
                string IDKhuVucNull = dr["ID"].ToString();
                FlowLayoutPanel layout = new FlowLayoutPanel();
                layout.Dock = DockStyle.Fill;
                layout.AutoScroll = true;
                LoadBanKhuVuc(IDKhuVucNull, layout);
                xtraTabControlDanhSach = AddTabControl(xtraTabControlDanhSach, TenKhuVucNull, IDKhuVucNull, layout);
            }
        }

        public void LoadDanhSachHangHoa()
        {
            DataTable dt = BUS_NhomHang.DanhSachNhomHang();
            foreach (DataRow dr in dt.Rows)
            {
                string TenNhomHangNull = dr["TenNhom"].ToString();
                string IDNhomHangNull = dr["ID"].ToString();
                FlowLayoutPanel layout = new FlowLayoutPanel();
                layout.Dock = DockStyle.Fill;
                layout.AutoScroll = true;
                loadHangHoaNhom(IDNhomHangNull, layout);
                xtraTabControlDanhSachHangHoa = AddTabControl(xtraTabControlDanhSachHangHoa, TenNhomHangNull, IDNhomHangNull, layout);
            }
        }

        public void loadMotCaiBan(int IDBan, SimpleButton btnsp)
        {
            DTO_BAN ban1 = new DTO_BAN(cF_BanTableAdapter.GetData().FindByID(IDBan));
            switch (ban1.Trangthai)
            {
                case 0:
                    btnsp.ForeColor = Color.Black;
                    btnsp.ToolTip = "Bàn trống";
                    btnsp.Text = ban1.Tenban + "\n\nTrống";
                    btnsp.Enabled = true;
                    break;
                case 1:
                    btnsp.ForeColor = Color.OrangeRed;
                    btnsp.Text = ban1.Tenban + "\n\nĐặt";
                    break;
                case 2:
                    btnsp.ForeColor = Color.Red;
                    btnsp.ToolTip = "Bàn có người";
                    if (ban1.Maban.Contains("+"))
                    {
                        btnsp.Text = ban1.Tenban + "\n(+)\nCó";
                    }
                    else
                    {
                        btnsp.Text = ban1.Tenban + "\n\nCó";
                    }
                    break;
                case 3:
                    btnsp.ForeColor = Color.DarkSlateGray;
                    DTO_BAN banduocghep = new DTO_BAN(cF_BanTableAdapter.GetData().FindByID(int.Parse(ban1.Maban)));
                    btnsp.Text = ban1.Tenban + "\nGhép\n" + banduocghep.Tenban;
                    btnsp.Enabled = false;
                    break;
            }
            btnsp.Tag = ban1;
        }

        public void LoadBanKhuVuc(string IDKhuVuc, FlowLayoutPanel layout)
        {
            List<DTO_BAN> tablelist = DAO_BAN.Instance.LoadTableList(DAO_BAN.Instance.DanhSachBan(IDKhuVuc));
            foreach (DTO_BAN item in tablelist)
            {
                SimpleButton btn = new SimpleButton();
                btn.Width = 80;
                btn.Height = 80;
                btn.Click += btn_Click;
                btn.Name = "butn" + item.Id.ToString();
                btn.Appearance.Font = new Font("Tahoma", 11, FontStyle.Regular);
                btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
                btn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                btn.StyleController = null;
                btn.Appearance.BackColor = Color.Transparent;
                btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                btn.Tag = item;
                switch (item.Trangthai)
                {
                    case 0:
                        btn.ForeColor = Color.Black;
                        btn.ToolTip = "Bàn trống";
                        btn.Text = item.Tenban + "\n\nTrống";
                        break;
                    case 1:
                        btn.ForeColor = Color.OrangeRed;
                        btn.Text = item.Tenban + "\n\nĐặt";
                        break;
                    case 2:
                        btn.ForeColor = Color.Red;
                        btn.ToolTip = "Bàn có người";
                        if (item.Maban.Contains("+"))
                            btn.Text = item.Tenban + "++\n\nCó";
                        else
                            btn.Text = item.Tenban + "\n\nCó";
                        break;
                    case 3:
                        btn.ForeColor = Color.OrangeRed;
                        DTO_BAN banduocghep = new DTO_BAN(cF_BanTableAdapter.GetData().FindByID(int.Parse(item.Maban)));
                        btn.Text = item.Tenban + "\nGhép\n" + banduocghep.Tenban;
                        btn.Enabled = false;
                        break;
                }
                layout.Controls.Add(btn);
            }
        }

        public void loadHangHoaNhom(string IDNhomHang, FlowLayoutPanel layout)
        {
            DataTable db = BUS_HangHoa.DSHangHoa(IDNhomHang);
            if (db.Rows.Count > 0)
            {
                foreach (DataRow dr in db.Rows)
                {
                    SimpleButton btn = new SimpleButton();
                    btn.Width = 80;
                    btn.Height = 80;
                    btn.ForeColor = Color.Black;
                    btn.StyleController = null;
                    btn.LookAndFeel.UseDefaultLookAndFeel = false;
                    btn.ToolTip = dr["TenHangHoa"].ToString();
                    btn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                    btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
                    btn.Appearance.BackColor = Color.Transparent;
                    btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    btn.Text = dr["TenHangHoa"].ToString();
                    btn.MouseDown += btnMonAn_MouseDown;
                    btn.Tag = dr["ID"].ToString();
                    btn.Appearance.Font = new Font("Tahoma", 11);
                    layout.Controls.Add(btn);
                }
            }
        }
        #endregion


        #region Sự kiện gird

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string IDHangHoa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDHH).ToString();
            int SoLuongMoi = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSoLuong).ToString());
            DataProvider.Instance.ThayDoiSoLuong(0, iDHoaDon.ToString(), IDHangHoa, SoLuongMoi, frmDangNhap.NguoiDung);
            loadMotCaiBan(iDBan, btntemp);
            LoadHoaDon();
           
        }
        #endregion


        #region Sự kiện khi nhấn vào các nút

        //khi nhấn vào nút kết ca
        private void btnKetCa_ItemClick(object sender, ItemClickEventArgs e)
        {
            //frmKetCa fr = new frmKetCa();
            //fr.ShowDialog();
        }

        //thoát
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        //khi nhấn chuột phải vào món ăn
        private void btnMonAn_MouseDown(object sender, MouseEventArgs e)
        {
            string IDHangHoa = (sender as SimpleButton).Tag.ToString();
            object kiemtraloadban = null;
            switch (e.Button)
            {
                case MouseButtons.Right:
                    DataProvider.Instance.ThayDoiSoLuong(1, iDHoaDon.ToString(), IDHangHoa, -1, frmDangNhap.NguoiDung);
                    if (iDBan != 0)
                        kiemtraloadban = DataProvider.Instance.ExecuteScalar("SELECT TrangThai FROM CF_Ban WHERE ID=" + iDBan);
                    break;
                case MouseButtons.Left:
                    if (iDBan != 0)
                    {
                        kiemtraloadban = DataProvider.Instance.ExecuteScalar("SELECT TrangThai FROM CF_Ban WHERE ID=" + iDBan);
                        DataProvider.Instance.GoiMon(iDBan, IDHangHoa, 1, frmDangNhap.NguoiDung);
                    }
                    else
                    {
                        XtraMessageBox.Show("Bạn chưa chọn bàn!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

            }
            if (kiemtraloadban != null && int.Parse(kiemtraloadban.ToString()) <= 0)
            {
                loadMotCaiBan(iDBan, btntemp);
            }
            LoadHoaDon();

        }

        //khi nhấn vào một cái bàn
        private void btn_Click(object sender, EventArgs e)
        {
            SimpleButton btnsp = (sender as SimpleButton);
            DTO_BAN ban = btnsp.Tag as DTO_BAN;
            DataTable data;
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
                        loadMotCaiBan(iDBan, btntemp);
                        loadMotCaiBan(ban.Id, btnsp);
                        LoadHoaDon();
                        KiemTraNut = string.Empty;
                    }

                    break;
                case "chuyen":
                    if (XtraMessageBox.Show(string.Format("Bạn có đồng ý chuyển {0} sang {1}", tenBan, ban.Tenban), "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DataProvider.Instance.ChuyenBan(iDBan, ban.Id, frmDangNhap.NguoiDung.Id);
                        loadMotCaiBan(iDBan, btntemp);
                        loadMotCaiBan(ban.Id, btnsp);
                        LoadHoaDon();
                        KiemTraNut = string.Empty;
                    }
                    break;
                case "tach":
                    Ngoai_IDBan1 = iDBan;
                    Ngoai_IDBan2 = ban.Id;
                    Ngoai_TenBan1 = tenBan;
                    Ngoai_TenBan2 = ban.Tenban;
                    Ngoai_IDhoadon = int.Parse(iDHoaDon.ToString());
                    frmTachBan f = new frmTachBan();
                    f.ShowDialog();
                    if (frmTachBan.Ngoai_KiemTra)
                    {
                        loadMotCaiBan(iDBan, btntemp);
                        loadMotCaiBan(ban.Id, btnsp);
                        LoadHoaDon();
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
                        loadMotCaiBan(iDBan, btntemp);
                        loadMotCaiBan(ban.Id, btnsp);
                        LoadHoaDon();
                        KiemTraNut = string.Empty;
                    }
                    break;
                default:
                    if (ban.Maban.Contains("+"))
                        KiemTraNutGhep = true;
                    else
                        KiemTraNutGhep = false;
                    bantemp = ban;
                    btntemp = btnsp;
                    iDBan = ban.Id;
                    tenBan = ban.Tenban;
                    LoadHoaDon();                   
                    break;
            }

        }

        private void btnChucNang_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            switch (btn.Name)
            {
                case "btnNhap":
                    if (btn.Text.Contains("Nhập"))
                    {
                        KiemTraNut = "nhap";
                        btnHuyBo.Text = "Hãy chọn một bàn để nhập\n\n Nhấp vào đây để hủy bỏ";
                    }
                    else
                    {
                        KiemTraNut = "dat";
                        btnHuyBo.Text = "Hủy bàn đã đặt";
                    }
                    break;
                case "btnChuyen":
                    KiemTraNut = "chuyen";
                    btnHuyBo.Text = "Hãy chọn một bàn để chuyển\n\n Nhấp vào đây để hủy bỏ";
                    break;
                case "btnTach":
                    KiemTraNut = "tach";
                    btnHuyBo.Text = "Hãy chọn một bàn không có khách để tách\n\n Nhấp vào đây để hủy bỏ";
                    break;
                case "btnGhep":
                    if (btn.Text.Contains("Ghép"))
                    {
                        KiemTraNut = "ghep";
                        btnHuyBo.Text = "Hãy chọn một bàn có khách để ghép\n\n Nhấp vào đây để hủy bỏ";
                    }else
                    {
                        DataTable tb = DataProvider.Instance.ExecuteQuery("SELECT ID FROM CF_Ban WHERE MaBan=" + iDBan);
                        DataProvider.Instance.GhepBan(0, iDBan, frmDangNhap.NguoiDung.Id, 0);                       
                        SimpleButton btnsp = new SimpleButton();
                        foreach (DataRow r in tb.Rows)
                        {
                            btnsp = xtraTabControlDanhSach.TabPages[xtraTabControlDanhSach.SelectedTabPageIndex].Controls.Find("butn" + r["ID"].ToString(), true)[0] as SimpleButton;
                            loadMotCaiBan(int.Parse(r["ID"].ToString()), btnsp);
                        }
                        loadMotCaiBan(iDBan, btntemp);

                        if (bantemp.Trangthai == 2)
                        {
                            ButtonEnable("TrueAll");
                            return;
                        }
                    }
                    break;
                case "btnHuyBo":
                    KiemTraNut = string.Empty;
                    btnHuyBo.Text = "Nhấn vào đây để hủy bỏ";
                    if (bantemp.Trangthai == 2)
                    {
                        ButtonEnable("TrueAll");
                        return;
                    }
                    break;
            }
            ButtonEnable("FalseAll");
            btnNhap.Text = "Nhập";
            btnNhap.Enabled = false;
            btnHuyBo.Enabled = true;
        }

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
                    btnHuyBo.Enabled = false;
                    break;
                case "FalseAll":
                    btnChuyen.Enabled = false;
                    btnNhap.Text = "Đặt";
                    btnNhap.Enabled = true;
                    btnGhep.Enabled = false;
                    btnTach.Enabled = false;                  
                    break;
                case "TrueGhep":
                    btnGhep.Text = "Tách";
                    btnGhep.Enabled = true;
                    btnNhap.Enabled = false;
                    btnTach.Enabled = false;
                    btnChuyen.Enabled = false;
                    btnHuyBo.Enabled = false;
                    break;

            }



        }
        #endregion


        #region Khởi tạo XtraTabControl

        /// <summary>
        /// Dùng để thêm vào XtraTabControl một XtraTabPage với FlowLayoutPanel
        /// </summary>
        /// <param name="xtratabparent">truyền vào một XtraTabControl</param>
        /// <param name="name">truyền vào Text của XtraTabPage</param>
        /// <param name="ID">truyền vào Name của XtraTabPage</param>
        /// <param name="layout">Truyền vào một FlowLayoutPanel</param>
        /// <returns>Trả về một mã kiểu dữ liệu là XtraTabControl</returns>
        public XtraTabControl AddTabControl(XtraTabControl xtratabparent, string name, string ID, FlowLayoutPanel layout)
        {

            bool KT = false;
            foreach (XtraTabPage tabitem in xtratabparent.TabPages)
            {
                if (tabitem.Name == ID)
                {
                    KT = true;
                    xtratabparent.SelectedTabPage = tabitem;
                }
            }
            if (KT == false)
            {
                xtratabparent.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Colibri", 11, System.Drawing.FontStyle.Bold);
                xtratabparent.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 10, System.Drawing.FontStyle.Regular);
                XtraTabPage xtratab = new XtraTabPage();
                xtratab.Name = ID;
                xtratab.Text = name;
                xtratab.Controls.Add(layout);
                xtratabparent.TabPages.Add(xtratab);
            }
            return xtratabparent;

        }
        #endregion


        #region Cac gia tri khoi tao

        public static int Ngoai_IDBan1;
        public static int Ngoai_IDBan2;
        public static string Ngoai_TenBan1;
        public static string Ngoai_TenBan2;
        public static int Ngoai_IDhoadon;
        SimpleButton btntemp;
        DTO_BAN bantemp;

        private bool KiemTraNutGhep = false;
        private object iDHoaDon;

        private string KiemTraNut = string.Empty;

        private int iDBan = 0;

        private string tenBan = string.Empty;


        #endregion


        //lay SimpleButton ban tu mot idBan
        //SimpleButton btnsp = xtraTabControlDanhSach.TabPages[xtraTabControlDanhSach.SelectedTabPageIndex].Controls.Find("butn" + IDBan, true)[0] as SimpleButton;
        //XtraMessageBox.Show("Bạn chưa chọn bàn!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

    }
}