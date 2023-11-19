using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("admitted120")]
    public partial class Admitted120
    {
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
    }
}
