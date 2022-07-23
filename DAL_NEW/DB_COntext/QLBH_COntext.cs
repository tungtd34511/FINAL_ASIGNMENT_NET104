using System;
using System.Collections.Generic;
using System.Text;
using DAL_NEW.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace DAL_NEW.DB_COntext
{
    public class QLBH_COntext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=TUNGHACK\\SQLEXPRESS;Initial Catalog=EF_3_DUNGNA30;Integrated Security=True");
            }
        }

        public DbSet<ChiTietSP> ChiTietSps { get; private set; }
        public DbSet<HoaDon> HoaDons { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<LoaiSP> LoaiSps { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<KhuyenMai>KhuyenMais { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
