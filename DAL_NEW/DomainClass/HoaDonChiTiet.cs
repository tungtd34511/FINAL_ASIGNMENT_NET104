using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_NEW.DomainClass
{
    [Table("HoaDonChiTiet")]
    public class HoaDonChiTiet
    {
        [Key]
        public Guid MaHDCT { get; set; }
        public Guid MaHD { get; set; }
        public HoaDon HoaDon { get; set; }
        public Guid MaCTSP { get; set; }
        public ChiTietSP CtSp { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public int GiamGia { get; set; }
        public decimal ThanhTien { get; set; }
        public bool TrangThai { get; set; }
        public string GHiChu { get; set; }
    }
}
