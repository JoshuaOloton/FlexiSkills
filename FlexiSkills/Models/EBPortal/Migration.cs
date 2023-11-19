using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Migration")]
    public partial class Migration
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public int? Progid { get; set; }
        [Column("id")]
        public int Id { get; set; }
        public int? Status { get; set; }
    }
}
