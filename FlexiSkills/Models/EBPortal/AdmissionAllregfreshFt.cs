using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("AdmissionAllregfreshFT")]
    public partial class AdmissionAllregfreshFt
    {
        [StringLength(250)]
        public string? Program { get; set; }
        [StringLength(250)]
        public string? School { get; set; }
        [Column("regfresh")]
        public int? Regfresh { get; set; }
    }
}
