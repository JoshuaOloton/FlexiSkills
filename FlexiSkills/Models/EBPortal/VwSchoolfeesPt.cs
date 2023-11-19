using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("vw_schoolfees_pt")]
    public partial class VwSchoolfeesPt
    {
        [Column("schoolname")]
        [StringLength(50)]
        [Unicode(false)]
        public string Schoolname { get; set; } = null!;
        [Column("pnname")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pnname { get; set; } = null!;
        [Column("levelname")]
        [StringLength(50)]
        [Unicode(false)]
        public string Levelname { get; set; } = null!;
        [Column("A2015_2016")]
        public int? A20152016 { get; set; }
        [Column("B2014_2015")]
        public int? B20142015 { get; set; }
    }
}
