using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("AdmissionAllAccFT")]
    public partial class AdmissionAllAccFt
    {
        [StringLength(250)]
        public string? Program { get; set; }
        [StringLength(250)]
        public string? School { get; set; }
        public int? Acceptance { get; set; }
    }
}
