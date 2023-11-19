using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Progerror")]
    public partial class Progerror
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public int? Programid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
