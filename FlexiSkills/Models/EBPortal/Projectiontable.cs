using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("projectiontable")]
    public partial class Projectiontable
    {
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        [Column("PNNAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pnname { get; set; } = null!;
        [Column("NDI")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Ndi { get; set; }
        [Column("NDII")]
        public int? Ndii { get; set; }
        [Column("NDIII")]
        public int? Ndiii { get; set; }
        [Column("HNDI")]
        public int? Hndi { get; set; }
        [Column("HNDII")]
        public int? Hndii { get; set; }
        [Column("HNDIII")]
        public int? Hndiii { get; set; }
        [Column("CERTI")]
        public int? Certi { get; set; }
    }
}
