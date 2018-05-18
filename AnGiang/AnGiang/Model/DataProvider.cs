using AnGiang.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AnGiang.Model
{
    public class DataProvider
    {
        private static DataProvider _ins;
        public static DataProvider Ins { get { if (_ins == null) _ins = new DataProvider(); return _ins; } set { _ins = value; } }

        public AnGiangEntities DB { get; set; }

        private DataProvider()
        {
            DB = new AnGiangEntities();
        }

        public void getsetDataRowInCustomerGroup(C_CustomerGroup set, C_CustomerGroup get)
        {
            if (set != null)
            {
                get.CreateAt = set.CreateAt;
                get.UpdateAt = set.UpdateAt;
                get.Name = set.Name;
                get.Note =set.Note;
                get.Discount =set.Discount;
            }
        }
    }
}
