using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ChangeOfCoursePayment")]
    public partial class ChangeOfCoursePayment
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [Column("BankID")]
        public int BankId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("ChangeOfCoursePayments")]
        public virtual Bank Bank { get; set; } = null!;
        [ForeignKey("Utmenumber")]
        [InverseProperty("ChangeOfCoursePayment")]
        public virtual PostutmeApplicantList UtmenumberNavigation { get; set; } = null!;
    }
}
