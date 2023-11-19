using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("YCTPAY_Transaction_Others")]
    public partial class YctpayTransactionOther
    {
        [Key]
        [Column("PayerID")]
        [StringLength(50)]
        [Unicode(false)]
        public string PayerId { get; set; } = null!;
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Amount { get; set; }

        [ForeignKey("PaymentId")]
        [InverseProperty("YctpayTransactionOthers")]
        public virtual YctpayPayment? Payment { get; set; }
    }
}
