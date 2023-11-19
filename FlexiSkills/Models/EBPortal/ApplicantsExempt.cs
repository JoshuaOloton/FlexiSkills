using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Applicants_exempt")]
    public partial class ApplicantsExempt
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("Exempt_Cat")]
        public int? ExemptCat { get; set; }
        [StringLength(50)]
        public string? Auth { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
