using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("School2")]
    public partial class School2
    {
        [Column("SchoolID")]
        public int? SchoolId { get; set; }
        [StringLength(150)]
        public string? School { get; set; }
    }
}
