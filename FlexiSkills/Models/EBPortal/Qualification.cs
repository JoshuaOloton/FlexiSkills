using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Qualification")]
    public partial class Qualification
    {
        public Qualification()
        {
            TertiaryInstitutionResultApplicant2s = new HashSet<TertiaryInstitutionResultApplicant2>();
            TertiaryInstitutionResultApplicants = new HashSet<TertiaryInstitutionResultApplicant>();
            TertiaryInstitutionResults = new HashSet<TertiaryInstitutionResult>();
        }

        [Key]
        [Column("QualificationID")]
        public int QualificationId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string QualificationName { get; set; } = null!;

        [InverseProperty("Qualification")]
        public virtual ICollection<TertiaryInstitutionResultApplicant2> TertiaryInstitutionResultApplicant2s { get; set; }
        [InverseProperty("Qualification")]
        public virtual ICollection<TertiaryInstitutionResultApplicant> TertiaryInstitutionResultApplicants { get; set; }
        [InverseProperty("Qualification")]
        public virtual ICollection<TertiaryInstitutionResult> TertiaryInstitutionResults { get; set; }
    }
}
