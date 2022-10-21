using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("clearanceOfficer")]
    public partial class ClearanceOfficer
    {
        [Column("staffID")]
        public int StaffId { get; set; }
        [Column("email")]
        [StringLength(60)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("fullname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Fullname { get; set; } = null!;
        [Column("phone")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [Column("school")]
        public int School { get; set; }
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [Column("passcode")]
        [StringLength(50)]
        [Unicode(false)]
        public string Passcode { get; set; } = null!;
        [Column("Date_created")]
        [StringLength(80)]
        [Unicode(false)]
        public string DateCreated { get; set; } = null!;
        [Column("time_created")]
        [StringLength(80)]
        [Unicode(false)]
        public string TimeCreated { get; set; } = null!;
        [Column("createdBy")]
        public int CreatedBy { get; set; }
        [Column("protype")]
        [StringLength(20)]
        [Unicode(false)]
        public string Protype { get; set; } = null!;
        [Column("session_id")]
        public int SessionId { get; set; }
    }
}
