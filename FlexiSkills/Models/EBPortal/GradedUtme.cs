using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("GradedUTME")]
    public partial class GradedUtme
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [Column("LEVEL")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Subject { get; set; } = null!;
        public int Statusid { get; set; }
    }
}
