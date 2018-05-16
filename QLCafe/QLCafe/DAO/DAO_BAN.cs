using QLCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCafe.DAO
{
    public class DAO_BAN
    {
        public List<DTO_BAN> LoadTableList(DataTable data)
        {
            List<DTO_BAN> tablelist = new List<DTO_BAN>();
            foreach (DataRow item in data.Rows)
            {
                DTO_BAN table = new DTO_BAN(item);
                tablelist.Add(table);
            }
            return tablelist;
        }
        public DataTable DanhSachBan(string IDKhuVuc)
        {
            string sTruyVan = string.Format(@"SELECT * FROM [CF_Ban] WHERE IDKhuVuc = {0} ", IDKhuVuc);
            DataTable data = new DataTable();
            data = DataProvider.TruyVanLayDuLieu(sTruyVan);
            return data;
        }
        public static int ThongKeBan(string IDChiNhanh, int TrangThai)
        {
            string sTruyVan = string.Format(@"SELECT * FROM [CF_Ban] WHERE IDChiNhanh = {0} AND [TrangThai] = {1}", IDChiNhanh, TrangThai);
            DataTable data = new DataTable();
            data = DataProvider.TruyVanLayDuLieu(sTruyVan);
            return data.Rows.Count;
        }
        private static DAO_BAN instance;

        public static DAO_BAN Instance
        {
            get { if (instance == null) instance = new DAO_BAN(); return DAO_BAN.instance; }
            private set { DAO_BAN.instance = value; }
        }
        private DAO_BAN() { }
    }
}
