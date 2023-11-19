using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("HostelPayments")]
    public partial class HostelPayment2
    {
        [Key]
        [Column("HPID")]
        public int Hpid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime Paymentdate { get; set; }

        [ForeignKey("Hpid")]
        [InverseProperty("HostelPayment2")]
        public virtual HostelApplicationPayment Hp { get; set; } = null!;
    }
}
