using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("registrationExemption")]
    public partial class RegistrationExemption
    {
        [Column("ExemptionID")]
        public int ExemptionId { get; set; }
        [Column("school")]
        [StringLength(100)]
        public string? School { get; set; }
        [Column("department")]
        [StringLength(100)]
        public string? Department { get; set; }
        [StringLength(100)]
        public string? MatricNo { get; set; }
        [Column("registrationStatus")]
        [StringLength(100)]
        public string? RegistrationStatus { get; set; }
    }
}
