using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("clearanceFlag")]
    public partial class ClearanceFlag
    {
        [Column("flagID")]
        public int FlagId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string DateCreated { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column("status")]
        public int? Status { get; set; }
    }
}
