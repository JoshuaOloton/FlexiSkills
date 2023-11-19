using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("DUPS_EED")]
    public partial class DupsEed
    {
        [Column("PASSCODE")]
        [StringLength(255)]
        public string? Passcode { get; set; }
    }
}
