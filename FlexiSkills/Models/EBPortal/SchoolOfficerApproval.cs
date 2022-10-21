using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("schoolOfficerApproval")]
    public partial class SchoolOfficerApproval
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("appnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("createdBy")]
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column("date_created")]
        [StringLength(50)]
        [Unicode(false)]
        public string DateCreated { get; set; } = null!;
        [Column("time_created")]
        [StringLength(50)]
        [Unicode(false)]
        public string TimeCreated { get; set; } = null!;
        [Column("session_id")]
        public int SessionId { get; set; }
        [Column("remark")]
        [StringLength(50)]
        [Unicode(false)]
        public string Remark { get; set; } = null!;
    }
}
