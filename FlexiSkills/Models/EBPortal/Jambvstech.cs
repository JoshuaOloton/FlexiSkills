using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("jambvstech")]
    public partial class Jambvstech
    {
        [Key]
        [Column("CourseID")]
        [StringLength(255)]
        public string CourseId { get; set; } = null!;
        [StringLength(255)]
        public string? CourseCode { get; set; }
        [StringLength(255)]
        public string? Course { get; set; }
        [StringLength(255)]
        public string? YabaCourses { get; set; }
        [Column("programid")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Programid { get; set; }
    }
}
