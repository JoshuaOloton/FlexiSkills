using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("TransactionsVsGtco")]
    public partial class TransactionsVsGtco
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("rrr")]
        [StringLength(20)]
        public string Rrr { get; set; } = null!;
        [Column("status")]
        public int? Status { get; set; }
        [Column("GTCOstatus")]
        [StringLength(100)]
        public string? Gtcostatus { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string? LocalStatus { get; set; }
        [StringLength(70)]
        [Unicode(false)]
        public string? GitcoStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Transdate { get; set; }
        public int? PaymentId { get; set; }
        [Column("transid")]
        [StringLength(50)]
        public string? Transid { get; set; }
        [Column("amount", TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
    }
}
