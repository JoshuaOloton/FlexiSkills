using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("selectedSitting")]
    public partial class SelectedSitting
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("appnum")]
        [MaxLength(50)]
        public byte[] Appnum { get; set; } = null!;
        [Column("sittingID")]
        public int SittingId { get; set; }
        [Column("dateCreated", TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column("sessionID")]
        public int? SessionId { get; set; }
        [Column("dateUpdated", TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ApplicationNum { get; set; }
    }
}
