using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostResultsUtme")]
    public partial class PostResultsUtme
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string UtmeNumber { get; set; } = null!;
        public int Score { get; set; }
        public int Aggregate { get; set; }
        public int ResultCount { get; set; }
        [Column(TypeName = "text")]
        public string? Remarks { get; set; }
        public int? JambScoreGrade { get; set; }
    }
}
