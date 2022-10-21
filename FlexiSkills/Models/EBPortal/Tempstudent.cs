using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Tempstudent")]
    public partial class Tempstudent
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(10)]
        public string? Sex { get; set; }
        [StringLength(10)]
        public string? Slevel { get; set; }
        [StringLength(190)]
        public string? Prog { get; set; }
        public int Id { get; set; }
        public int? ProgId { get; set; }
    }
}
