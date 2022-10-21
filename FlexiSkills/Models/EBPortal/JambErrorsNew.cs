using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("JambErrorsNew")]
    public partial class JambErrorsNew
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Column("utmenum")]
        [StringLength(255)]
        public string? Utmenum { get; set; }
        [Column("corsid")]
        [StringLength(255)]
        public string? Corsid { get; set; }
        [StringLength(255)]
        public string? Critieria { get; set; }
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
