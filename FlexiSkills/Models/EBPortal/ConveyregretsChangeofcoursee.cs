using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("conveyregrets_changeofcoursee")]
    public partial class ConveyregretsChangeofcoursee
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
