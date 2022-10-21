using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("weldin")]
    public partial class Weldin
    {
        [Column("UTMENUMBER")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Utmenumber { get; set; }
    }
}
