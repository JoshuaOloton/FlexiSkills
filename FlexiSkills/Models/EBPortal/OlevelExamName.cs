using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OLevelExamNames")]
    public partial class OlevelExamName
    {
        [Key]
        [Column("OLENID")]
        public int Olenid { get; set; }
        [Column("OLEName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Olename { get; set; } = null!;
    }
}
