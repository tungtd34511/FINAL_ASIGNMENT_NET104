using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_NEW.DomainClass
{
    [Table("KhuyenMai")]
    public class KhuyenMai
    {
        public KhuyenMai()
        {
            this.ChiTietSPs = new HashSet<ChiTietSP>();
        }
        [Key]
        public Guid MaKM { get; set; }
        public string TenKM { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool TrangThai { get; set; }
        public int GiamGia { get; set; }
        public ICollection<ChiTietSP> ChiTietSPs { get; set; }
    }
}
