using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //-- NhanVien
    //CREATE TABLE NhanVien(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    Ma VARCHAR(20) UNIQUE,
    //    Ten NVARCHAR(30) DEFAULT NULL,
    //    TenDem NVARCHAR(30) DEFAULT NULL,
    //    Ho NVARCHAR(30) DEFAULT NULL,
    //    GioiTinh NVARCHAR(10) DEFAULT NULL,
    //    NgaySinh DATE DEFAULT NULL,
    //    DiaChi NVARCHAR(100) DEFAULT NULL,
    //    Sdt VARCHAR(30) DEFAULT NULL,
    //    MatKhau VARCHAR(MAX) DEFAULT NULL,
    //    IdCH UNIQUEIDENTIFIER,
    //    IdCV UNIQUEIDENTIFIER,
    //    IdGuiBC UNIQUEIDENTIFIER,
    //    TrangThai INT DEFAULT 0
    //)
    [Table("NhanVien")]
    [Index(nameof(Ma),IsUnique = true)]
    public class NhanVien
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30), Required]
        public string Ten { get; set; }
        [StringLength(30), Required]
        public string TenDem { get; set; }
        [StringLength(30), Required]
        public string Họ { get; set; }
        [StringLength(10), Required]
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; } 
        [StringLength(100), Required]
        public string DiaChi { get; set; }
        [StringLength(30), Required]
        public string Sdt { get; set; }
        [Required] 
        public string MatKhau { get; set; }
        public Guid IdCH { get; set; }
        public virtual CuaHang CuaHang { get; set; }
        public Guid IdCV { get; set; }
        public virtual ChucVu ChucVu { get; set; } 
        public Guid IdGuiBC { get; set; }
        public virtual NhanVien GuiBC { get; set; }
        public int TrangThai { get; set; }
    }
}
