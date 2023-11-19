using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OLevelResultsApplicant")]
    [Index("Appnum", "Olsid", Name = "IX_OLevelResultsApplicant", IsUnique = true)]
    public partial class OlevelResultsApplicant
    {
        [Key]
        [Column("OLRID")]
        public int Olrid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("OLSID")]
        public int Olsid { get; set; }
        [Column("OLGID")]
        public int Olgid { get; set; }
        [Column("SittingID")]
        public int? SittingId { get; set; }

        [ForeignKey("Olgid")]
        [InverseProperty("OlevelResultsApplicants")]
        public virtual OlevelGrade Olg { get; set; } = null!;
        [ForeignKey("Olsid")]
        [InverseProperty("OlevelResultsApplicants")]
        public virtual OlevelSubject Ols { get; set; } = null!;
    }
}
