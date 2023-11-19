using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Transcript_Request")]
    public partial class TranscriptRequest
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(250)]
        public string? Email { get; set; }
        [Column("Remita_rrr")]
        [StringLength(150)]
        public string? RemitaRrr { get; set; }
        [Column("Final_cgpa", TypeName = "decimal(18, 2)")]
        public decimal? FinalCgpa { get; set; }
        [Column("SUpload")]
        public int? Supload { get; set; }
        [Column("SSend")]
        public int? Ssend { get; set; }
        [Column("SStatus")]
        public int? Sstatus { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("schoolid")]
        public int? Schoolid { get; set; }
    }
}
