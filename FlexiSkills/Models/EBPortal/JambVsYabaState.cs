using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("JambVsYabaState")]
    public partial class JambVsYabaState
    {
        [Key]
        [Column("sn")]
        [StringLength(255)]
        public string Sn { get; set; } = null!;
        [Column("jambstate")]
        [StringLength(255)]
        public string? Jambstate { get; set; }
        [StringLength(255)]
        public string? YabaStates { get; set; }
    }
}
