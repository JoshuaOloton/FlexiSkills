using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Index("ApplicationNumber", Name = "IX_OnlineappPayments", IsUnique = true)]
    public partial class OnlineappPayment
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [Column("BankID")]
        public int BankId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ReceiptNumber { get; set; } = null!;

        [ForeignKey("BankId")]
        [InverseProperty("OnlineappPayments")]
        public virtual Bank Bank { get; set; } = null!;
    }
}
