using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("jambadmission1617")]
    public partial class Jambadmission1617
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
    }
}
