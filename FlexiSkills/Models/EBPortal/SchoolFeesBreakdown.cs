using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("SchoolFeesBreakdown")]
    [Index("Amount", "Code", "LevelId", "Ptid", "SchoolId", "SessionId", Name = "IX_SchoolFeesBreakdown", IsUnique = true)]
    public partial class SchoolFeesBreakdown
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
        public int? StatusView { get; set; }

        [ForeignKey("Code")]
        [InverseProperty("SchoolFeesBreakdowns")]
        public virtual SchoolFeesItem CodeNavigation { get; set; } = null!;
        [ForeignKey("LevelId")]
        [InverseProperty("SchoolFeesBreakdowns")]
        public virtual Level Level { get; set; } = null!;
        [ForeignKey("Ptid")]
        [InverseProperty("SchoolFeesBreakdowns")]
        public virtual ProgramType Pt { get; set; } = null!;
        [ForeignKey("SchoolId")]
        [InverseProperty("SchoolFeesBreakdowns")]
        public virtual School School { get; set; } = null!;
    }
}
