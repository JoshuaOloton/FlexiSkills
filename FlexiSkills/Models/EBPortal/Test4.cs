using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("test4")]
    public partial class Test4
    {
        [Column("programid")]
        public int? Programid { get; set; }
        [Column("program")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Program { get; set; }
        [Column("acceptance")]
        public int? Acceptance { get; set; }
        [Column("rejection")]
        public int? Rejection { get; set; }
    }
}
