using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Payments", Schema = "ApplicantPenalty")]
    public partial class Payment
    {
        [StringLength(50)]
        [Unicode(false)]
        public string PayeeNum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string ReceiptNum { get; set; } = null!;
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        [Column("SessionID")]
        public int? SessionId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Appnum { get; set; }

        public virtual Biodata2 PayeeNumNavigation { get; set; } = null!;
    }
}
