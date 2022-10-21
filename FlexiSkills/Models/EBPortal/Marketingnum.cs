using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("MARKETINGNUM")]
    public partial class Marketingnum
    {
        [Column("PHONE")]
        [StringLength(255)]
        public string? Phone { get; set; }
    }
}
