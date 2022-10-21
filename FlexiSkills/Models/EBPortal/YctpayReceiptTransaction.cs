using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("YCTPAY_ReceiptTransaction")]
    public partial class YctpayReceiptTransaction
    {
        [StringLength(30)]
        [Unicode(false)]
        public string? Appnum { get; set; }
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column("SessionID")]
        public int SessionId { get; set; }
    }
}
