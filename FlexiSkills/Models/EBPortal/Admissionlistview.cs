using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("admissionlistview")]
    public partial class Admissionlistview
    {
        [Column("PNName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pnname { get; set; } = null!;
        [Column("viewable")]
        [StringLength(1)]
        [Unicode(false)]
        public string Viewable { get; set; } = null!;
    }
}
