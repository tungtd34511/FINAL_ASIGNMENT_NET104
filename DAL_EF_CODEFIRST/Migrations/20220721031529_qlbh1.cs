using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL_EF_CODEFIRST.Migrations
{
    public partial class qlbh1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuaHangs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DongSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongSP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NSX",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NSX", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    TenDem = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Họ = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CuaHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChucVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdGuiBC = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GuiBCId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_CuaHangs_CuaHangId",
                        column: x => x.CuaHangId,
                        principalTable: "CuaHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NhanVien_NhanVien_GuiBCId",
                        column: x => x.GuiBCId,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSP",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SanPhamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NsxId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MauSacId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdDongSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DongSPId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NamBH = table.Column<int>(type: "int", nullable: true),
                    MoTA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_DongSP_DongSPId",
                        column: x => x.DongSPId,
                        principalTable: "DongSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_MauSac_MauSacId",
                        column: x => x.MauSacId,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_NSX_NsxId",
                        column: x => x.NsxId,
                        principalTable: "NSX",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ChiTietSP_SanPham_SanPhamId",
                        column: x => x.SanPhamId,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newsequentialid()"),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ma = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayShip = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GioHangChiTiet",
                columns: table => new
                {
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GioHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChiTietSpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHangChiTiet", x => new { x.IdChiTietSP, x.IdGioHang });
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_ChiTietSP_ChiTietSpId",
                        column: x => x.ChiTietSpId,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GioHangChiTiet_GioHang_GioHangId",
                        column: x => x.GioHangId,
                        principalTable: "GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChiTietSpId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.IdChiTietSP, x.IdHoaDon });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietSP_ChiTietSpId",
                        column: x => x.ChiTietSpId,
                        principalTable: "ChiTietSP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_DongSPId",
                table: "ChiTietSP",
                column: "DongSPId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_MauSacId",
                table: "ChiTietSP",
                column: "MauSacId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_NsxId",
                table: "ChiTietSP",
                column: "NsxId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSP_SanPhamId",
                table: "ChiTietSP",
                column: "SanPhamId");

            migrationBuilder.CreateIndex(
                name: "IX_ChucVu_Ma",
                table: "ChucVu",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DongSP_Ma",
                table: "DongSP",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_KhachHangId",
                table: "GioHang",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_Ma",
                table: "GioHang",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_ChiTietSpId",
                table: "GioHangChiTiet",
                column: "ChiTietSpId");

            migrationBuilder.CreateIndex(
                name: "IX_GioHangChiTiet_GioHangId",
                table: "GioHangChiTiet",
                column: "GioHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangId",
                table: "HoaDon",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_Ma",
                table: "HoaDon",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienId",
                table: "HoaDon",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_ChiTietSpId",
                table: "HoaDonChiTiet",
                column: "ChiTietSpId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_HoaDonId",
                table: "HoaDonChiTiet",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_Ma",
                table: "KhachHang",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MauSac_Ma",
                table: "MauSac",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_ChucVuId",
                table: "NhanVien",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_CuaHangId",
                table: "NhanVien",
                column: "CuaHangId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_GuiBCId",
                table: "NhanVien",
                column: "GuiBCId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_Ma",
                table: "NhanVien",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NSX_Ma",
                table: "NSX",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_Ma",
                table: "SanPham",
                column: "Ma",
                unique: true,
                filter: "[Ma] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GioHangChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "ChiTietSP");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "DongSP");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "NSX");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "CuaHangs");
        }
    }
}
