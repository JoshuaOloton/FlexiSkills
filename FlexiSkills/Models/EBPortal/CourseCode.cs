using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Index("Ccname", Name = "IX_CourseCodes", IsUnique = true)]
    public partial class CourseCode
    {
        public CourseCode()
        {
            Course1s = new HashSet<Course1>();
        }

        [Key]
        [Column("CCID")]
        public int Ccid { get; set; }
        [Column("CCName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ccname { get; set; } = null!;

        [InverseProperty("Cc")]
        public virtual ICollection<Course1> Course1s { get; set; }
    }
}
