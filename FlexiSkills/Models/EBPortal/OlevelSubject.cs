using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OLevelSubjects")]
    public partial class OlevelSubject
    {
        public OlevelSubject()
        {
            OlevelResults = new HashSet<OlevelResult>();
            OlevelResultsApplicantPres = new HashSet<OlevelResultsApplicantPre>();
            OlevelResultsApplicants = new HashSet<OlevelResultsApplicant>();
        }

        [Key]
        [Column("OLSID")]
        public int Olsid { get; set; }
        [Column("OLSName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Olsname { get; set; } = null!;

        [InverseProperty("Ols")]
        public virtual ICollection<OlevelResult> OlevelResults { get; set; }
        [InverseProperty("Ols")]
        public virtual ICollection<OlevelResultsApplicantPre> OlevelResultsApplicantPres { get; set; }
        [InverseProperty("Ols")]
        public virtual ICollection<OlevelResultsApplicant> OlevelResultsApplicants { get; set; }
    }
}
