using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("escreen_Exemption")]
    public partial class EscreenExemption
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
        [Column("dateCreated", TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ApprovedBy { get; set; } = null!;
        [Column("status")]
        [StringLength(100)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
    }
}
