using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("CourseregistrationApproval")]
    public partial class CourseregistrationApproval
    {
        [Key]
        [Column("CRID")]
        public int Crid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;

        [ForeignKey("Crid")]
        [InverseProperty("CourseregistrationApproval")]
        public virtual CourseRegistration Cr { get; set; } = null!;
    }
}
