using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("yabavsjambLGA")]
    public partial class YabavsjambLga
    {
        [Key]
        [StringLength(255)]
        public string Sn { get; set; } = null!;
        [Column("statename")]
        [StringLength(255)]
        public string? Statename { get; set; }
        [Column("yabaLGA")]
        [StringLength(255)]
        public string? YabaLga { get; set; }
        [Column("jambLGA")]
        [StringLength(255)]
        public string? JambLga { get; set; }
        [Column("stateid")]
        public int? Stateid { get; set; }
    }
}
