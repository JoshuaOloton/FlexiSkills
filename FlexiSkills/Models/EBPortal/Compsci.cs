using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("COMPSCI")]
    public partial class Compsci
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Column("appnum")]
        [StringLength(255)]
        public string? Appnum { get; set; }
        [Column("score")]
        [StringLength(255)]
        public string? Score { get; set; }
    }
}
