using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("CourseStatus")]
    public partial class CourseStatus
    {
        public CourseStatus()
        {
            Course1s = new HashSet<Course1>();
        }

        [Key]
        [Column("CSID")]
        public int Csid { get; set; }
        [Column("CSCode")]
        [StringLength(50)]
        [Unicode(false)]
        public string Cscode { get; set; } = null!;
        [Column("CSName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Csname { get; set; } = null!;

        [InverseProperty("Cs")]
        public virtual ICollection<Course1> Course1s { get; set; }
    }
}
