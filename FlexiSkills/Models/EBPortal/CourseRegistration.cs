using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("CourseRegistration")]
    public partial class CourseRegistration
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

        [InverseProperty("Cr")]
        public virtual CourseregistrationApproval CourseregistrationApproval { get; set; } = null!;
    }
}
