using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("escreenExemption")]
    public partial class EscreenExemption1
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("createdBy")]
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column("dateCreated")]
        [StringLength(20)]
        public string DateCreated { get; set; } = null!;
    }
}
