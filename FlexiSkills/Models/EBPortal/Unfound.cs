using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Unfound")]
    public partial class Unfound
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        public int Id { get; set; }
    }
}
