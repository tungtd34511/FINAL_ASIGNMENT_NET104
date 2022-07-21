using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //IdGioHang UNIQUEIDENTIFIER,
    //    IdChiTietSP UNIQUEIDENTIFIER,
    //SoLuong INT,
    //    DonGia DECIMAL(20,0) DEFAULT 0,
    //DonGiaKhiGiam DECIMAL(20,0) DEFAULT 0,
    //CONSTRAINT PK_GioHangCT PRIMARY KEY(IdGioHang, IdChiTietSP),
    //CONSTRAINT FK1_IdGioHang FOREIGN KEY(IdGioHang) REFERENCES GioHang(Id),
    //CONSTRAINT FK2_IdChiTietSP FOREIGN KEY(IdChiTietSP) REFERENCES ChiTietSP(Id),
    //    )
    [Table("GioHangChiTiet")]
    public class GioHangChiTiet
    {
        public Guid IdGioHang { get; set; }
        public virtual GioHang GioHang { get; set; }
        public Guid IdChiTietSP { get; set; }
        public virtual ChiTietSP ChiTietSp { get; set; }
        public int SoLuong { get; set; }
        [DefaultValue(0)]
        public decimal DonGia { get; set; }
    }
}
