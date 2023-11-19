using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("conveyregrets")]
    public partial class Conveyregret
    {
        [Key]
        [Column("sn")]
        [StringLength(255)]
        public string Sn { get; set; } = null!;
        [Key]
        [Column("appnumm")]
        [StringLength(255)]
        public string Appnumm { get; set; } = null!;
    }
}
