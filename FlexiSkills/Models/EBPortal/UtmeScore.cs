using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class UtmeScore
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string UtmeNumber { get; set; } = null!;
        [Column("UtmeScore")]
        public int UtmeScore1 { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? SubjectCombination { get; set; }
        public int FirstChoice { get; set; }
    }
}
