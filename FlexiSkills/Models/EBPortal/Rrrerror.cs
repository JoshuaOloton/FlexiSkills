using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("rrrerrors")]
    public partial class Rrrerror
    {
        [Column("rrr")]
        [StringLength(50)]
        public string? Rrr { get; set; }
    }
}
