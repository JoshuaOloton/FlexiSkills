using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("GraderUTMElTotalCount")]
    public partial class GraderUtmelTotalCount
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string? Level { get; set; }
        public int CompulsoryCount { get; set; }
        public int ElectiveCount { get; set; }
    }
}
