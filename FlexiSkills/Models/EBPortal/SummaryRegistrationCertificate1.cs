using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("summary_registration_certificates")]
    public partial class SummaryRegistrationCertificate1
    {
        [Column("pcacronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [StringLength(11)]
        [Unicode(false)]
        public string? Admission { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? Acceptance { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? Clearance { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? SchoolFees { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? ProgrammeType { get; set; }
    }
}
