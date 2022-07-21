using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //-- KhachHang
    //CREATE TABLE KhachHang(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    Ma VARCHAR(20) UNIQUE,
    //    Ten NVARCHAR(30),
    //    TenDem NVARCHAR(30) DEFAULT NULL,
    //    Ho NVARCHAR(30) DEFAULT NULL,
    //    NgaySinh DATE DEFAULT NULL,
    //    Sdt VARCHAR(30) DEFAULT NULL,
    //    DiaChi NVARCHAR(100) DEFAULT NULL,
    //    ThanhPho NVARCHAR(50) DEFAULT NULL,
    //    QuocGia NVARCHAR(50) DEFAULT NULL,
    //    MatKhau VARCHAR(MAX) DEFAULT NULL
    //)
    [Table("KhachHang")]
    [Index(nameof(Ma),IsUnique = true)]
    public class KhachHang
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
        [StringLength(30),DefaultValue(null), Required]
        public string TenDem { get; set; }
        [StringLength(30), DefaultValue(null), Required]
        public string Ho { get; set; }
        public DateTime? NgaySinh { get; set; }
        [StringLength(30), DefaultValue(null), Required]
        public string Sdt { get; set; }
        [StringLength(100),DefaultValue(null), Required]
        public string DiaChi { get; set; }
        [StringLength(50), DefaultValue(null), Required]
        public string ThanhPho { get; set; }
        [StringLength(50), DefaultValue(null), Required]
        public string QuocGia { get; set; }
        [ DefaultValue(null)]
        public string  MatKhau { get; set; }
        //khach hangf laf bang 1
    }
}
