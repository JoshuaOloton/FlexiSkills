using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("GradedOlevel")]
    public partial class GradedOlevel
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
        [StringLength(255)]
        [Unicode(false)]
        public string Subject { get; set; } = null!;
        public int Statusid { get; set; }
    }
}
