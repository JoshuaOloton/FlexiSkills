using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("JambErrors2")]
    public partial class JambErrors2
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Key]
        [Column("utmenum")]
        [StringLength(255)]
        public string Utmenum { get; set; } = null!;
        [Column("corsid")]
        [StringLength(255)]
        public string? Corsid { get; set; }
        [StringLength(255)]
        public string? Critieria { get; set; }
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
