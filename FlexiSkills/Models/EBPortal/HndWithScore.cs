using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("HND_WITH_SCORES")]
    public partial class HndWithScore
    {
        [StringLength(255)]
        public string? SchoolName { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("APPLICATIONNUMBER")]
        [StringLength(255)]
        public string? Applicationnumber { get; set; }
        [Column("SURNAME")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("OTHERNAME")]
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("TOTAL")]
        [StringLength(255)]
        public string? Total { get; set; }
        [Column("REMARK")]
        [StringLength(255)]
        public string? Remark { get; set; }
    }
}
