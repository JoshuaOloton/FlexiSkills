using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Jamblga")]
    public partial class Jamblga
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("LGA")]
        [StringLength(150)]
        public string? Lga { get; set; }
        public int? Lgacode { get; set; }
    }
}
