using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("AdmissionAllpayfresh")]
    public partial class AdmissionAllpayfresh
    {
        [StringLength(250)]
        public string? Program { get; set; }
        [StringLength(250)]
        public string? School { get; set; }
        [Column("payfresh")]
        public int? Payfresh { get; set; }
    }
}
