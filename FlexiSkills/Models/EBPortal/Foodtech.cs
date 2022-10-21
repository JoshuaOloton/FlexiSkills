using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Foodtech")]
    public partial class Foodtech
    {
        [Key]
        [Column("appnum")]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [Column("CREATEDBY")]
        [StringLength(255)]
        public string? Createdby { get; set; }
        [Column("SURNAME")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
    }
}
