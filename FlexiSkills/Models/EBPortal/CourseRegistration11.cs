using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("CourseRegistration11")]
    public partial class CourseRegistration11
    {
        [Key]
        [Column("CRID")]
        public int Crid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [Column("SFID")]
        public int Sfid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
    }
}
