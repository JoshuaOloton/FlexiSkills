using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("clearance_verificationStatus")]
    public partial class ClearanceVerificationStatus
    {
        [Column("appnum")]
        [StringLength(200)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("docs")]
        [StringLength(200)]
        [Unicode(false)]
        public string Docs { get; set; } = null!;
        [Column("count_time")]
        public int CountTime { get; set; }
        [Column("date_uploaded")]
        [StringLength(100)]
        [Unicode(false)]
        public string DateUploaded { get; set; } = null!;
        [Column("date_modified")]
        [StringLength(100)]
        [Unicode(false)]
        public string? DateModified { get; set; }
        [Column("date_cleared")]
        [StringLength(100)]
        [Unicode(false)]
        public string? DateCleared { get; set; }
        [Column("status")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("Cleared_by")]
        [StringLength(100)]
        [Unicode(false)]
        public string? ClearedBy { get; set; }
        [Column("CLR_officerCode")]
        [StringLength(100)]
        [Unicode(false)]
        public string? ClrOfficerCode { get; set; }
        [Key]
        [Column("StatusID")]
        public int StatusId { get; set; }
        [Column("comment", TypeName = "text")]
        public string? Comment { get; set; }
        [Column("titleID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TitleId { get; set; }
        [Column("status2")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Status2 { get; set; }
        [Column("SchoolID")]
        [StringLength(100)]
        [Unicode(false)]
        public string? SchoolId { get; set; }
        [Column("timeCleared")]
        [StringLength(100)]
        [Unicode(false)]
        public string? TimeCleared { get; set; }
        [Column("onlineStatus")]
        [StringLength(100)]
        [Unicode(false)]
        public string? OnlineStatus { get; set; }
        [Column("entrySessionID")]
        public int? EntrySessionId { get; set; }
    }
}
