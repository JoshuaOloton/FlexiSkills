using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Outsssss")]
    public partial class Outsssss
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Key]
        [Column("UTMENUMBER")]
        [StringLength(255)]
        public string Utmenumber { get; set; } = null!;
        [Column("NAME")]
        [StringLength(255)]
        public string? Name { get; set; }
        [Column("PROGRAM")]
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("AGGREGATE")]
        [StringLength(255)]
        public string? Aggregate { get; set; }
        [Column("cutoff")]
        [StringLength(255)]
        public string? Cutoff { get; set; }
    }
}
