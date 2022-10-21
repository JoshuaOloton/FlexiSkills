using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Applicants", Schema = "ApplicantPenalty")]
    public partial class Applicant
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        [Column("SessionID")]
        public int? SessionId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PaymentDescription { get; set; }
    }
}
