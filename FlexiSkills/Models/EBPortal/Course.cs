using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Course")]
    public partial class Course
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("course")]
        [StringLength(200)]
        public string Course1 { get; set; } = null!;
        [Column("deptcode")]
        [StringLength(20)]
        public string Deptcode { get; set; } = null!;
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CoursefeesYr1 { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CoursefeesYr2 { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CoursefeesYr3 { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CoursefeesYr4 { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal CoursefeesCo { get; set; }
        [Column("coursetype")]
        [StringLength(20)]
        public string? Coursetype { get; set; }
        [Column("prog_status")]
        [StringLength(3)]
        public string? ProgStatus { get; set; }
    }
}
