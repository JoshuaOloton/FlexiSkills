using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("TempLga")]
    public partial class TempLga
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [StringLength(150)]
        public string? Lga { get; set; }
        [Column("ID")]
        public int Id { get; set; }
    }
}
