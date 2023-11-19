using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("apppayerror")]
    public partial class Apppayerror
    {
        [Column("payerphone")]
        [StringLength(255)]
        public string? Payerphone { get; set; }
        [Column("payername")]
        [StringLength(255)]
        public string? Payername { get; set; }
        [Column("rrr")]
        [StringLength(255)]
        public string? Rrr { get; set; }
        [Column("payerID")]
        [StringLength(255)]
        public string? PayerId { get; set; }
    }
}
