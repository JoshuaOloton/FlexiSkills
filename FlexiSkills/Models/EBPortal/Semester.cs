using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class Semester
    {
        public Semester()
        {
            CourseRegistrationLateSubmissions = new HashSet<CourseRegistrationLateSubmission>();
        }

        [Key]
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? SemesterName { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? CurrentSemester { get; set; }

        [InverseProperty("Semester")]
        public virtual ICollection<CourseRegistrationLateSubmission> CourseRegistrationLateSubmissions { get; set; }
    }
}
