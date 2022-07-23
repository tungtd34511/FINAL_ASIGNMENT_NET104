using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_NEW.DomainClass
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        public Guid MaNV { get; set; }
        
        public string TenNV { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool TrangThai { get; set; }
        public string Email { get; set; }
        public string VaiTro { get; set; }
        public string MatKhau { get; set; }
    }
}
