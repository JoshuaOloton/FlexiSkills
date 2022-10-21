using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Transactions2")]
    public partial class Transactions2
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
        public DateTime? DatePosted { get; set; }
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
    }
}
