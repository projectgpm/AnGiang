using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using QLCafe.DTO;

namespace QLCafe.DAO
{
    class DataProvider
    {

        #region Phần DataProvider Nhớm trước
        // Thực hiện truy vấn trả về bảng dữ liệu
        /// <summary>
        /// Datatable
        /// </summary>
        /// <param name="sTruyVan"></param>
        /// <returns></returns>
        public static DataTable TruyVanLayDuLieu(string sTruyVan)
        {
            SqlConnection conn = new SqlConnection();
            DAO_ConnectSQL connect = new DAO_ConnectSQL();
            conn = connect.Connect();
            if (conn == null)
                return null;
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Thực hiện truy vấn không trả về dữ liệu
        /// <summary>
        /// insert,update,delete
        /// </summary>
        /// <param name="sTruyVan"></param>
        /// <returns></returns>
        public static bool TruyVanKhongLayDuLieu(string sTruyVan)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                DAO_ConnectSQL connect = new DAO_ConnectSQL();
                conn = connect.Connect();
                SqlCommand cm = new SqlCommand(sTruyVan, conn);
                cm.ExecuteNonQuery();
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region Phần DataProvider Vũ
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null)  instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        /// <summary>
        /// Đây là câu để kết nói đến cơ sở dữ liệu
        /// </summary>
        private string connectionSTR = new DAO_ConnectSQL().ConnectString();
        public string ConnectionString = new DAO_ConnectSQL().ConnectString();
       
        /// <summary>
        /// Dùng để thực thi câu lệnh truy vấn và trả về DataTable 
        /// </summary>
        /// <param name="query">Câu truy vấn</param>
        /// <param name="parameter">Các phần cấu trúc có trong Proc</param>
        /// <returns>Trả về một mã kiểu dữ liệu là DataTable</returns>
        public DataTable ExecuteQuery(string query, object[] parameter=null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close(); 
            }
            return data;
        }
      
        /// <summary>
        /// Dùng để thực thi câu lệnh truy vấn và trả về int 
        /// </summary>
        /// <param name="query">Câu truy vấn</param>
        /// <param name="parameter">Các phần cấu trúc có trong Proc</param>
        /// <returns>Trả về một mã kiểu dữ liệu là int</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        public int ExecuteNoneQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Dùng để thực thi câu lệnh truy vấn 
        /// </summary>
        /// <param name="query">Câu truy vấn</param>
        /// <param name="parameter">Các phần cấu trúc có trong Proc</param>
        /// <returns>Trả về một mã kiểu dữ liệu là object</returns>
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Dùng để tạo mới một mã, nếu trong dách sách mã có một mã bắt kỳ bị xóa sẽ được khởi tạo lại
        /// </summary>
        /// <param name="tb">truyền vào một bảng để tạo mã DataTable</param>
        /// <param name="keys">truyền vào vị trí của cột cần tạo mã int</param>
        /// <param name="max">mã lớn nhất có trong bảng int</param>
        /// <returns>Trả về một mã kiểu dữ liệu là int</returns>
        public int CreateKey(DataTable tb,int keys, int max)
        {
		            int Ma=0;
		            if(tb.Rows.Count>0){
		            int kt =  max-tb.Rows.Count;
		            int kt3 = kt ;
		            int sotruoc = 1 ;
			            foreach(DataRow r in tb.Rows)
			            {
				            int sosau= int.Parse(r[keys].ToString());
				            if(sosau!=sotruoc)
				            {
					            int kt2 = (sosau - (sotruoc + 1));
					            if(kt2>0)
						            {
						            while(kt2>0)
							            {
							            ++sotruoc;
                                        Ma = sotruoc;
							            kt--;
							            kt2--;
							            }
							            sotruoc=sosau;
						            }
				            }sotruoc=sosau;
				            if(kt==0)
				            break;
			            }
		            }
                    if (Ma == 0)
                        return ++max;
                    return Ma;
		}

