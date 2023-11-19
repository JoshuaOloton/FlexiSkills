using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class TertiaryInstitutionGrade
    {
        public TertiaryInstitutionGrade()
        {
            TertiaryInstitutionResultApplicant2s = new HashSet<TertiaryInstitutionResultApplicant2>();
            TertiaryInstitutionResultApplicants = new HashSet<TertiaryInstitutionResultApplicant>();
            TertiaryInstitutionResults = new HashSet<TertiaryInstitutionResult>();
        }

        [Key]
        [Column("TIGID")]
        public int Tigid { get; set; }
        [Column("TIGName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tigname { get; set; } = null!;

        [InverseProperty("Tig")]
        public virtual ICollection<TertiaryInstitutionResultApplicant2> TertiaryInstitutionResultApplicant2s { get; set; }
        [InverseProperty("Tig")]
        public virtual ICollection<TertiaryInstitutionResultApplicant> TertiaryInstitutionResultApplicants { get; set; }
        [InverseProperty("Tig")]
        public virtual ICollection<TertiaryInstitutionResult> TertiaryInstitutionResults { get; set; }
    }
}
