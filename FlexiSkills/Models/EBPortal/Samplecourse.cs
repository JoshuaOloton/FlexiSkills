using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("samplecourse")]
    public partial class Samplecourse
    {
        [Column("matric")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Matric { get; set; }
        [Column("courseId")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseId { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
