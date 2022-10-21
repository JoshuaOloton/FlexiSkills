using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class ProgramLevelSemester
    {
        public ProgramLevelSemester()
        {
            Course1s = new HashSet<Course1>();
            Students = new HashSet<Student>();
        }

        [Key]
        [Column("PLSID")]
        public int Plsid { get; set; }
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("LevelID")]
        public int LevelId { get; set; }
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [Column("PLSOrder")]
        public int Plsorder { get; set; }

        [ForeignKey("LevelId")]
        [InverseProperty("ProgramLevelSemesters")]
        public virtual Level Level { get; set; } = null!;
        [ForeignKey("ProgramId")]
        [InverseProperty("ProgramLevelSemesters")]
        public virtual Program Program { get; set; } = null!;
        [ForeignKey("SemesterId")]
        [InverseProperty("ProgramLevelSemesters")]
        public virtual Semestersp Semester { get; set; } = null!;
        [InverseProperty("Pls")]
        public virtual ICollection<Course1> Course1s { get; set; }
        [InverseProperty("Pls")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
