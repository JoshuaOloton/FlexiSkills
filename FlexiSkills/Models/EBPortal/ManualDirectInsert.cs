using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("manual_DirectInsert")]
    public partial class ManualDirectInsert
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string? Name { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("utmecomb")]
        [StringLength(255)]
        public string? Utmecomb { get; set; }
        [Column("status")]
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
