using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("changehnd")]
    public partial class Changehnd
    {
        [Column("appnum")]
        [StringLength(50)]
        public string Appnum { get; set; } = null!;
        [Column("programid")]
        [StringLength(50)]
        public string Programid { get; set; } = null!;
    }
}
