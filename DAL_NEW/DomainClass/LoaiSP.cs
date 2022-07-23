using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL_NEW.DomainClass
{
    [Table("LoaiSP")]
    public class LoaiSP
    {
        [Key]
        public Guid MaLoai{ get; set; }
        public bool TrangThai { get; set; }
        public string TenLoai { get; set; }
    }
}
