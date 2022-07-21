using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL_EF_CODEFIRST.DomainClass
{
    [Table("GioHang")]
    [Index(nameof(Ma), IsUnique = true)]
    public class GioHang
    {
        [Key]
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public Guid IdNV { get; set; } 
        [StringLength(20)]
        public string Ma { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public bool TinhTrang { get; set; }
        [StringLength(50), Required]
        public string TenNguoiNhan { get; set; }
        [StringLength(100), Required]
        public string DiaChi { get; set; }
        [StringLength(30),Required]
        public string Sdt { get; set; }
    }
    //CREATE TABLE GioHang(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    IdKH UNIQUEIDENTIFIER,
    //    IdNV UNIQUEIDENTIFIER,
    //    Ma VARCHAR(20) UNIQUE,
    //    NgayTao DATE DEFAULT NULL,
    //    NgayThanhToan DATE DEFAULT NULL,
    //    TenNguoiNhan NVARCHAR(50) DEFAULT NULL,
    //    DiaChi NVARCHAR(100) DEFAULT NULL,
    //    Sdt VARCHAR(30) DEFAULT NULL,
    //    TinhTrang INT DEFAULT 0
    //)
}
