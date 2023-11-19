using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class RemitaDatum
    {
        [Column("SNo")]
        [StringLength(255)]
        public string? Sno { get; set; }
        [Column("Name of Payer")]
        [StringLength(255)]
        public string? NameOfPayer { get; set; }
        [Column("RRR")]
        [StringLength(255)]
        public string? Rrr { get; set; }
        [StringLength(255)]
        public string? Amount { get; set; }
        [StringLength(255)]
        public string? Purpose { get; set; }
        [Column("Payment\nDate")]
        [StringLength(255)]
        public string? PaymentDate { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }
        [StringLength(255)]
        public string? Phone { get; set; }
    }
}
