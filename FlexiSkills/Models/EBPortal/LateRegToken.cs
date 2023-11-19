using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("LateRegToken")]
    public partial class LateRegToken
    {
        [StringLength(20)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("SessionID")]
        [StringLength(5)]
        [Unicode(false)]
        public string? SessionId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Semester { get; set; }
        [StringLength(300)]
        [Unicode(false)]
        public string? Programme { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(250)]
        [Unicode(false)]
        public string? Action { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? DateCreated { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? TimeCreated { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [Column("SStatus")]
        [StringLength(2)]
        [Unicode(false)]
        public string? Sstatus { get; set; }
        [Column("PaymentID")]
        public int? PaymentId { get; set; }
        public float? Amount { get; set; }
        [StringLength(12)]
        [Unicode(false)]
        public string? Token { get; set; }
        public int SummaryId { get; set; }
    }
}
