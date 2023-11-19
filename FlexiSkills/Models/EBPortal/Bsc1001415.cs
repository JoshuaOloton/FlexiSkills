using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("BSC100_14_15")]
    public partial class Bsc1001415
    {
        [Key]
        [Column("candid")]
        [StringLength(255)]
        public string Candid { get; set; } = null!;
        [Key]
        [Column("examno")]
        [StringLength(255)]
        public string Examno { get; set; } = null!;
        [Key]
        [Column("regnumber")]
        [StringLength(255)]
        public string Regnumber { get; set; } = null!;
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("utmescore")]
        [StringLength(255)]
        public string? Utmescore { get; set; }
        [Column("aggregate")]
        [StringLength(255)]
        public string? Aggregate { get; set; }
        [StringLength(255)]
        public string? Criteria { get; set; }
    }
}
