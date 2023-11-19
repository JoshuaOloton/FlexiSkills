using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmePayments3")]
    public partial class PostutmePayments3
    {
        [Key]
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string ReceiptNumber { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [Column("BankID")]
        public int BankId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;

        [ForeignKey("BankId")]
        [InverseProperty("PostutmePayments3s")]
        public virtual Bank Bank { get; set; } = null!;
    }
}
