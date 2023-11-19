using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("conveyregrets2")]
    public partial class Conveyregrets2
    {
        [Key]
        [Column("sn")]
        [StringLength(255)]
        public string Sn { get; set; } = null!;
        [Column("appnum")]
        [StringLength(255)]
        public string? Appnum { get; set; }
    }
}
