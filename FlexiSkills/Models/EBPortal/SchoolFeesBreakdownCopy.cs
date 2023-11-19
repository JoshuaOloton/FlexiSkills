using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("SchoolFeesBreakdown_copy")]
    [Index("Amount", "Code", "LevelId", "Ptid", "SchoolId", "SessionId", Name = "UQ__SchoolFe__B7B340F04E82E082", IsUnique = true)]
    public partial class SchoolFeesBreakdownCopy
    {
        [Key]
        [Column("SFBID")]
        public int Sfbid { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string Code { get; set; } = null!;
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("LevelID")]
        public int LevelId { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        [Column("SessionID")]
        public int? SessionId { get; set; }

        [ForeignKey("Code")]
        [InverseProperty("SchoolFeesBreakdownCopies")]
        public virtual SchoolFeesItem CodeNavigation { get; set; } = null!;
        [ForeignKey("LevelId")]
        [InverseProperty("SchoolFeesBreakdownCopies")]
        public virtual Level Level { get; set; } = null!;
        [ForeignKey("Ptid")]
        [InverseProperty("SchoolFeesBreakdownCopies")]
        public virtual ProgramType Pt { get; set; } = null!;
        [ForeignKey("SchoolId")]
        [InverseProperty("SchoolFeesBreakdownCopies")]
        public virtual School School { get; set; } = null!;
    }
}
