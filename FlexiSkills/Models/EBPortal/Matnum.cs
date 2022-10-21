using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("MAtnum")]
    public partial class Matnum
    {
        [Column("matricnum")]
        [StringLength(255)]
        public string? Matricnum { get; set; }
        [Column("appnum")]
        [StringLength(255)]
        public string? Appnum { get; set; }
    }
}
