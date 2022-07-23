using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_NEW.DomainClass
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public Guid MaHD { get; set; }
        public Guid MaKH { get; set; }
        public KhachHang KhachHang { get; set; }
        public Guid MaNV { get; set; }
        public NhanVien Nhanvien { get; set; }
        public Guid MaHTTT { get; set; }
        public DateTime NgayKhoiTao { get; set; }
        public bool TrangThai { get; set; }
        public string GhiChu { get; set; }
        public decimal TienShip { get; set; }
        
    }
}
