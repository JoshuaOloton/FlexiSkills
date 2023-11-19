using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("conveyregrets_changeofcourse")]
    public partial class ConveyregretsChangeofcourse
    {
        [Key]
        [Column("appnumm")]
        [StringLength(255)]
        public string Appnumm { get; set; } = null!;
        [Column("pencode")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Pencode { get; set; }
        [Column("penid")]
        public int? Penid { get; set; }
    }
}
