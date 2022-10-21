using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("AcceptanceNDFTUpdateCount")]
    public partial class AcceptanceNdftupdateCount
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        public int UpdateCount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateUpdated { get; set; }
    }
}
