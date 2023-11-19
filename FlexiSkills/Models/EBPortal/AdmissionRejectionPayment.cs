using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class AdmissionRejectionPayment
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column("BankID")]
        public int BankId { get; set; }

        [ForeignKey("Appnum")]
        [InverseProperty("AdmissionRejectionPayment")]
        public virtual Admission AppnumNavigation { get; set; } = null!;
        [ForeignKey("BankId")]
        [InverseProperty("AdmissionRejectionPayments")]
        public virtual Bank Bank { get; set; } = null!;
    }
}
