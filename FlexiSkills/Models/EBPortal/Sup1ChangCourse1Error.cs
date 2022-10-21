using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Sup1_ChangCourse1_error")]
    public partial class Sup1ChangCourse1Error
    {
        [StringLength(255)]
        public string? Sn { get; set; }
        [Key]
        [Column("UTMENumber")]
        [StringLength(255)]
        public string Utmenumber { get; set; } = null!;
        [StringLength(255)]
        public string? Cosid { get; set; }
        [StringLength(255)]
        public string? Criteria { get; set; }
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
