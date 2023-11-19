using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("exceptionVerificationPayment")]
    public partial class ExceptionVerificationPayment
    {
        [Column("appnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Appnum { get; set; }
        [Column("datepaid")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Datepaid { get; set; }
        [Column("amount")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Amount { get; set; }
        [Column("paymentstatus")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Paymentstatus { get; set; }
        [Column("tranid")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tranid { get; set; }
    }
}
