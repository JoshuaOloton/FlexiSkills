using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class ProgramName
    {
        public ProgramName()
        {
            Programs = new HashSet<Program>();
            TertiaryInstitutionResultApplicant2s = new HashSet<TertiaryInstitutionResultApplicant2>();
            TertiaryInstitutionResultApplicants = new HashSet<TertiaryInstitutionResultApplicant>();
            TertiaryInstitutionResults = new HashSet<TertiaryInstitutionResult>();
        }

        [Key]
        [Column("PNID")]
        public int Pnid { get; set; }
        [Column("PNName")]
        [StringLength(150)]
        public string? Pnname { get; set; }

        [InverseProperty("Pn")]
        public virtual ICollection<Program> Programs { get; set; }
        [InverseProperty("Tipn")]
        public virtual ICollection<TertiaryInstitutionResultApplicant2> TertiaryInstitutionResultApplicant2s { get; set; }
        [InverseProperty("Tipn")]
        public virtual ICollection<TertiaryInstitutionResultApplicant> TertiaryInstitutionResultApplicants { get; set; }
        [InverseProperty("Tipn")]
        public virtual ICollection<TertiaryInstitutionResult> TertiaryInstitutionResults { get; set; }
    }
}
