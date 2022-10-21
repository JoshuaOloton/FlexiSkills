using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("summary_registration_certificate")]
    public partial class SummaryRegistrationCertificate
    {
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string Admiision { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string Acceptance { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string Clearance { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string SchoolFees { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string ProgrammeType { get; set; } = null!;
    }
}
