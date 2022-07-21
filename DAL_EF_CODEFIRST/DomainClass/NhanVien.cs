using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //-- NhanVien
    //CREATE TABLE NhanVien(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    Ma VARCHAR(20) UNIQUE,
    //    Ten NVARCHAR(30) DEFAULT NULL,
    //    TenDem NVARCHAR(30) DEFAULT NULL,
    //    Ho NVARCHAR(30) DEFAULT NULL,
    //    GioiTinh NVARCHAR(10) DEFAULT NULL,
    //    NgaySinh DATE DEFAULT NULL,
    //    DiaChi NVARCHAR(100) DEFAULT NULL,
    //    Sdt VARCHAR(30) DEFAULT NULL,
    //    MatKhau VARCHAR(MAX) DEFAULT NULL,
    //    IdCH UNIQUEIDENTIFIER,
    //    IdCV UNIQUEIDENTIFIER,
    //    IdGuiBC UNIQUEIDENTIFIER,
    //    TrangThai INT DEFAULT 0
    //)
    [Table("NhanVien")]
    [Index(nameof(Ma),IsUnique = true)]
    public class NhanVien
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30), Required, DefaultValue(null)]
        public string Ten { get; set; }
        [StringLength(30), Required, DefaultValue(null)]
        public string TenDem { get; set; }
        [StringLength(30), Required, DefaultValue(null)]
        public string Họ { get; set; }
        [StringLength(10), Required, DefaultValue(null)]
        public string GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; } // dấu hỏi chấm là có thể null ko áp dụng cho string
        [StringLength(100), Required, DefaultValue(null)]
        public string DiaChi { get; set; }
        [StringLength(30), Required, DefaultValue(null)]
        public string Sdt { get; set; }
        [Required, DefaultValue(null)] //vì mật khảu là max nên ko để giới hạn 
        public string MatKhau { get; set; }
        public Guid IdCH { get; set; }
        public virtual CuaHang CuaHang { get; set; }
        public Guid IdCV { get; set; }//IdCV có thể có hoặc không nhưng cần có để có thể có dữ liệu tham chiếu đến bảng chức vụ
        public virtual ChucVu ChucVu { get; set; } // tạo đối tượng tham chiếu để tạo khóa ngoại
        public Guid IdGuiBC { get; set; }
        public virtual NhanVien GuiBC { get; set; } // nhân viên tự tham chiếu đến chính mình
        [DefaultValue(0)]
        public int TrangThai { get; set; }//bool sẽ tự chuyển về bit 0,1 true false neus dể giống Csdl thì để int
    }
}
