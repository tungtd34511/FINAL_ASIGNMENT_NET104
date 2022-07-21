using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //-- ChiTietSP
    //CREATE TABLE ChiTietSP(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    IdSP UNIQUEIDENTIFIER,
    //    IdNsx UNIQUEIDENTIFIER,
    //    IdMauSac UNIQUEIDENTIFIER,
    //    IdDongSP UNIQUEIDENTIFIER,
    //    NamBH INT DEFAULT NULL,
    //    MoTa NVARCHAR(50) DEFAULT NULL,
    //    SoLuongTon INT,
    //    GiaNhap DECIMAL(20,0) DEFAULT 0,
    //    GiaBan DECIMAL(20,0) DEFAULT 0,
    //)
    [Table("ChiTietSP")]
    public class ChiTietSP 
    {
        public Guid Id { get; set; }
        public Guid IdSP { get; set; }
        public virtual SanPham SanPham { get; set; }
        public Guid IdNsx { get; set; }
        public virtual NSX Nsx { get; set; }
        public Guid IdMauSac { get; set; }
        public virtual MauSac MauSac { get; set; }
        public Guid IdDongSP { get; set; }
        public virtual DongSP DongSP { get; set; }
        public int? NamBH { get; set; }
        [Required]
        public string MoTA{ get; set; }
        public int SoLuongTon { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
    }
}
