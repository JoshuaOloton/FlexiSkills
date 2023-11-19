using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("penaltydesc")]
    public partial class Penaltydesc
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("penaltydescription")]
        [StringLength(255)]
        [Unicode(false)]
        public string Penaltydescription { get; set; } = null!;
        [Column("penalty_paymentid")]
        public int? PenaltyPaymentid { get; set; }
    }
}
