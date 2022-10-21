using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Index("Crid", "CourseId", Name = "IX_CourseRegistrationDetails", IsUnique = true)]
    public partial class CourseRegistrationDetail
    {
        [Key]
        [Column("CRDID")]
        public int Crdid { get; set; }
        [Column("CRID")]
        public int Crid { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        [InverseProperty("CourseRegistrationDetails")]
        public virtual Course1 Course { get; set; } = null!;
    }
}
