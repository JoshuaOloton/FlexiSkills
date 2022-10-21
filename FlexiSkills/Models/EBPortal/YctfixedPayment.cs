using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("YCTFixedPayments")]
    public partial class YctfixedPayment
    {
        [StringLength(255)]
        public string? PaymentName { get; set; }
        [StringLength(255)]
        public string? Amount { get; set; }
    }
}
