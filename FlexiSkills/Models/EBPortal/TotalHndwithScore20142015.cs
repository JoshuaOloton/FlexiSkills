using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("TotalHNDWithScore2014_2015")]
    public partial class TotalHndwithScore20142015
    {
        [Key]
        [Column("appnum")]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [StringLength(255)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [StringLength(255)]
        public string? Score { get; set; }
    }
}
