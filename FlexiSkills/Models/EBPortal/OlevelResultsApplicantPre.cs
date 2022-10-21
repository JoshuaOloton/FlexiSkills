using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OLevelResultsApplicantPre")]
    [Index("Appnum", "Olsid", Name = "IX_OLevelResultsApplicantPre", IsUnique = true)]
    public partial class OlevelResultsApplicantPre
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
        [InverseProperty("OlevelResultsApplicantPres")]
        public virtual OlevelGrade Olg { get; set; } = null!;
        [ForeignKey("Olsid")]
        [InverseProperty("OlevelResultsApplicantPres")]
        public virtual OlevelSubject Ols { get; set; } = null!;
    }
}
