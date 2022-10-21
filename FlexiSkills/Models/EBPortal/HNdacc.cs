using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hNDacc")]
    public partial class HNdacc
    {
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [StringLength(255)]
        public string? Createdby { get; set; }
        [Column("ALID")]
        [StringLength(255)]
        public string? Alid { get; set; }
        [StringLength(255)]
        public string? DateCreated { get; set; }
        [Column("SURNAME")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("OTHERNAME")]
        [StringLength(255)]
        public string? Othername { get; set; }
    }
}
