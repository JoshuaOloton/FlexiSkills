using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ChangeofCourse2016")]
    public partial class ChangeofCourse2016
    {
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        public int? Statusreg { get; set; }
    }
}
