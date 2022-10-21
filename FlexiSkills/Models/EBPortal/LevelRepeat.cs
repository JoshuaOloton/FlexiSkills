using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("level_repeat")]
    public partial class LevelRepeat
    {
        [Column("LevelID")]
        public int LevelId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string LevelName { get; set; } = null!;
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? RepeatLevel { get; set; }
    }
}
