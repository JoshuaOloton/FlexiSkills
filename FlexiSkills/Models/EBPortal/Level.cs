using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class Level
    {
        public Level()
        {
            ProgramLevelSemesters = new HashSet<ProgramLevelSemester>();
            ProgramLevels = new HashSet<ProgramLevel>();
            SchoolFees = new HashSet<SchoolFee>();
            SchoolFeesBreakdownCopies = new HashSet<SchoolFeesBreakdownCopy>();
            SchoolFeesBreakdowns = new HashSet<SchoolFeesBreakdown>();
        }

        [Key]
        [Column("LevelID")]
        public int LevelId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string LevelName { get; set; } = null!;
        [Column("studdblevel")]
        [StringLength(30)]
        public string? Studdblevel { get; set; }
        [Column("studdblevelID")]
        public int? StuddblevelId { get; set; }

        [InverseProperty("Level")]
        public virtual ICollection<ProgramLevelSemester> ProgramLevelSemesters { get; set; }
        [InverseProperty("Level")]
        public virtual ICollection<ProgramLevel> ProgramLevels { get; set; }
        [InverseProperty("Level")]
        public virtual ICollection<SchoolFee> SchoolFees { get; set; }
        [InverseProperty("Level")]
        public virtual ICollection<SchoolFeesBreakdownCopy> SchoolFeesBreakdownCopies { get; set; }
        [InverseProperty("Level")]
        public virtual ICollection<SchoolFeesBreakdown> SchoolFeesBreakdowns { get; set; }
    }
}
