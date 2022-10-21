using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("yct_transcript_app")]
    public partial class YctTranscriptApp
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UndefinedMatno { get; set; }
        [StringLength(15)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ApplicationDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string PhoneNumber { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string ProgrammeType { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string TranscriptType { get; set; } = null!;
        [Column("SexID")]
        public int SexId { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("YctTranscriptApps")]
        public virtual Program Program { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("YctTranscriptApps")]
        public virtual Session Session { get; set; } = null!;
    }
}
