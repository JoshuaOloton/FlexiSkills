using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("nyscjamb")]
    public partial class Nyscjamb
    {
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("jambno")]
        [StringLength(50)]
        public string? Jambno { get; set; }
    }
}
