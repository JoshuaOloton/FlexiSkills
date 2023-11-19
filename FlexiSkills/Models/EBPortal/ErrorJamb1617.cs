using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ErrorJamb1617")]
    public partial class ErrorJamb1617
    {
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
    }
}