        /// <summary>
        /// Dùng để kiểm tra kết nối đến cơ sở dữ liệu
        /// </summary>
        /// <returns>Trả về kiểu dữ liệu Boolean</returns>
        public Boolean CheckConnection()
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                // output the error to see what's going on        
                XtraMessageBox.Show(string.Format("Không thể kết nối đến cơ sở dữ liệu!\nMã lỗi: {0}", ex.Message), "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Dùng để thay đổi số lượng của một hàng hóa khi nó đã tồn tại trong hóa đơn
        /// </summary>
        /// <param name="KiemTra"></param>
        /// <param name="IDHoaDon"></param>
        /// <param name="IDHangHoa"></param>
        /// <param name="Soluong"></param>
        /// <param name="NguoiDung"></param>
        public void ThayDoiSoLuong(int KiemTra, string IDHoaDon, string IDHangHoa, int Soluong, DTO_DangNhap NguoiDung)
        {
            DataProvider.Instance.ExecuteNoneQuery("pr_updateSL @KiemTra , @IDHoaDon , @IDHangHoa , @IDNhanVien , @SoLuong", new object[] { KiemTra, IDHoaDon, IDHangHoa, NguoiDung.Id, Soluong });
        }

        /// <summary>
        /// Dùng để thêm mới một món ăn vào hóa đơn
        /// </summary>
        /// <param name="IDBan"></param>
        /// <param name="IDHangHoa"></param>
        /// <param name="Soluong"></param>
        /// <param name="NguoiDung"></param>
        public void GoiMon(int IDBan, int IDHangHoa, int Soluong, DTO_DangNhap NguoiDung)
        {
            DataProvider.Instance.ExecuteNoneQuery("rp_GoiMon @IDBan , @IDHangHoa , @SoLuong , @IDNhanVien", new object[] { IDBan, IDHangHoa, Soluong, NguoiDung.Id});
        }

        /// <summary>
        /// Dùng để chuyển bàn
        /// </summary>
        /// <param name="IDBan1">Truyền vào mã bàn 1 Int</param>
        /// <param name="IDBan2">Truyền vào mã bàn 2 Int</param>
        /// <param name="IDNhanVien">Truyền vào mã nhân viên Int</param>
        public void ChuyenBan(int IDBan1, int IDBan2,int IDNhanVien)
        {
            DataProvider.Instance.ExecuteQuery("pr_ChuyenBan @IDBan1 , @IDBan2 , @IDNhanVien", new object[] { IDBan1, IDBan2, IDNhanVien });
        }

        /// <summary>
        /// Dùng để gộp bàn
        /// </summary>
        /// <param name="IDBan1">Truyền vào mã bàn 1 Int</param>
        /// <param name="IDBan2">Truyền vào mã bàn 2 Int</param>
        /// <param name="IDNhanVien">Truyền vào mã nhân viên Int</param>
        public void GopBan(int IDBan1, int IDBan2,int IDNhanVien)
        {
            DataProvider.Instance.ExecuteNoneQuery("pr_GopBan @IDBan1 , @IDBan2 , @IDNhanVien", new object[] { IDBan1, IDBan2, IDNhanVien });
        }

        /// <summary>
        /// Dùng để ghép các bàn lại thành một bàn
        /// </summary>
        /// <param name="IDBan1"></param>
        /// <param name="IDBan2"></param>
        /// <param name="IDNhanVien"></param>
        /// <param name="KiemTra">1:Ghép 0: Tách</param>
        public void GhepBan(int IDBan1, int IDBan2, int IDNhanVien,int KiemTra)
        {
            DataProvider.Instance.ExecuteNoneQuery("pr_GhepBan @IDBan1 , @IDBan2 , @IDNhanVien , @KiemTra", new object[] { IDBan1, IDBan2, IDNhanVien, KiemTra });
        }

        /// <summary>
        /// Dùng để thêm lịch sử thao tác
        /// </summary>
        /// <param name="HoatDong"></param>
        /// <param name="ChiTiet"></param>
        /// <param name="IDNhanVien"></param>
        public void ThemLichSuThaoTac(string HoatDong, string ChiTiet, int IDNhanVien)
        {
            string sql = string.Format("INSERT INTO [CF_LichSuThaoTac]([HoatDong],[ThoiGian],[ChiTiet],[IDNhanVien])VALUES(N'{0}',GETDATE(),N'{1}',{2})",HoatDong,ChiTiet,IDNhanVien);
            DataProvider.Instance.ExecuteNoneQuery(sql);
        }

        /// <summary>
        /// Dùng để thanh toán một hóa đơn
        /// </summary>
        /// <param name="IDHoaDon"></param>
        /// <param name="HinhThucThanhToan"></param>
        /// <param name="SoTienKhachDua"></param>
        /// <param name="ThoiLai"></param>
        public void ThanhToan(string IDHoaDon, string IDBan, string HinhThucThanhToan, float SoTienKhachDua, float ThoiLai, int IDNhanVien)
        {
            DataProvider.Instance.ExecuteNoneQuery("pr_ThanhToan @IDHoaDon , @HinhThucGiamGia , @KhachThanhToan , @TienThua , @IDBan , @IDNhanVien",
                new object[]{IDHoaDon, HinhThucThanhToan, SoTienKhachDua, ThoiLai, IDBan, IDNhanVien});
        }

        /// <summary>
        /// Dùng để cập nhật giảm giá cho hóa đơn
        /// </summary>
        /// <param name="IDHoaDon"></param>
        /// <param name="phuthu"></param>
        /// <param name="giamgia"></param>
        public void GiamGia(string IDHoaDon, float phuthu, float giamgia)
        {
            DataProvider.Instance.ExecuteNoneQuery("pr_ThemGiamGia @IDHoaDon , @GiamGia , @TienGiamGia",new object[]{IDHoaDon,giamgia,phuthu});
        }

        /// <summary>
        /// Dùng để khôi phục lại hóa đơn đã thanh toán
        /// </summary>
        /// <param name="IDHoaDon"></param>
        /// <param name="IDBan"></param>
        public void HoanTac(int IDBan)
        {
            DataProvider.Instance.ExecuteNoneQuery("pr_KhoiPhucHD @IDBan", new object[]{IDBan});
        }

        /// <summary>
        /// Dùng để kiểm tra một bản có nằm trong cơ sở dữ liệu hay không
        /// </summary>
        /// <param name="TenBang"></param>
        /// <returns></returns>
        public int KiemDuLieuTonTaiTrongCSDL(string TenBang)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            connection.Open();
            SqlCommand cmd = new SqlCommand(@"IF EXISTS(SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @table) SELECT 1 ELSE SELECT 0", connection);
            cmd.Parameters.Add("@table", SqlDbType.NVarChar).Value = TenBang;
            int check = (int)cmd.ExecuteScalar();
            connection.Close();
            return check;

        }

        public void checkKeyPad(KeyEventArgs e)
        {
            e.SuppressKeyPress = !((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode == Keys.Back) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 || e.KeyCode == Keys.Back));
        }
        #endregion

    }
}
