using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Jambstate")]
    public partial class Jambstate
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("statecode")]
        public int? Statecode { get; set; }
    }
}
