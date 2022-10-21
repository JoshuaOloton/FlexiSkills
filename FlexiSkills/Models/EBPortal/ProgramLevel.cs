using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class ProgramLevel
    {
        [Key]
        [Column("PLID")]
        public int Plid { get; set; }
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("LevelID")]
        public int LevelId { get; set; }
        public int LevelRank { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;

        [ForeignKey("LevelId")]
        [InverseProperty("ProgramLevels")]
        public virtual Level Level { get; set; } = null!;
        [ForeignKey("ProgramId")]
        [InverseProperty("ProgramLevels")]
        public virtual Program Program { get; set; } = null!;
    }
}
