using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Olevel_SittingTbl")]
    public partial class OlevelSittingTbl
    {
        [Column("sittingID")]
        public int SittingId { get; set; }
        [Column("sitting")]
        public int Sitting { get; set; }
        [Column("amount", TypeName = "decimal(18, 0)")]
        public decimal Amount { get; set; }
        [Column("status")]
        [StringLength(10)]
        public string Status { get; set; } = null!;
        [Column("dateCreated", TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column("createdBy")]
        [StringLength(20)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [Column("sittingName")]
        [StringLength(25)]
        [Unicode(false)]
        public string? SittingName { get; set; }
        [Column("paymentFor")]
        [StringLength(120)]
        [Unicode(false)]
        public string? PaymentFor { get; set; }
        [Column("paymentID")]
        public int? PaymentId { get; set; }
    }
}
