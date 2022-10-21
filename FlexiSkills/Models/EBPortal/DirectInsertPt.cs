using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("DirectInsert_PT")]
    public partial class DirectInsertPt
    {
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [Column("NAME")]
        [StringLength(4000)]
        public string? Name { get; set; }
        [Column("PROGRAM")]
        [StringLength(4000)]
        public string? Program { get; set; }
        [Column("OLEVEL")]
        [StringLength(4000)]
        public string? Olevel { get; set; }
        [Column("OLEVEL_MATCHEDCOURSES")]
        [StringLength(4000)]
        public string? OlevelMatchedcourses { get; set; }
        [Column("ERROR(S)")]
        [StringLength(4000)]
        public string? ErrorS { get; set; }
        [Column("OLEVELSCORE")]
        public int? Olevelscore { get; set; }
        [Column("STATUS")]
        [StringLength(4000)]
        public string? Status { get; set; }
        [Column("COUNT")]
        public int? Count { get; set; }
        [Column("CERTIFICATEMISMATCH")]
        [StringLength(4000)]
        public string? Certificatemismatch { get; set; }
        [Column("PREVIOUSPROGRAM")]
        [StringLength(4000)]
        public string? Previousprogram { get; set; }
    }
}
