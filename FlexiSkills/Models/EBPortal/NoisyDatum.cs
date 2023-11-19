using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class NoisyDatum
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [StringLength(50)]
        public string? ExamName { get; set; }
        [StringLength(50)]
        public string? ExamYear { get; set; }
        [StringLength(50)]
        public string? ExamNumber { get; set; }
        [StringLength(50)]
        public string? ExamMonth { get; set; }
        public int? Status { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
