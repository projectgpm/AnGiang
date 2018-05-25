﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnGiang.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class AnGiangEntities : DbContext
    {
        public AnGiangEntities()
            : base("name=AnGiangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ccChamCong> ccChamCongs { get; set; }
        public DbSet<ccChiTiet> ccChiTiets { get; set; }
        public DbSet<ccKyHieu> ccKyHieux { get; set; }
        public DbSet<ccXemChamCong> ccXemChamCongs { get; set; }
        public DbSet<dvChuyenMon> dvChuyenMons { get; set; }
        public DbSet<dvDonVi> dvDonVis { get; set; }
        public DbSet<dvPhongBan> dvPhongBans { get; set; }
        public DbSet<lgBangLuong> lgBangLuongs { get; set; }
        public DbSet<lgLuong> lgLuongs { get; set; }
        public DbSet<lskLoaiSuKien> lskLoaiSuKiens { get; set; }
        public DbSet<lskSuKien> lskSuKiens { get; set; }
        public DbSet<nvChucDanh> nvChucDanhs { get; set; }
        public DbSet<nvDanhMucCD> nvDanhMucCDs { get; set; }
        public DbSet<nvNhanVien> nvNhanViens { get; set; }
        public DbSet<tlDinhMuc> tlDinhMucs { get; set; }
        public DbSet<TrinhDo> TrinhDoes { get; set; }
    
        public virtual int pr_bangLuongTongHop(Nullable<int> iDDonVi, Nullable<int> iDNhanVien, Nullable<int> thang, Nullable<int> nam)
        {
            var iDDonViParameter = iDDonVi.HasValue ?
                new ObjectParameter("IDDonVi", iDDonVi) :
                new ObjectParameter("IDDonVi", typeof(int));
    
            var iDNhanVienParameter = iDNhanVien.HasValue ?
                new ObjectParameter("IDNhanVien", iDNhanVien) :
                new ObjectParameter("IDNhanVien", typeof(int));
    
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("Nam", nam) :
                new ObjectParameter("Nam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_bangLuongTongHop", iDDonViParameter, iDNhanVienParameter, thangParameter, namParameter);
        }
    
        public virtual ObjectResult<string> pr_LayChiTietChamCong(Nullable<int> ngay, Nullable<long> iDChamCong)
        {
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("Ngay", ngay) :
                new ObjectParameter("Ngay", typeof(int));
    
            var iDChamCongParameter = iDChamCong.HasValue ?
                new ObjectParameter("IDChamCong", iDChamCong) :
                new ObjectParameter("IDChamCong", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("pr_LayChiTietChamCong", ngayParameter, iDChamCongParameter);
        }
    
        public virtual int pr_LoadChamCong(Nullable<long> iDChamCong)
        {
            var iDChamCongParameter = iDChamCong.HasValue ?
                new ObjectParameter("IDChamCong", iDChamCong) :
                new ObjectParameter("IDChamCong", typeof(long));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_LoadChamCong", iDChamCongParameter);
        }
    
        public virtual int pr_ThemChamCong(Nullable<long> iDNhanVien, Nullable<int> thang, Nullable<int> nam, Nullable<int> soNgay, Nullable<double> soNgayNghi, Nullable<double> huongLuong)
        {
            var iDNhanVienParameter = iDNhanVien.HasValue ?
                new ObjectParameter("IDNhanVien", iDNhanVien) :
                new ObjectParameter("IDNhanVien", typeof(long));
    
            var thangParameter = thang.HasValue ?
                new ObjectParameter("Thang", thang) :
                new ObjectParameter("Thang", typeof(int));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("Nam", nam) :
                new ObjectParameter("Nam", typeof(int));
    
            var soNgayParameter = soNgay.HasValue ?
                new ObjectParameter("SoNgay", soNgay) :
                new ObjectParameter("SoNgay", typeof(int));
    
            var soNgayNghiParameter = soNgayNghi.HasValue ?
                new ObjectParameter("SoNgayNghi", soNgayNghi) :
                new ObjectParameter("SoNgayNghi", typeof(double));
    
            var huongLuongParameter = huongLuong.HasValue ?
                new ObjectParameter("HuongLuong", huongLuong) :
                new ObjectParameter("HuongLuong", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemChamCong", iDNhanVienParameter, thangParameter, namParameter, soNgayParameter, soNgayNghiParameter, huongLuongParameter);
        }
    
        public virtual int pr_ThemChiTiet(Nullable<long> iDKyHieu, Nullable<long> iDChamCong, Nullable<int> ngay, Nullable<int> ngayNghi)
        {
            var iDKyHieuParameter = iDKyHieu.HasValue ?
                new ObjectParameter("IDKyHieu", iDKyHieu) :
                new ObjectParameter("IDKyHieu", typeof(long));
    
            var iDChamCongParameter = iDChamCong.HasValue ?
                new ObjectParameter("IDChamCong", iDChamCong) :
                new ObjectParameter("IDChamCong", typeof(long));
    
            var ngayParameter = ngay.HasValue ?
                new ObjectParameter("Ngay", ngay) :
                new ObjectParameter("Ngay", typeof(int));
    
            var ngayNghiParameter = ngayNghi.HasValue ?
                new ObjectParameter("NgayNghi", ngayNghi) :
                new ObjectParameter("NgayNghi", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemChiTiet", iDKyHieuParameter, iDChamCongParameter, ngayParameter, ngayNghiParameter);
        }
    }
}
