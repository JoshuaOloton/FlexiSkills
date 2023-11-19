using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("GraderOlevelTotalCount")]
    public partial class GraderOlevelTotalCount
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string ProgramMode { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string ProgramType { get; set; } = null!;
        public int CompulsoryCount { get; set; }
        public int ElectiveCount { get; set; }
    }
}
