using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("breakdown_exempt")]
    public partial class BreakdownExempt
    {
        [StringLength(255)]
        public string? Code { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("PTAcronym")]
        [StringLength(255)]
        public string? Ptacronym { get; set; }
        [StringLength(255)]
        public string? LevelName { get; set; }
        [Column("SessionID")]
        [StringLength(255)]
        public string? SessionId { get; set; }
    }
}
