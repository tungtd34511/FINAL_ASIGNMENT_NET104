using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //-- HoaDonChiTiet
    //CREATE TABLE HoaDonChiTiet(
    //    IdHoaDon UNIQUEIDENTIFIER,
    //    IdChiTietSP UNIQUEIDENTIFIER,
    //    SoLuong INT,
    //    DonGia DECIMAL(20,0) DEFAULT 0,
    //    CONSTRAINT PK_HoaDonCT PRIMARY KEY(IdHoaDon, IdChiTietSP),
    //    CONSTRAINT FK1 FOREIGN KEY(IdHoaDon) REFERENCES HoaDon(Id),
    //    CONSTRAINT FK2 FOREIGN KEY(IdChiTietSP) REFERENCES ChiTietSP(Id),
    //)
    [Table("HoaDonChiTiet")]
    public class HoaDonChiTiet
    {
        public Guid IdHoaDon { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public Guid IdChiTietSP { get; set; }
        public virtual ChiTietSP ChiTietSp { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
