using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("jambimgg1617")]
    public partial class Jambimgg1617
    {
        [Column("regnumber")]
        [StringLength(10)]
        [Unicode(false)]
        public string Regnumber { get; set; } = null!;
        [Column(TypeName = "image")]
        public byte[] Image { get; set; } = null!;
    }
}
