using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("notOnJamb20162017")]
    public partial class NotOnJamb20162017
    {
        [Column("S/N")]
        [StringLength(255)]
        public string? SN { get; set; }
        [Column("UTMENUMBER")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string? Name { get; set; }
        [Column("PROGRAM")]
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("JAMB SCORE")]
        [StringLength(255)]
        public string? JambScore { get; set; }
        [Column("JAMB GRADE")]
        [StringLength(255)]
        public string? JambGrade { get; set; }
        [Column("O-LEVEL SCORE")]
        [StringLength(255)]
        public string? OLevelScore { get; set; }
        [Column("AGGREGATE")]
        [StringLength(255)]
        public string? Aggregate { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
