using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("MicroFinance_Hostel")]
    [Index("ReceiptNum", Name = "ReceiptNum")]
    [Index("TellerNum", Name = "TellerNum")]
    public partial class MicroFinanceHostel
    {
        [StringLength(255)]
        public string? Names { get; set; }
        [Key]
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
    }
}
