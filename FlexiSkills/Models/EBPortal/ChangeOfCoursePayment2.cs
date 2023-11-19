using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ChangeOfCoursePayment_2")]
    public partial class ChangeOfCoursePayment2
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [Column("BankID")]
        public int BankId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateUploaded { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("ChangeOfCoursePayment2s")]
        public virtual Bank Bank { get; set; } = null!;
    }
}
