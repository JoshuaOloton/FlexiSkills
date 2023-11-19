using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("AdmissionLetterPayments_copy")]
    public partial class AdmissionLetterPaymentsCopy
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

        [ForeignKey("BankId")]
        [InverseProperty("AdmissionLetterPaymentsCopies")]
        public virtual Bank Bank { get; set; } = null!;
    }
}
