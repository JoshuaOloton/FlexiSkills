using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("YCTPAY_Transactions2")]
    public partial class YctpayTransactions2
    {
        [Column("TranID")]
        [StringLength(50)]
        [Unicode(false)]
        public string TranId { get; set; } = null!;
        [Column("SPID")]
        public int Spid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionStatus { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? TransactionDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ApprovedAmount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionReference { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DatePosted { get; set; }
        [Column("checked")]
        public bool Checked { get; set; }
    }
}
