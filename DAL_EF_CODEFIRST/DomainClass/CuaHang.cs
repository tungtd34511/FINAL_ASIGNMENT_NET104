using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //-- CuaHang
    //CREATE TABLE CuaHang(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    Ma VARCHAR(20) UNIQUE,
    //    Ten NVARCHAR(50) DEFAULT NULL,
    //    DiaChi NVARCHAR(100) DEFAULT NULL,
    //    ThanhPho NVARCHAR(50) DEFAULT NULL,
    //    QuocGia NVARCHAR(50) DEFAULT NULL
    //)
    public class CuaHang 
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50), Required]
        public string Ten { get; set; }
        [StringLength(100), Required]
        public string DiaChi { get; set; }
        [StringLength(50), Required]
        public string ThanhPho { get; set; }
        [StringLength(50), Required]
        public string QuocGia { get; set; }

    }
}
