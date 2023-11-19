using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwYctpayDamagesPayment
    {
        [Column("TranID")]
        [StringLength(15)]
        [Unicode(false)]
        public string? TranId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PayeeNum { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? ReceiptNum { get; set; }
        [StringLength(18)]
        [Unicode(false)]
        public string? Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
