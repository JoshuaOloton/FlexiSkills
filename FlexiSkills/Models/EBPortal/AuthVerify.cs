using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Auth_Verify")]
    public partial class AuthVerify
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("cat")]
        public int? Cat { get; set; }
        [Column("usageStatus")]
        public int? UsageStatus { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
