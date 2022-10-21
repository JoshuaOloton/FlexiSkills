using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("applicationinvoice_gen")]
    public partial class ApplicationinvoiceGen
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("payername")]
        [StringLength(80)]
        [Unicode(false)]
        public string Payername { get; set; } = null!;
        [Column("payeremail")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Payeremail { get; set; }
        [Column("payerphone")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Payerphone { get; set; }
        [Column("orderid")]
        [StringLength(50)]
        [Unicode(false)]
        public string Orderid { get; set; } = null!;
        [Column("paymentid")]
        [StringLength(50)]
        [Unicode(false)]
        public string Paymentid { get; set; } = null!;
        [Column("amt")]
        [StringLength(20)]
        [Unicode(false)]
        public string Amt { get; set; } = null!;
        [Column("acadsession")]
        [StringLength(30)]
        [Unicode(false)]
        public string? Acadsession { get; set; }
        [Column("paymentdescription")]
        [Unicode(false)]
        public string? Paymentdescription { get; set; }
        [Column("paymentName")]
        [StringLength(100)]
        [Unicode(false)]
        public string PaymentName { get; set; } = null!;
        [Column("rrr")]
        [StringLength(20)]
        [Unicode(false)]
        public string Rrr { get; set; } = null!;
        [Column("dategenerated")]
        [StringLength(100)]
        [Unicode(false)]
        public string Dategenerated { get; set; } = null!;
        [Column("status")]
        [StringLength(100)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [Column("sid")]
        [StringLength(30)]
        [Unicode(false)]
        public string Sid { get; set; } = null!;
        [Column("payerID")]
        [StringLength(50)]
        [Unicode(false)]
        public string PayerId { get; set; } = null!;
        [Column("server")]
        public int Server { get; set; }
        [Column("programName")]
        [Unicode(false)]
        public string? ProgramName { get; set; }
    }
}
