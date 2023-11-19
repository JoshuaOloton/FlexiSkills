using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("dobs")]
    public partial class Dob
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("dob")]
        [StringLength(50)]
        public string? Dob1 { get; set; }
        [Column("dob2", TypeName = "date")]
        public DateTime? Dob2 { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("status")]
        public int? Status { get; set; }
    }
}
