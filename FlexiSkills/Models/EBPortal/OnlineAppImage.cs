using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class OnlineAppImage
    {
        [Column("appnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("imagename")]
        [StringLength(50)]
        [Unicode(false)]
        public string Imagename { get; set; } = null!;
    }
}
