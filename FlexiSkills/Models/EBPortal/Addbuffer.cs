using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Addbuffer")]
    public partial class Addbuffer
    {
        [StringLength(150)]
        public string? Appnum { get; set; }
        public int? Progid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMoved { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
