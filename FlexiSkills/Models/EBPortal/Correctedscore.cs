using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("correctedscores")]
    public partial class Correctedscore
    {
        [StringLength(255)]
        public string? RegNumber { get; set; }
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? FirstName { get; set; }
        [StringLength(255)]
        public string? OtherName { get; set; }
        [StringLength(255)]
        public string? Scorecombined { get; set; }
        [Column("realscore")]
        [StringLength(255)]
        public string? Realscore { get; set; }
    }
}
