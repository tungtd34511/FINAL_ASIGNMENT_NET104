﻿// <auto-generated />
using System;
using DAL_NEW.DB_COntext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL_NEW.Migrations
{
    [DbContext(typeof(QLBH_COntext))]
    [Migration("20220722123035_ql2")]
    partial class ql2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ChiTietSPKhuyenMai", b =>
                {
                    b.Property<Guid>("ChiTietSPsMaCTSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KhuyenMaisMaKM")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ChiTietSPsMaCTSP", "KhuyenMaisMaKM");

                    b.HasIndex("KhuyenMaisMaKM");

                    b.ToTable("ChiTietSPKhuyenMai");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.ChiTietSP", b =>
                {
                    b.Property<Guid>("MaCTSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GiamGia")
                        .HasColumnType("int");

                    b.Property<Guid?>("LoaiSpMaLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaChatLieu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaKichThuoc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaLoai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaCTSP");

                    b.HasIndex("LoaiSpMaLoai");

                    b.ToTable("ChiTietSP");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.HoaDon", b =>
                {
                    b.Property<Guid>("MaHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("KhachHangMaKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaHTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayKhoiTao")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("NhanvienMaNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("TienShip")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaHD");

                    b.HasIndex("KhachHangMaKH");

                    b.HasIndex("NhanvienMaNV");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("MaHDCT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CtSpMaCTSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GHiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("GiamGia")
                        .HasColumnType("int");

                    b.Property<Guid?>("HoaDonMaHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaCTSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaHDCT");

                    b.HasIndex("CtSpMaCTSP");

                    b.HasIndex("HoaDonMaHD");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.KhachHang", b =>
                {
                    b.Property<Guid>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKH")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaKH");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.KhuyenMai", b =>
                {
                    b.Property<Guid>("MaKM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GiamGia")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenKM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaKM");

                    b.ToTable("KhuyenMai");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.LoaiSP", b =>
                {
                    b.Property<Guid>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TenLoai")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("MaLoai");

                    b.ToTable("LoaiSP");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.NhanVien", b =>
                {
                    b.Property<Guid>("MaNV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.Property<string>("VaiTro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("ChiTietSPKhuyenMai", b =>
                {
                    b.HasOne("DAL_NEW.DomainClass.ChiTietSP", null)
                        .WithMany()
                        .HasForeignKey("ChiTietSPsMaCTSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL_NEW.DomainClass.KhuyenMai", null)
                        .WithMany()
                        .HasForeignKey("KhuyenMaisMaKM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.ChiTietSP", b =>
                {
                    b.HasOne("DAL_NEW.DomainClass.LoaiSP", "LoaiSp")
                        .WithMany()
                        .HasForeignKey("LoaiSpMaLoai");

                    b.Navigation("LoaiSp");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.HoaDon", b =>
                {
                    b.HasOne("DAL_NEW.DomainClass.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("KhachHangMaKH");

                    b.HasOne("DAL_NEW.DomainClass.NhanVien", "Nhanvien")
                        .WithMany()
                        .HasForeignKey("NhanvienMaNV");

                    b.Navigation("KhachHang");

                    b.Navigation("Nhanvien");
                });

            modelBuilder.Entity("DAL_NEW.DomainClass.HoaDonChiTiet", b =>
                {
                    b.HasOne("DAL_NEW.DomainClass.ChiTietSP", "CtSp")
                        .WithMany()
                        .HasForeignKey("CtSpMaCTSP");

                    b.HasOne("DAL_NEW.DomainClass.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("HoaDonMaHD");

                    b.Navigation("CtSp");

                    b.Navigation("HoaDon");
                });
#pragma warning restore 612, 618
        }
    }
}
