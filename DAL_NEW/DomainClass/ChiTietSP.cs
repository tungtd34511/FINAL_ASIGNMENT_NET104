using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_NEW.DomainClass
{
    [Table("ChiTietSP")]
    public class ChiTietSP
    {
        public ChiTietSP()
        {
            this.KhuyenMais = new HashSet<KhuyenMai>();
        }
        [Key]
        
        public Guid MaCTSP { get; set; }
        public Guid MaSP { get; set; }
        public Guid MaLoai { get; set; }
        public LoaiSP LoaiSp { get; set; }
        public Guid MaMauSac { get; set; }
        public Guid MaKichThuoc { get; set; }
        public Guid MaChatLieu { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
        public int GiamGia { get; set; }
        public ICollection<KhuyenMai> KhuyenMais { get; set; }
    }
}
