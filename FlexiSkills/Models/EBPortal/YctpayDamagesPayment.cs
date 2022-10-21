using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("YCTPAY_DamagesPayment")]
    public partial class YctpayDamagesPayment
    {
        [Column("serial")]
        public int Serial { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PayeeNum { get; set; }
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        [StringLength(18)]
        [Unicode(false)]
        public string? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        [Column("TranID")]
        [StringLength(15)]
        [Unicode(false)]
        public string? TranId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ReceiptNum { get; set; }
    }
}
