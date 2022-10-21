using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OLevelGrade")]
    public partial class OlevelGrade
    {
        public OlevelGrade()
        {
            OlevelResults = new HashSet<OlevelResult>();
            OlevelResultsApplicantPres = new HashSet<OlevelResultsApplicantPre>();
            OlevelResultsApplicants = new HashSet<OlevelResultsApplicant>();
        }

        [Key]
        [Column("OLGID")]
        public int Olgid { get; set; }
        [Column("OLGName")]
        [StringLength(4)]
        [Unicode(false)]
        public string? Olgname { get; set; }
        [Column("OLENID")]
        public int? Olenid { get; set; }

        [InverseProperty("Olg")]
        public virtual ICollection<OlevelResult> OlevelResults { get; set; }
        [InverseProperty("Olg")]
        public virtual ICollection<OlevelResultsApplicantPre> OlevelResultsApplicantPres { get; set; }
        [InverseProperty("Olg")]
        public virtual ICollection<OlevelResultsApplicant> OlevelResultsApplicants { get; set; }
    }
}
