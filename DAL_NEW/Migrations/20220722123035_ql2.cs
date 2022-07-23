using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_NEW.Migrations
{
    public partial class ql2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKH = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    MaKM = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenKM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.MaKM);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSP",
                columns: table => new
                {
                    MaLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSP", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSP",
                columns: table => new
                {
                    MaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiSpMaLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKichThuoc = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaChatLieu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSP", x => x.MaCTSP);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_LoaiSP_LoaiSpMaLoai",
                        column: x => x.LoaiSpMaLoai,
                        principalTable: "LoaiSP",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangMaKH = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhanvienMaNV = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaHTTT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NgayKhoiTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TienShip = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangMaKH",
                        column: x => x.KhachHangMaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanvienMaNV",
                        column: x => x.NhanvienMaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSPKhuyenMai",
                columns: table => new
                {
                    ChiTietSPsMaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhuyenMaisMaKM = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSPKhuyenMai", x => new { x.ChiTietSPsMaCTSP, x.KhuyenMaisMaKM });
                    table.ForeignKey(
                        name: "FK_ChiTietSPKhuyenMai_ChiTietSP_ChiTietSPsMaCTSP",
                        column: x => x.ChiTietSPsMaCTSP,
                        principalTable: "ChiTietSP",
                        principalColumn: "MaCTSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSPKhuyenMai_KhuyenMai_KhuyenMaisMaKM",
                        column: x => x.KhuyenMaisMaKM,
                        principalTable: "KhuyenMai",
                        principalColumn: "MaKM",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    MaHDCT = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonMaHD = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CtSpMaCTSP = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    GHiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.MaHDCT);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietSP_CtSpMaCTSP",
                        column: x => x.CtSpMaCTSP,
                        principalTable: "ChiTietSP",
                        principalColumn: "MaCTSP",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_HoaDonMaHD",
                        column: x => x.HoaDonMaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_LoaiSpMaLoai",
                table: "ChiTietSP",
                column: "LoaiSpMaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSPKhuyenMai_KhuyenMaisMaKM",
                table: "ChiTietSPKhuyenMai",
                column: "KhuyenMaisMaKM");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangMaKH",
                table: "HoaDon",
                column: "KhachHangMaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanvienMaNV",
                table: "HoaDon",
                column: "NhanvienMaNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_CtSpMaCTSP",
                table: "HoaDonChiTiet",
                column: "CtSpMaCTSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_HoaDonMaHD",
                table: "HoaDonChiTiet",
                column: "HoaDonMaHD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietSPKhuyenMai");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "ChiTietSP");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "LoaiSP");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");
        }
    }
}
