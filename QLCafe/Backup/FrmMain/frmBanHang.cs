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
using DevExpress.XtraSplashScreen;

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
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));            
            this.cF_BanTableAdapter.Fill(this.quanlycafeDataSet.CF_Ban);
            this.cF_NguoiDungTableAdapter.Fill(this.quanlycafeDataSet.CF_NguoiDung);
            this.cF_LichSuThaoTacTableAdapter.Fill(this.quanlycafeDataSet.CF_LichSuThaoTac);
            ButtonEnable("FalseAll");
            statusNgay.Caption = "Ngày: " + DateTime.Now.ToString("dd/MM/yyyy");
            statusTenDangNhap.Caption = "Nhân viên: " + frmDangNhap.NguoiDung.Tennguoidung;
            this.cF_ChiNhanhTableAdapter1.Fill(this.quanlycafeDataSet.CF_ChiNhanh);
            barThongTinQuan.Caption = cF_ChiNhanhTableAdapter1.GetData().FindByID(0).TenChiNhanh + " - " + cF_ChiNhanhTableAdapter1.GetData().FindByID(0).DiaChi;
            SplashScreenManager.CloseForm();
        }

        public void LoadXemhoadon()
        {
            try
            {
                rpHoaDonBanHang1_Temp rp = new rpHoaDonBanHang1_Temp();
                rp.Parameters["ID"].Value = iDHoaDon == null ? 0 : iDHoaDon;
                rp.Parameters["ID"].Visible = false;
                rp.Parameters["IDChiNhanh"].Value = 0;
                rp.Parameters["IDChiNhanh"].Visible = false;
                documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                rp.CreateDocument();
            }
            catch (Exception ex) { XtraMessageBox.Show(ex.Message); }

        }

        public void LoadHoaDon()
        {
            gridView1.ViewCaption = "DANH SÁCH MÓN ĂN " + tenBan.ToUpper();
            iDHoaDon = DataProvider.Instance.ExecuteScalar("SELECT ID FROM CF_HoaDon WHERE TrangThai=0 and IDBan=" + iDBan);
            if (iDHoaDon == null) { iDHoaDon = 0; ButtonEnable("FalseAll"); btnNhap.Text = "Đặt"; btnNhap.Enabled = true; } else { if (KiemTraNutGhep) { ButtonEnable("TrueGhep"); } else { ButtonEnable("TrueAll"); } }
            this.cF_ChiTietHoaDon_TempTableAdapter.FillByIDHoaDon(this.quanlycafeDataSet.CF_ChiTietHoaDon_Temp, int.Parse(iDHoaDon.ToString()));
            LoadXemhoadon();
            loadMotCaiBan(iDBan, btntemp);
            cF_LichSuThaoTacTableAdapter.Fill(quanlycafeDataSet.CF_LichSuThaoTac);
        }

        public void loadMotCaiBan(int IDBan, SimpleButton btnsp)
        {
            DTO_BAN ban1 = new DTO_BAN(cF_BanTableAdapter.GetData().FindByID(IDBan));
            btnsp.Tag = ban1;
            switch (ban1.Trangthai)
            {
                case 0:
                    btnsp.ForeColor = Color.Black;
                    btnsp.ToolTip = "Bàn trống ";
                    btnsp.Text = ban1.Tenban + "\n\nTrống";
                    //btnsp.ImageToTextAlignment = ImageAlignToText.LeftTop;
                    btnsp.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
                    btnsp.Image = Resources.status0;
                    btnsp.Enabled = true;
                    break;
                case 1:
                    btnsp.ForeColor = Color.OrangeRed;
                    DTO_DatBan datban = new DTO_DatBan(cF_DatBanTableAdapter.GetData(ban1.Id)[0]);
                    btnsp.ToolTip = "Họ tên: " + datban.TenKhachHang + "\nĐT: " + datban.DienThoai;
                    btnsp.Text = ban1.Tenban + "\n" + datban.GioDat.ToString("h:mm tt") + "\nĐặt";
                    btnsp.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopLeft;
                    btnsp.Image = Resources.status1;
                    break;
                case 2:
                    btnsp.ForeColor = Color.Red;
                    btnsp.ToolTip = "Bàn có người ";
                    if (ban1.Maban.Contains("+"))
                    {
                        btnsp.Text = ban1.Tenban + "\n(+)\nCó";
                    }
                    else
                    {
                        btnsp.Text = ban1.Tenban + "\n\nCó";
                    }
                    btnsp.ImageToTextAlignment = ImageAlignToText.LeftTop;
                    btnsp.Image = Resources.status2;
                    break;
                case 3:
                    btnsp.ForeColor = Color.DarkSlateGray;
                    DTO_BAN banduocghep = new DTO_BAN(cF_BanTableAdapter.GetData().FindByID(int.Parse(ban1.Maban)));
                    btnsp.Text = ban1.Tenban + "\nGhép\n" + banduocghep.Tenban;
                    btnsp.Enabled = false;
                    break;
                case 4:
                    btnsp.ForeColor = Color.DarkSlateGray;
                    btnsp.Text = ban1.Tenban+"\n"+ban1.NgayCapNhat.ToString("h:mm tt")+"\nXong";
                    break;
            }
        }

        public void loadHangHoaTimKiem(string TenHangHoa, FlowLayoutPanel layout)
        {
            DataTable db;
            if (TenHangHoa != string.Empty)
            {
                db = cF_HangHoaTableAdapter1.GetDataByTenHangHoa(TenHangHoa);
            }else
            {
                db = BUS_HangHoa.DSHangHoa(xtraTabControlDanhSachHangHoa.TabPages[xtraTabControlDanhSachHangHoa.SelectedTabPageIndex].Tag.ToString());
            }
            
            if (db.Rows.Count > 0)
            {
                foreach (DataRow dr in db.Rows)
                {
                    SimpleButton btn = new SimpleButton();
                    //btn.Width = 130;
                    //btn.Height = 40;      
                    //btn.StyleController = null;
                    //btn.LookAndFeel.UseDefaultLookAndFeel = false;
                    //btn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                    //btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    //btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
                    //btn.Appearance.BackColor = Color.Transparent;
                    //btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    btn.ForeColor = Color.Black;
                    btn.ToolTip = dr["TenHangHoa"].ToString();
                    btn.Text = dr["TenHangHoa"].ToString();
                    btn.MouseDown += btnMonAn_MouseDown;
                    btn.Tag = dr["ID"].ToString();
                    btn.Appearance.Font = new Font("Tahoma", 11);
                    Size bestSize = btn.CalcBestSize();
                    btn.Width = bestSize.Width;
                    btn.Height = 40;
                    layout.Controls.Add(btn);
                }
            }
        }

        public void LoadDanhSachBan()
        {
            //xtraTabControlDanhSach.TabPages.Clear();
            DataTable dt = BUS_KhuVuc.DanhSachBanTheoKhuVuc("0");
            if (dt.Rows.Count < 0)
            {
                XtraMessageBox.Show("Danh sách bàn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (DataRow dr in dt.Rows)
            {
                string TenKhuVucNull = dr["TenKhuVuc"].ToString();
                string IDKhuVucNull = dr["ID"].ToString();
                IDKhuVucNull = "khuvuc" + dr["ID"].ToString();
                xtraTabControlDanhSach = AddTabControl(xtraTabControlDanhSach, TenKhuVucNull, IDKhuVucNull);
            }

            foreach (XtraTabPage tab in xtraTabControlDanhSach.TabPages)
            {
                FlowLayoutPanel layout = new FlowLayoutPanel();
                layout.Dock = DockStyle.Fill;
                layout.AutoScroll = true;
                LoadBanKhuVucTrangThai(-1, int.Parse(tab.Tag.ToString()), layout);
                tab.Controls.Add(layout);
            }

        }

        public void LoadDanhSachHangHoa()
        {
            DataTable dt = BUS_NhomHang.DanhSachNhomHang();
            foreach (DataRow dr in dt.Rows)
            {
                string TenNhomHangNull = dr["TenNhom"].ToString();
                string IDNhomHangNull = dr["ID"].ToString();
                IDNhomHangNull = "nhh" + dr["ID"].ToString();
                xtraTabControlDanhSachHangHoa = AddTabControl(xtraTabControlDanhSachHangHoa, TenNhomHangNull, IDNhomHangNull);
            }
            foreach (XtraTabPage tab in xtraTabControlDanhSachHangHoa.TabPages)
            {
                FlowLayoutPanel layout = new FlowLayoutPanel();
                layout.Dock = DockStyle.Fill;
                layout.AutoScroll = true;
                loadHangHoaNhom(tab.Tag.ToString(), layout);
                tab.Controls.Add(layout);
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
                    //btn.Width = 130;
                    //btn.Height = 40;      
                    //btn.StyleController = null;
                    //btn.LookAndFeel.UseDefaultLookAndFeel = false;
                    //btn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                    //btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    //btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
                    //btn.Appearance.BackColor = Color.Transparent;
                    //btn.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
                    btn.ForeColor = Color.Black;
                    btn.ToolTip = dr["TenHangHoa"].ToString();
                    btn.Text = dr["TenHangHoa"].ToString();
                    btn.MouseDown += btnMonAn_MouseDown;
                    btn.Tag = dr["ID"].ToString();
                    btn.Appearance.Font = new Font("Tahoma", 11);
                    Size bestSize = btn.CalcBestSize();
                    btn.Width = bestSize.Width;
                    btn.Height = 40;
                    layout.Controls.Add(btn);
                }
            }
        }

        public void LoadBanKhuVucTrangThai(int TrangThai, int IDKhuVuc, FlowLayoutPanel layout)
        {
            DataTable db;
            if (TrangThai > 0)
            {
                db = cF_BanTableAdapter.GetDataByTrangThaiIDKhuVuc(IDKhuVuc, TrangThai);
            }
            else
            {
                db = DAO_BAN.Instance.DanhSachBan(xtraTabControlDanhSach.TabPages[xtraTabControlDanhSach.SelectedTabPageIndex].Tag.ToString());
            }
            if (db.Rows.Count > 0)
                foreach (DataRow item in db.Rows)
                {
                    SimpleButton btn = new SimpleButton();
                    btn.Width = 80;
                    btn.Height = 80;
                    btn.Click += btn_Click;
                    btn.Name = "butn" + item["Id"].ToString();
                    btn.Appearance.Font = new Font("Tahoma", 11, FontStyle.Regular);
                    //btn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
                    //btn.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
                    //btn.StyleController = null;
                    //btn.Appearance.BackColor = Color.Transparent;
                    //btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    DTO_BAN btemp = new DTO_BAN(item);
                    btn.Tag = btemp;
                    loadMotCaiBan(btemp.Id, btn);
                    layout.Controls.Add(btn);
                }
        }

        #endregion


        #region Sự kiện gird

        //private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        //{
        //    // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
        //    // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
        //    // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
        //    // và ngược lại
        //    e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        //}

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string IDHangHoa = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colIDHH).ToString();
            int SoLuongMoi = int.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, colSoLuong).ToString());
            DataProvider.Instance.ThayDoiSoLuong(0, iDHoaDon.ToString(), IDHangHoa, SoLuongMoi, frmDangNhap.NguoiDung);
            loadMotCaiBan(iDBan, btntemp);
            LoadHoaDon();
           
        }
        #endregion


        #region Sự kiện Click

        //thực hiện thanh toán
        private void btnThanhToan_Click(object sender, EventArgs e)
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

        //hủy việc thanh toán
        private void btnHuyThanhToan_Click(object sender, EventArgs e)
        {
            fpThanhToan.HidePopup();
        }

        //thực hiện giảm giá
        private void btnGiamGia_Click(object sender, EventArgs e)
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
                    if(txtThoiLai.Value <= 0 && cbHinhThucThanhToan.EditValue == "Ghi nợ" || txtThoiLai.Value>=0 && cbHinhThucThanhToan.EditValue != "Ghi nợ")
                    if (txtTienKhachDua.Value > 0)
                    {
                            DataProvider.Instance.ThanhToan(iDHoaDon.ToString(), iDBan.ToString(), cbHinhThucThanhToan.EditValue.ToString(), (float)txtTienKhachDua.Value, (float)txtThoiLai.Value, frmDangNhap.NguoiDung.Id);
                            loadLocBan(-1);
                        if (checkInHoaDon.Checked)
                            {
                                XtraReport rp = new rpHoaDonBanHang1();
                                rp.Parameters["ID"].Value = iDHoaDon.ToString();
                                rp.Parameters["ID"].Visible = false;
                                rp.Parameters["IDChiNhanh"].Value = frmDangNhap.NguoiDung.Idchinhanh;
                                rp.Parameters["IDChiNhanh"].Visible = false;
                                //documentViewerBarManager1.DocumentViewer.PrintingSystem = rp.PrintingSystem;
                                //rp.CreateDocument();
                                ReportPrintTool print = new ReportPrintTool(rp);
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

        //hoàn lại hóa đơn cuối cùng đã tính
        private void btnKhoiPhuc_Click(object sender, EventArgs e)
        {
            if (bantemp.Trangthai == 4)
            {
                DataProvider.Instance.HoanTac(iDBan);
                LoadHoaDon();
            }else
            {
                XtraMessageBox.Show("Bạn không thể thực hiện thao tác hoàn lại ở bàn này","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //Xem và in
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmXemInLaiHoaDon fm = new frmXemInLaiHoaDon();
            fm.ShowDialog();
        }

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

        // chấp nhận đặt bàn
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

        //khi nhấn chuột phải vào món ăn
        public void btnMonAn_MouseDown(object sender, MouseEventArgs e)
        {
            string IDHangHoa = (sender as SimpleButton).Tag.ToString();
            
            if (iDBan != 0)
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        DataProvider.Instance.ThayDoiSoLuong(1, iDHoaDon.ToString(), IDHangHoa, -1, frmDangNhap.NguoiDung);                       
                        break;
                    case MouseButtons.Left:
                        DataProvider.Instance.GoiMon(iDBan, IDHangHoa, 1, frmDangNhap.NguoiDung);
                        break;

                }
                loadMotCaiBan(iDBan, btntemp);
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
            SimpleButton btnsp = (sender as SimpleButton);
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
                        if (ban.Trangthai == 4)
                        {
                            btnKhoiPhuc.Enabled = true;
                        }
                        else
                        {
                            btnKhoiPhuc.Enabled = false;
                        }
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
                    btnHuyBo.Enabled = false;
                }
                else
                {
                    XtraMessageBox.Show("Bàn của bạn chọn đã được đặt!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        //Khi nhấn vào nút chức năng
        private void btnChucNang_Click(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
             DataTable tb = new DataTable();
            switch (btn.Name)
            {
                case "btnNhap":
                    if (btn.Text.Contains("Nhập"))
                    {
                        KiemTraNut = "nhap";
                        btnHuyBo.Text = "Hãy chọn một bàn để nhập\n\n Nhấp vào đây để hủy bỏ";
                    }
                    else if (btnNhap.Text.Contains("Hủy đặt"))
                    {
                        DataProvider.Instance.ExecuteNoneQuery("DELETE CF_DatBan WHERE IDBan="+iDBan);
                        DataProvider.Instance.ExecuteNoneQuery("Update CF_Ban SET TrangThai=0 WHERE ID=" + iDBan);
                        loadMotCaiBan(iDBan, btntemp);
                        btnNhap.Text = "Đặt";
                        return;
                    }else
                    {
                        if (iDHoaDon != null)
                        {
                            lbTenBanDB.Text ="Bạn đang đặt cho "+ bantemp.Tenban;
                            fpDatBan.ShowPopup();
                            btnNhap.Enabled = false;
                        }
                        return;
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
                        tb = DataProvider.Instance.ExecuteQuery("SELECT ID FROM CF_Ban WHERE MaBan=" + iDBan);
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
                    btnHuyBo.Enabled = false;
                    btnThanhToan.Enabled = true;
                    btnGiamGia.Enabled = true;
                    break;
                case "FalseAll":
                    btnChuyen.Enabled = false;
                    btnNhap.Enabled = false;
                    btnGhep.Enabled = false;
                    btnTach.Enabled = false;   
                    btnThanhToan.Enabled = false;
                    btnGiamGia.Enabled = false;
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
            if (ck.Checked)
            {
                loadLocBan(int.Parse(ck.Tag.ToString()));
            }
        }

        private void txtTimHangHoa_EditValueChanged(object sender, EventArgs e)
        {
            FlowLayoutPanel layout = new FlowLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.AutoScroll = true;
            XtraTabPage tabpage = xtraTabControlDanhSachHangHoa.TabPages[xtraTabControlDanhSachHangHoa.SelectedTabPageIndex];
            tabpage.Controls.Clear();
            loadHangHoaTimKiem(txtTimHangHoa.Text, layout);
            tabpage.Controls.Add(layout);
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
        public XtraTabControl AddTabControl(XtraTabControl xtratabparent, string name, string ID) //FlowLayoutPanel layout
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
                xtratabparent.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Colibri", 9, System.Drawing.FontStyle.Bold);
                xtratabparent.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 8, System.Drawing.FontStyle.Regular);
                XtraTabPage xtratab = new XtraTabPage();
                xtratab.Name = ID;
                xtratab.Text = name;
                if (ID.Contains("nhh") && ID.IndexOf("h") > 0)
                    xtratab.Tag = ID.Substring(ID.IndexOf("h") + 1);
                if (ID.Contains("khuvuc") && ID.IndexOf("c") > 0)
                    xtratab.Tag = ID.Substring(ID.IndexOf("c") + 1);
                //xtratab.Controls.Add(layout);
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


        public void loadLocBan(int TrangThai)
        {
            XtraTabPage tab = xtraTabControlDanhSach.TabPages[xtraTabControlDanhSach.SelectedTabPageIndex];
            FlowLayoutPanel flayout = tab.Controls[0] as FlowLayoutPanel;
            foreach (object item in flayout.Controls)
            {
                SimpleButton spbtn = item as SimpleButton;
                DTO_BAN ban = spbtn.Tag as DTO_BAN;
                if (ban.Trangthai == 4)
                    loadMotCaiBan(ban.Id, spbtn);

                if (TrangThai < 0)
                    spbtn.Visible = true;
                else
                    if (ban.Trangthai == TrangThai)
                    {
                        spbtn.Visible = true;
                    }
                    else
                    {
                        spbtn.Visible = false;
                    }
            }
        }




        //lay SimpleButton ban tu mot idBan
        //SimpleButton btnsp = xtraTabControlDanhSach.TabPages[xtraTabControlDanhSach.SelectedTabPageIndex].Controls.Find("butn" + IDBan, true)[0] as SimpleButton;
        //XtraMessageBox.Show("Bạn chưa chọn bàn!!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

    }
}