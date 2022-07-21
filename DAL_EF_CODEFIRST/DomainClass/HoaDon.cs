using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //--HoaDon
    //CREATE TABLE HoaDon(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    IdKH UNIQUEIDENTIFIER,
    //    IdNV UNIQUEIDENTIFIER,
    //    Ma VARCHAR(20) UNIQUE,
    //    NgayTao DATE DEFAULT NULL,
    //    NgayThanhToan DATE DEFAULT NULL,
    //    NgayShip DATE DEFAULT NULL,
    //    NgayNhan DATE DEFAULT NULL,
    //    TinhTrang INT DEFAULT 0,
    //    TenNguoiNhan NVARCHAR(50) DEFAULT NULL,
    //    DiaChi NVARCHAR(100) DEFAULT NULL,
    //    Sdt VARCHAR(30) DEFAULT NULL,
    //)
    [Table("HoaDon")]
    [Index(nameof(Ma),IsUnique = true)]
    public class HoaDon
    {
        [Key]
        public Guid Id{ get; set; }
        // ddaang bi loi con tro -_-
        public Guid IdKH { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public Guid IdNV { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [DefaultValue(null)]
        public DateTime? NgayTao { get; set; }
        [DefaultValue(null)]
        public DateTime? NgayThanhToan { get; set; }
        [DefaultValue(null)]
        public DateTime? NgayNhan { get; set; }
        [DefaultValue(null)]
        public DateTime? NgayShip { get; set; }
        [DefaultValue(false)]
        public bool TinhTrang { get; set; }
        [StringLength(50),DefaultValue(null), Required]
        public string TenNguoiNhan { get; set; }
        [StringLength(100), DefaultValue(null), Required]
        public string DiaChi { get; set; }
        [StringLength(30), DefaultValue(null), Required]
        public string Sdt { get; set; }

    }
}
