using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("businessadmin")]
    public partial class Businessadmin
    {
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [Column("score")]
        [StringLength(255)]
        public string? Score { get; set; }
    }
}
