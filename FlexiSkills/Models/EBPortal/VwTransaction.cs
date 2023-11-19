using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwTransaction
    {
        [Column("TranID")]
        public int TranId { get; set; }
        [StringLength(100)]
        public string? TransactionStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        [StringLength(50)]
        public string? ApprovedAmount { get; set; }
        public string? TransactionReference { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DatePosted { get; set; }
        [Column("Remita_RRR")]
        [StringLength(255)]
        public string? RemitaRrr { get; set; }
        [Column("SemesterID")]
        public int? SemesterId { get; set; }
        public int? Paymentid { get; set; }
        [StringLength(50)]
        public string? Payeenum { get; set; }
        public int? Sessionid { get; set; }
        public int? Translevel { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Sex { get; set; } = null!;
        [Column("prog")]
        [StringLength(254)]
        public string? Prog { get; set; }
        [Column("progid")]
        public int? Progid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EntrySession { get; set; } = null!;
        [Column("EntrySessionID")]
        public int? EntrySessionId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [Column("session_name")]
        [StringLength(50)]
        [Unicode(false)]
        public string SessionName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("PCAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [Column("PNName")]
        [StringLength(150)]
        public string? Pnname { get; set; }
    }
}
