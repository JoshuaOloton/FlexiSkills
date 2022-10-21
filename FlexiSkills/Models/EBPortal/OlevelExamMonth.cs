using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OLevelExamMonths")]
    public partial class OlevelExamMonth
    {
        [Key]
        [Column("OLEMID")]
        public int Olemid { get; set; }
        [Column("OLEMonth")]
        [StringLength(50)]
        [Unicode(false)]
        public string Olemonth { get; set; } = null!;
        [Column("OLENID")]
        public int Olenid { get; set; }
    }
}
