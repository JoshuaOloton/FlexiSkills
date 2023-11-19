using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("onlineAppVerficationPayment")]
    public partial class OnlineAppVerficationPayment
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("appnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("amount")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Amount { get; set; }
        [Column("datepaid", TypeName = "date")]
        public DateTime? Datepaid { get; set; }
        [Column("paymentstatus")]
        public int Paymentstatus { get; set; }
        [Column("tranid")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tranid { get; set; }
    }
}
