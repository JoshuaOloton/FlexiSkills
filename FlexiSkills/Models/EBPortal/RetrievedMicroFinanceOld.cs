using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("retrievedMicroFinance_old")]
    public partial class RetrievedMicroFinanceOld
    {
        [StringLength(255)]
        public string? Names { get; set; }
        [StringLength(255)]
        public string MatNum { get; set; } = null!;
        [StringLength(255)]
        public string? Amount { get; set; }
        [Column("Teller_Num")]
        [StringLength(255)]
        public string? TellerNum { get; set; }
        [Column("Receipt_Num")]
        [StringLength(255)]
        public string? ReceiptNum { get; set; }
        [StringLength(152)]
        [Unicode(false)]
        public string? Namess { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
    }
}
