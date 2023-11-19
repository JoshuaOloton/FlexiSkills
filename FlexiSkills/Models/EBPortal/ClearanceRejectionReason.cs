using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("clearanceRejectionReason")]
    public partial class ClearanceRejectionReason
    {
        [Column("reason", TypeName = "text")]
        public string Reason { get; set; } = null!;
        [Column("ID")]
        public int Id { get; set; }
    }
}
