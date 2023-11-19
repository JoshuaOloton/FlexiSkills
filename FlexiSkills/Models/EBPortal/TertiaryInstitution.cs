using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class TertiaryInstitution
    {
        public TertiaryInstitution()
        {
            TertiaryInstitutionResultApplicant2s = new HashSet<TertiaryInstitutionResultApplicant2>();
            TertiaryInstitutionResultApplicants = new HashSet<TertiaryInstitutionResultApplicant>();
            TertiaryInstitutionResults = new HashSet<TertiaryInstitutionResult>();
        }

        [Key]
        [Column("TIID")]
        public int Tiid { get; set; }
        [Column("TIName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Tiname { get; set; } = null!;
        public bool BlackListed { get; set; }

        [InverseProperty("Ti")]
        public virtual ICollection<TertiaryInstitutionResultApplicant2> TertiaryInstitutionResultApplicant2s { get; set; }
        [InverseProperty("Ti")]
        public virtual ICollection<TertiaryInstitutionResultApplicant> TertiaryInstitutionResultApplicants { get; set; }
        [InverseProperty("Ti")]
        public virtual ICollection<TertiaryInstitutionResult> TertiaryInstitutionResults { get; set; }
    }
}
