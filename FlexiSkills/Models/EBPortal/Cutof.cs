using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("cutof")]
    public partial class Cutof
    {
        [Key]
        [Column("SN")]
        [StringLength(255)]
        public string Sn { get; set; } = null!;
        [Column("PROGAMME")]
        [StringLength(255)]
        public string? Progamme { get; set; }
        [Column("OLD")]
        [StringLength(255)]
        public string? Old { get; set; }
        [Column("NEW")]
        [StringLength(255)]
        public string? New { get; set; }
        [Column("CATCHMENT")]
        [StringLength(255)]
        public string? Catchment { get; set; }
        [Column("ELDS")]
        [StringLength(255)]
        public string? Elds { get; set; }
        [Column("cutoff")]
        [StringLength(255)]
        public string? Cutoff { get; set; }
    }
}
