using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("YCTPAY_Transactions")]
    public partial class YctpayTransaction
    {
        [Key]
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
        [Column("MerchantID")]
        public int? MerchantId { get; set; }
        public bool Loaded { get; set; }
        [Column("Remita_RRR")]
        [StringLength(255)]
        [Unicode(false)]
        public string? RemitaRrr { get; set; }
        [Column("SemesterID")]
        public int? SemesterId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PaymentDescription { get; set; }

        [ForeignKey("Spid")]
        [InverseProperty("YctpayTransactions")]
        public virtual YctpayStudentsPaymentsMistake Sp { get; set; } = null!;
        [InverseProperty("Tran")]
        public virtual YctpaySuccessfulTransaction YctpaySuccessfulTransaction { get; set; } = null!;
        [InverseProperty("Tran")]
        public virtual YctpayTransactionsWithMixedMerchantId YctpayTransactionsWithMixedMerchantId { get; set; } = null!;
        [InverseProperty("Tran")]
        public virtual YctpayTransactionswithMixedupDatum YctpayTransactionswithMixedupDatum { get; set; } = null!;
    }
}
