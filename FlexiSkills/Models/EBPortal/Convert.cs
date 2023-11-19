using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("convert")]
    public partial class Convert
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("programmeid")]
        public int? Programmeid { get; set; }
    }
}
