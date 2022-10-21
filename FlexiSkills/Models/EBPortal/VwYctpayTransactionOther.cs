using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwYctpayTransactionOther
    {
        [Column("PayerID")]
        [StringLength(50)]
        [Unicode(false)]
        public string PayerId { get; set; } = null!;
        [StringLength(500)]
        [Unicode(false)]
        public string? PayerName { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Address { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Amount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
    }
}
