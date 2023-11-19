using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwLga
    {
        [Column("LGAID")]
        public int Lgaid { get; set; }
        [Column("LGAName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Lganame { get; set; } = null!;
        [Column("StateID")]
        public int StateId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string StateName { get; set; } = null!;
    }
}
