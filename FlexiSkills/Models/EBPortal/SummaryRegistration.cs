using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("summary_registration")]
    public partial class SummaryRegistration
    {
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(11)]
        [Unicode(false)]
        public string? Admiision { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? Acceptance { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? Clearance { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? SchoolFees { get; set; }
        [Column("schoolname")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Schoolname { get; set; }
    }
}
