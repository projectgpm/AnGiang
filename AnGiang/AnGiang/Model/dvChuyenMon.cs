//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnGiang.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class dvChuyenMon
    {
        public long IDChuyenMon { get; set; }
        public string MaChuyenMon { get; set; }
        public string TenChuyenMon { get; set; }
        public Nullable<System.DateTime> NgayTao { get; set; }
        public Nullable<System.DateTime> NgayCapNhat { get; set; }
        public Nullable<int> DaXoa { get; set; }
        public Nullable<long> DonViID { get; set; }
    
        public virtual dvDonVi dvDonVi { get; set; }
    }
}