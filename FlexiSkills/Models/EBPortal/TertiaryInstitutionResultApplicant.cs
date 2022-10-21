using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("TertiaryInstitutionResultApplicant")]
    public partial class TertiaryInstitutionResultApplicant
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [Column("TIID")]
        public int? Tiid { get; set; }
        [Column("TIPNID")]
        public int? Tipnid { get; set; }
        [Column("TIGID")]
        public int? Tigid { get; set; }
        [Column("TIFrom")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tifrom { get; set; }
        [Column("TITo")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tito { get; set; }
        [Column("QualificationID")]
        public int? QualificationId { get; set; }

        [ForeignKey("QualificationId")]
        [InverseProperty("TertiaryInstitutionResultApplicants")]
        public virtual Qualification? Qualification { get; set; }
        [ForeignKey("Tiid")]
        [InverseProperty("TertiaryInstitutionResultApplicants")]
        public virtual TertiaryInstitution? Ti { get; set; }
        [ForeignKey("Tigid")]
        [InverseProperty("TertiaryInstitutionResultApplicants")]
        public virtual TertiaryInstitutionGrade? Tig { get; set; }
        [ForeignKey("Tipnid")]
        [InverseProperty("TertiaryInstitutionResultApplicants")]
        public virtual ProgramName? Tipn { get; set; }
    }
}
