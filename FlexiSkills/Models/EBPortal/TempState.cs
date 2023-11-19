using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class TempState
    {
        [Column("LGA")]
        [StringLength(150)]
        public string? Lga { get; set; }
        [StringLength(100)]
        public string? States { get; set; }
        [Column("StateID")]
        public int? StateId { get; set; }
    }
}
