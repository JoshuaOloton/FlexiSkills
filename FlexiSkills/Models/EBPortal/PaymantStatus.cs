using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("PaymantStatus")]
    public partial class PaymantStatus
    {
        public int? Paymentid { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Dateupdated { get; set; }
        [StringLength(150)]
        public string? Whoupdated { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
