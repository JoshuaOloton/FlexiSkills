using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("MicroFinance_Pending")]
    public partial class MicroFinancePending
    {
        [Column("NAMES")]
        [StringLength(255)]
        public string? Names { get; set; }
        [Column("MATRICNO")]
        [StringLength(255)]
        public string? Matricno { get; set; }
        [Column("AMOUNT")]
        [StringLength(255)]
        public string? Amount { get; set; }
        [Column("TELLERNO")]
        [StringLength(255)]
        public string? Tellerno { get; set; }
        [Column("RECEIPTNO")]
        [StringLength(255)]
        public string? Receiptno { get; set; }
    }
}
