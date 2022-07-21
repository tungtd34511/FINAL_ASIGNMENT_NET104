using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //-- ChucVu
    //CREATE TABLE ChucVu(
    //    Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //    Ma VARCHAR(20) UNIQUE,
    //    Ten NVARCHAR(50) DEFAULT NULL
    //)
    [Table("ChucVu")]//set name table
    [Index(nameof(Ma),IsUnique = true)] // set unique
    public class ChucVu
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(50),Required] 
        public string Ten { get; set; }
    }
}
