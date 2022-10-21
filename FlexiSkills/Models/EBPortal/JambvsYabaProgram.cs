using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("JambvsYabaProgram")]
    public partial class JambvsYabaProgram
    {
        [StringLength(150)]
        public string? JambProgram { get; set; }
        [StringLength(150)]
        public string? YabaProgram { get; set; }
        public int? ProgramId { get; set; }
    }
}
