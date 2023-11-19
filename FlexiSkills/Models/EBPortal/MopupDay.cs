using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class MopupDay
    {
        [Key]
        [StringLength(255)]
        public string PassCode { get; set; } = null!;
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
        [StringLength(255)]
        public string? PostUtmeScore { get; set; }
        [Column("Jamb Score")]
        [StringLength(255)]
        public string? JambScore { get; set; }
        [Column("PostUTMEScore50")]
        [StringLength(255)]
        public string? PostUtmescore50 { get; set; }
        [StringLength(255)]
        public string? JambScore50 { get; set; }
        [StringLength(255)]
        public string? Aggregate { get; set; }
    }
}
