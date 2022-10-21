using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Index("Ctname", Name = "IX_CourseNames", IsUnique = true)]
    public partial class CourseTitle
    {
        public CourseTitle()
        {
            Course1s = new HashSet<Course1>();
        }

        [Key]
        [Column("CTID")]
        public int Ctid { get; set; }
        [Column("CTName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Ctname { get; set; } = null!;

        [InverseProperty("Ct")]
        public virtual ICollection<Course1> Course1s { get; set; }
    }
}
