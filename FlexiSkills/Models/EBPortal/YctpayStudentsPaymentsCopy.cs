using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("YCTPAY_StudentsPayments_copy")]
    [Index("Amount", "PayeeNum", "PaymentId", "SessionId", Name = "IX_YCTPAY_StudentsPayments")]
    public partial class YctpayStudentsPaymentsCopy
    {
        [Key]
        [Column("SPID")]
        public int Spid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PayeeNum { get; set; } = null!;
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;

        [ForeignKey("PaymentId")]
        [InverseProperty("YctpayStudentsPaymentsCopies")]
        public virtual YctpayPayment Payment { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("YctpayStudentsPaymentsCopies")]
        public virtual Session Session { get; set; } = null!;
    }
}
