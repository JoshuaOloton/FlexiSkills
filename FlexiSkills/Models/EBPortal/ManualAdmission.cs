using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Manual_admission")]
    public partial class ManualAdmission
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("programid")]
        public int? Programid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
