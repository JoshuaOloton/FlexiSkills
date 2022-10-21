using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("BSC100Graded")]
    public partial class Bsc100graded
    {
        [Column("SN")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [StringLength(255)]
        public string? Appnum { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [StringLength(255)]
        public string? Olevel { get; set; }
        [StringLength(255)]
        public string? JambScore { get; set; }
        [StringLength(255)]
        public string? JambGrade { get; set; }
        [StringLength(255)]
        public string? OlevelGrade { get; set; }
        [StringLength(255)]
        public string? Aggregate { get; set; }
    }
}
