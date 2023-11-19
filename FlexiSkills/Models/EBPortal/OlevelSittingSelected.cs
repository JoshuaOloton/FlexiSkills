using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("OlevelSittingSelected")]
    public partial class OlevelSittingSelected
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("appnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("sittingID")]
        public int SittingId { get; set; }
        [Column("sessionID")]
        public int SessionId { get; set; }
        [Column("dateCreated", TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column("dateUpdate", TypeName = "datetime")]
        public DateTime DateUpdate { get; set; }
    }
}
