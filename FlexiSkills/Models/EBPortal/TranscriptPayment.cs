using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("TranscriptPayment")]
    public partial class TranscriptPayment
    {
        [StringLength(50)]
        [Unicode(false)]
        public string TranscriptNo { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column("BankID")]
        public int BankId { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("TranscriptPayments")]
        public virtual Bank Bank { get; set; } = null!;
    }
}
