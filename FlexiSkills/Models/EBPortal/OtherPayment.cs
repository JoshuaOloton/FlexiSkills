using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class OtherPayment
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string PayeeNum { get; set; } = null!;
        [Column("Payer_name")]
        [StringLength(200)]
        [Unicode(false)]
        public string? PayerName { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string SpaceName { get; set; } = null!;
        [Column("PaymentID")]
        public int PaymentId { get; set; }
    }
}
