using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ClearanceOverride")]
    public partial class ClearanceOverride
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public string? Comment { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateCreated { get; set; }
        [Column("id")]
        public int Id { get; set; }
        public int? Mstatus { get; set; }
    }
}
