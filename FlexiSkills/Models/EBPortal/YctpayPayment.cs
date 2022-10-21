using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("YCTPAY_Payments")]
    public partial class YctpayPayment
    {
        public YctpayPayment()
        {
            PenaltyPayments = new HashSet<PenaltyPayment>();
            YctpayOthersPayments = new HashSet<YctpayOthersPayment>();
            YctpayStudentsPayments = new HashSet<YctpayStudentsPayment>();
            YctpayStudentsPaymentsCopies = new HashSet<YctpayStudentsPaymentsCopy>();
            YctpayStudentsPaymentsCopyCopies = new HashSet<YctpayStudentsPaymentsCopyCopy>();
            YctpayStudentsPaymentsMistakes = new HashSet<YctpayStudentsPaymentsMistake>();
            YctpayTransactionOthers = new HashSet<YctpayTransactionOther>();
        }

        [Key]
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [StringLength(500)]
        [Unicode(false)]
        public string? PostbackUrl { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? Amount { get; set; }
        public int? StatusView { get; set; }
        public int? PaymentCategory { get; set; }
        public int OpenStatus { get; set; }
        [StringLength(200)]
        public string? Instruction { get; set; }

        [InverseProperty("Payment")]
        public virtual ICollection<PenaltyPayment> PenaltyPayments { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<YctpayOthersPayment> YctpayOthersPayments { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<YctpayStudentsPayment> YctpayStudentsPayments { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<YctpayStudentsPaymentsCopy> YctpayStudentsPaymentsCopies { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<YctpayStudentsPaymentsCopyCopy> YctpayStudentsPaymentsCopyCopies { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<YctpayStudentsPaymentsMistake> YctpayStudentsPaymentsMistakes { get; set; }
        [InverseProperty("Payment")]
        public virtual ICollection<YctpayTransactionOther> YctpayTransactionOthers { get; set; }
    }
}
