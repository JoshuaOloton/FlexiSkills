using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class HostelApplicationPayment
    {
        [Key]
        [Column("HAPID")]
        public int Hapid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Receiptnum { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Paymentdate { get; set; }

        [ForeignKey("Hapid")]
        [InverseProperty("HostelApplicationPayment")]
        public virtual SchoolFee Hap { get; set; } = null!;
        [InverseProperty("Hp")]
        public virtual HostelPayment2 HostelPayment2 { get; set; } = null!;
    }
}
