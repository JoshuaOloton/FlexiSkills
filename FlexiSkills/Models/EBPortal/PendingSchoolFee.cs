using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class PendingSchoolFee
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("matricnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("amount")]
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [Column("status")]
        public int? Status { get; set; }
        [Column("paymentid")]
        public int? Paymentid { get; set; }
        [Column("datecreated", TypeName = "date")]
        public DateTime? Datecreated { get; set; }
        [Column("sessionid")]
        public int? Sessionid { get; set; }
    }
}
