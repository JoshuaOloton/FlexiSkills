using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Courses")]
    [Index("Ccid", "Ctid", "CourseUnit", "Csid", "Plsid", Name = "IX_Courses", IsUnique = true)]
    public partial class Course1
    {
        public Course1()
        {
            CourseRegistrationDetails = new HashSet<CourseRegistrationDetail>();
        }

        [Key]
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Column("CCID")]
        public int? Ccid { get; set; }
        [Column("CTID")]
        public int? Ctid { get; set; }
        [Column("CSID")]
        public int? Csid { get; set; }
        public int? CourseUnit { get; set; }
        [Column("PLSID")]
        public int? Plsid { get; set; }

        [ForeignKey("Ccid")]
        [InverseProperty("Course1s")]
        public virtual CourseCode? Cc { get; set; }
        [ForeignKey("Csid")]
        [InverseProperty("Course1s")]
        public virtual CourseStatus? Cs { get; set; }
        [ForeignKey("Ctid")]
        [InverseProperty("Course1s")]
        public virtual CourseTitle? Ct { get; set; }
        [ForeignKey("Plsid")]
        [InverseProperty("Course1s")]
        public virtual ProgramLevelSemester? Pls { get; set; }
        [InverseProperty("Course")]
        public virtual ICollection<CourseRegistrationDetail> CourseRegistrationDetails { get; set; }
    }
}
