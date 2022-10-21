using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class DirectStudent
    {
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("UTMENUMBER")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("programid")]
        [StringLength(255)]
        public string? Programid { get; set; }
        [Column("sessionid")]
        [StringLength(255)]
        public string? Sessionid { get; set; }
        [Column("lgaid")]
        [StringLength(255)]
        public string? Lgaid { get; set; }
    }
}
