using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ALLPAYMENT1415_fulltime")]
    public partial class Allpayment1415Fulltime
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(19)]
        [Unicode(false)]
        public string? Date { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionReference { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EntrySession { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? SchoolName { get; set; }
        [Column("PTName")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Ptname { get; set; }
    }
}
