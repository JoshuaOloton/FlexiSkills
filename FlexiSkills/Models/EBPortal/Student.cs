using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class Student
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("PLSID")]
        public int? Plsid { get; set; }

        [ForeignKey("Plsid")]
        [InverseProperty("Students")]
        public virtual ProgramLevelSemester? Pls { get; set; }
    }
}
