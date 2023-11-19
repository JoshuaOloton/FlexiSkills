using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Tempst")]
    public partial class Tempst
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("lga")]
        [StringLength(150)]
        public string? Lga { get; set; }
        [Column("states")]
        [StringLength(150)]
        public string? States { get; set; }
        [Column("statesID")]
        public int? StatesId { get; set; }
    }
}
