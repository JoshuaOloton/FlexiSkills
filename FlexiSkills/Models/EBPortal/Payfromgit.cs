using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Payfromgit")]
    public partial class Payfromgit
    {
        [StringLength(150)]
        public string? PayerName { get; set; }
        [StringLength(150)]
        public string? Payermail { get; set; }
        [StringLength(50)]
        public string? PayerPhone { get; set; }
        [StringLength(50)]
        public string? Orderid { get; set; }
        public int? Paymentid { get; set; }
        public int? Amt { get; set; }
        [StringLength(50)]
        public string? Acadsession { get; set; }
        [Column("paymentdescription")]
        [StringLength(150)]
        public string? Paymentdescription { get; set; }
        [StringLength(50)]
        public string? PaymentName { get; set; }
        [Column("rrr")]
        [StringLength(50)]
        public string? Rrr { get; set; }
        [Column("dategenerated", TypeName = "date")]
        public DateTime? Dategenerated { get; set; }
        [StringLength(50)]
        public string? Status { get; set; }
        [StringLength(50)]
        public string? Sid { get; set; }
        [StringLength(50)]
        public string? Psayerid { get; set; }
        [Column("server")]
        public int? Server { get; set; }
        [StringLength(150)]
        public string? ProgramName { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
