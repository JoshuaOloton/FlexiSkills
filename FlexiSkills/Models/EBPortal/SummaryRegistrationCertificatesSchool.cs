using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("summary_registration_certificates_SCHOOL")]
    public partial class SummaryRegistrationCertificatesSchool
    {
        [Column("SCHOOLNAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Schoolname { get; set; } = null!;
        [Column("pcacronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [StringLength(1)]
        [Unicode(false)]
        public string Admission { get; set; } = null!;
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
