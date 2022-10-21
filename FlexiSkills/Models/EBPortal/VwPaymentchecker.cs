using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwPaymentchecker
    {
        [StringLength(8000)]
        [Unicode(false)]
        public string? Matricnum { get; set; }
        [Column("studentname")]
        [StringLength(80)]
        [Unicode(false)]
        public string Studentname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Department { get; set; } = null!;
        [Column("paymentName")]
        [StringLength(100)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [Column("amount")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Amount { get; set; }
        [Column("date_sent")]
        [StringLength(200)]
        [Unicode(false)]
        public string? DateSent { get; set; }
    }
}
