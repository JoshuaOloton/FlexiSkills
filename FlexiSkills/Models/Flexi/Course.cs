using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.Flexi
{
    [Table("course")]
    public partial class Course
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("dboCourseID")]
        public int DboCourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CourseCode { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string CourseTitle { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string CourseUnit { get; set; } = null!;
        [Column("StudentID")]
        public int StudentId { get; set; }
        [Column("SemesterID")]
        [StringLength(50)]
        [Unicode(false)]
        public string SemesterId { get; set; } = null!;
        [Column("SessionID")]
        [StringLength(50)]
        [Unicode(false)]
        public string SessionId { get; set; } = null!;

        [ForeignKey("StudentId")]
        [InverseProperty("Courses")]
        public virtual Student Student { get; set; } = null!;
    }
}
