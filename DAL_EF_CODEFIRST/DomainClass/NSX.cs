using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL_EF_CODEFIRST.DomainClass
{
    //CREATE TABLE NSX(
    //        Id UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
    //        Ma VARCHAR(20) UNIQUE,
    //        Ten NVARCHAR(30)
    //    )
    [Table("NSX")]
    [Index(nameof(Ma), IsUnique = true)]
    public class NSX
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        public string Ma { get; set; }
        [StringLength(30)]
        public string Ten { get; set; }
    }
}
