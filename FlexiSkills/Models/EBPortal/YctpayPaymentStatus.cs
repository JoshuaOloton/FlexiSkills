using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("YCTPAY_PaymentStatus")]
    public partial class YctpayPaymentStatus
    {
        [StringLength(1)]
        [Unicode(false)]
        public string? AllPaymentStatus { get; set; }
    }
}
