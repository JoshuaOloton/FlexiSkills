using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Semestersp")]
    public partial class Semestersp
    {
        public Semestersp()
        {
            CourseRegistrationLatePayments = new HashSet<CourseRegistrationLatePayment>();
            PenaltyPayments = new HashSet<PenaltyPayment>();
            ProgramLevelSemesters = new HashSet<ProgramLevelSemester>();
        }

        [Key]
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SemesterName { get; set; } = null!;
        public bool CurrentSemester { get; set; }

        [InverseProperty("Semester")]
        public virtual ICollection<CourseRegistrationLatePayment> CourseRegistrationLatePayments { get; set; }
        [InverseProperty("Semester")]
        public virtual ICollection<PenaltyPayment> PenaltyPayments { get; set; }
        [InverseProperty("Semester")]
        public virtual ICollection<ProgramLevelSemester> ProgramLevelSemesters { get; set; }
    }
}
