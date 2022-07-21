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
    public class CuaHang // pulic class để còn gọi và khai báo lớp
    {
        [Key]//set khóa chính
        public Guid Id { get; set; }
        [StringLength(20)]//set độ dài cho kiểu ký tự string là 20
        public string Ma { get; set; }
        [StringLength(50), Required,DefaultValue(null)] //string là 50, set cho đối tượng được phép null
        public string Ten { get; set; }
        [StringLength(100), Required, DefaultValue(null)]
        public string DiaChi { get; set; }
        [StringLength(50), Required, DefaultValue(null)]
        public string ThanhPho { get; set; }
        [StringLength(50), Required, DefaultValue(null)]
        public string QuocGia { get; set; }

    }
}
