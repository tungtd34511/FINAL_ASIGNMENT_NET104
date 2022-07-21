using System;
using System.Collections.Generic;
using System.Text;
using DAL_EF_CODEFIRST.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL_EF_CODEFIRST.DatabaseContext
{
    public class QLBH_Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=TUNGHACK\\SQLEXPRESS;Initial Catalog=EF_CodeFirst;Integrated Security=True");
                //"Data Source= Ten server;Initial Catalog= ten-database;câu hình kết nối"
            }
        }
        
        public DbSet<ChiTietSP> ChiTietSps { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<CuaHang> CuaHangs { get; set; }
        public DbSet<DongSP> DongSps { get; set; }
        public DbSet<GioHang> GioHangs { get; set; }
        public DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<NSX> Nsxes { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        //Tạo khóa chính tự sinh và liên kết giữa các bảng có 2 khóa chính bằng fluen API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChiTietSP>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<ChucVu>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<CuaHang>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<DongSP>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<GioHang>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<HoaDon>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<KhachHang>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<MauSac>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<NSX>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<ChiTietSP>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<SanPham>()
                .Property(c => c.Id)
                .HasDefaultValueSql("newsequentialid()");
            modelBuilder.Entity<GioHangChiTiet>()
                .HasKey(c => new
                {
                    c.IdChiTietSP, c.IdGioHang
                });
            modelBuilder.Entity<HoaDonChiTiet>()
                .HasKey(c => new
                {
                    c.IdChiTietSP,
                    c.IdHoaDon
                });
        }
    }
    
}
