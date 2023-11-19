using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeApplicantList")]
    public partial class PostutmeApplicantList
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;

        [ForeignKey("Utmenumber")]
        [InverseProperty("PostutmeApplicantList")]
        public virtual PostutmeResult UtmenumberNavigation { get; set; } = null!;
        [InverseProperty("UtmenumberNavigation")]
        public virtual ChangeOfCoursePayment ChangeOfCoursePayment { get; set; } = null!;
        [InverseProperty("Utmenumber1")]
        public virtual ChangeOfCoursePaymentCopy ChangeOfCoursePaymentCopy { get; set; } = null!;
    }
}
