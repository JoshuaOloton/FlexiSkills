using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwYctpayTransactionswithMixedupDatum
    {
        [Column("TranID")]
        [StringLength(50)]
        [Unicode(false)]
        public string TranId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column("SPID")]
        public int Spid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TransactionDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ApprovedAmount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        public bool PaymentStatus { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PayeeNum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [Column("SessionID")]
        public int SessionId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [Column("BankID")]
        public int BankId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string BankName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? AccountNum { get; set; }
        public short? InterSwitchCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Channel { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionReference { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionStatus { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? TransactionDescription { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? PostbackUrl { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DatePosted { get; set; }
        [Column("checked")]
        public bool Checked { get; set; }
        [Column("PTName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptname { get; set; } = null!;
    }
}
