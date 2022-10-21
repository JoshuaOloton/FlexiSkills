using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Reverify_Category")]
    public partial class ReverifyCategory
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("category")]
        public int? Category { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
