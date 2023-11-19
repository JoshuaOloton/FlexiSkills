using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("eedmatnum1111")]
    public partial class Eedmatnum1111
    {
        [Key]
        [StringLength(255)]
        public string Matricnum { get; set; } = null!;
        [Column("LEVEL")]
        [StringLength(255)]
        public string? Level { get; set; }
    }
}
