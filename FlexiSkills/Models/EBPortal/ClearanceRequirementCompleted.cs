using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ClearanceRequirementCompleted")]
    public partial class ClearanceRequirementCompleted
    {
        [Column("appnum")]
        [StringLength(200)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("SchoolID")]
        [StringLength(200)]
        [Unicode(false)]
        public string SchoolId { get; set; } = null!;
        [Column("dateCompleted")]
        [StringLength(200)]
        [Unicode(false)]
        public string? DateCompleted { get; set; }
        [Column("onlineStatus")]
        [StringLength(200)]
        [Unicode(false)]
        public string? OnlineStatus { get; set; }
        [Column("status")]
        [StringLength(200)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [Column("comment")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Comment { get; set; }
        [Column("clearStatus")]
        [StringLength(200)]
        [Unicode(false)]
        public string? ClearStatus { get; set; }
        [Column("ID")]
        public int Id { get; set; }
        [Column("clearedBy")]
        [StringLength(200)]
        [Unicode(false)]
        public string? ClearedBy { get; set; }
        [Column("dateCleared")]
        [StringLength(200)]
        [Unicode(false)]
        public string? DateCleared { get; set; }
        [Column("clearanceCode")]
        [StringLength(200)]
        [Unicode(false)]
        public string? ClearanceCode { get; set; }
        [Column("token")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Token { get; set; }
        [Column("max_time")]
        public int? MaxTime { get; set; }
        [Column("entrySessionID")]
        public int? EntrySessionId { get; set; }
    }
}
