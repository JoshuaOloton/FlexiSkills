using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("UPDATED_vw_YCTPAY_Transactions")]
    public partial class UpdatedVwYctpayTransaction
    {
        [StringLength(20)]
        [Unicode(false)]
        public string? PayeeNum { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Appnum { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Program { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Amount { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Session { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TransactionDate { get; set; }
        [Column("SESSIONID")]
        public int Sessionid { get; set; }
        [Column("PAYMENTID")]
        public int Paymentid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionStatus { get; set; }
        [Column("NORMALAMOUT")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Normalamout { get; set; }
        [Column("LEVEL_AS_AT")]
        [StringLength(255)]
        [Unicode(false)]
        public string? LevelAsAt { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("schoolname")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Schoolname { get; set; }
        [Column("ptname")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Ptname { get; set; }
    }
}
