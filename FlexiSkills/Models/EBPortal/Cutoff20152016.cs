using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("cutoff_20152016")]
    public partial class Cutoff20152016
    {
        [Key]
        [StringLength(100)]
        [Unicode(false)]
        public string Department { get; set; } = null!;
        [Column("Cut Off")]
        public int? CutOff { get; set; }
    }
}
