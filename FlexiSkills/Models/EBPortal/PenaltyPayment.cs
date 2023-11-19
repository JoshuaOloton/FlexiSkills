using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PenaltyPayment
    {
        [Key]
        [Column("PPID")]
        public int Ppid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime Paymentdate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [Column("PaymentID")]
        public int PaymentId { get; set; }

        [ForeignKey("PaymentId")]
        [InverseProperty("PenaltyPayments")]
        public virtual YctpayPayment Payment { get; set; } = null!;
        [ForeignKey("SemesterId")]
        [InverseProperty("PenaltyPayments")]
        public virtual Semestersp Semester { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("PenaltyPayments")]
        public virtual Session Session { get; set; } = null!;
    }
}
