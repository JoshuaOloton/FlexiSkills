using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ProgramCampus")]
    public partial class ProgramCampus
    {
        [Column("PCCID")]
        public int Pccid { get; set; }
        [Column("PCCName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pccname { get; set; } = null!;
        public int? Active { get; set; }
    }
}
