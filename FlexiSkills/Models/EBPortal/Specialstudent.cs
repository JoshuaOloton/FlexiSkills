using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("specialstudents")]
    public partial class Specialstudent
    {
        [Column("matricnum")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Matricnum { get; set; }
        [Column("semester")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Semester { get; set; }
        [Column("acadsession")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Acadsession { get; set; }
        [Column("disabilitytype")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Disabilitytype { get; set; }
        [Column("wcc_usuage")]
        [StringLength(255)]
        [Unicode(false)]
        public string? WccUsuage { get; set; }
        [Column("pregnancy")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Pregnancy { get; set; }
    }
}
