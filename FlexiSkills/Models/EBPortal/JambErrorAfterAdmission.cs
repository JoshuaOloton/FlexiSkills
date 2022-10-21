using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("JambErrorAfterAdmission")]
    public partial class JambErrorAfterAdmission
    {
        [StringLength(255)]
        public string? A { get; set; }
        [Key]
        [StringLength(255)]
        public string No { get; set; } = null!;
        [StringLength(255)]
        public string? RegNo { get; set; }
        [Column("criteria")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [StringLength(255)]
        public string? Error { get; set; }
    }
}
