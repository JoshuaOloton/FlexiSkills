using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PostutmePayment
    {
        [Key]
        [StringLength(50)]
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
        [InverseProperty("PostutmePayments")]
        public virtual Bank Bank { get; set; } = null!;
        [ForeignKey("Utmenumber")]
        [InverseProperty("PostutmePayment")]
        public virtual PostutmeAll Utmenumber1 { get; set; } = null!;
        public virtual Biodata2 UtmenumberNavigation { get; set; } = null!;
    }
}
