using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hostelpaydistinct")]
    public partial class Hostelpaydistinct
    {
        [Key]
        [Column("payerid")]
        [StringLength(255)]
        public string Payerid { get; set; } = null!;
        [Column("DATEGENERATED")]
        [StringLength(255)]
        public string? Dategenerated { get; set; }
    }
}
