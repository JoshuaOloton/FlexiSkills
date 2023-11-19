using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Admissionremove2023")]
    public partial class Admissionremove2023
    {
        [Column("appnum")]
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("datecreated", TypeName = "datetime")]
        public DateTime? Datecreated { get; set; }
    }
}
