using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("DayOne")]
    public partial class DayOne
    {
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("statename")]
        [StringLength(255)]
        public string? Statename { get; set; }
        [Column("utmescore")]
        [StringLength(255)]
        public string? Utmescore { get; set; }
        [StringLength(255)]
        public string? JambScore50 { get; set; }
        [Column("rawscore")]
        [StringLength(255)]
        public string? Rawscore { get; set; }
        [Column("PostUTMEScore50")]
        [StringLength(255)]
        public string? PostUtmescore50 { get; set; }
        [StringLength(255)]
        public string? Aggregate { get; set; }
    }
}
