using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("gradupdate")]
    public partial class Gradupdate
    {
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("dept")]
        [StringLength(200)]
        public string? Dept { get; set; }
        [Column("asession")]
        [StringLength(50)]
        public string? Asession { get; set; }
    }
}
