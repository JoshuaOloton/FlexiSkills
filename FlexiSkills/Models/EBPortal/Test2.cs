using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("test2")]
    public partial class Test2
    {
        [Column("school")]
        [StringLength(50)]
        [Unicode(false)]
        public string? School { get; set; }
        [Column("programid")]
        public int? Programid { get; set; }
        [Column("program")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Program { get; set; }
        [Column("male")]
        public int? Male { get; set; }
        [Column("female")]
        public int? Female { get; set; }
    }
}
