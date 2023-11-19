using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("New_Other_Payments")]
    public partial class NewOtherPayment
    {
        [Column("id")]
        public int Id { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [StringLength(500)]
        [Unicode(false)]
        public string? PostbackUrl { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Amount { get; set; }
        public int? StatusView { get; set; }
        public int? PaymentCategory { get; set; }
        public int OpenStatus { get; set; }
        [StringLength(200)]
        public string? Instruction { get; set; }
        [Column("PaymentID")]
        public int PaymentId { get; set; }
    }
}
