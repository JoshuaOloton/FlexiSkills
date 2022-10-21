using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("test")]
    public partial class Test
    {
        [Column("programmeid")]
        public int? Programmeid { get; set; }
        [Column("PROGRAMME")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Programme { get; set; }
        [Column("ADMITTED")]
        public int? Admitted { get; set; }
        [Column("ACCEPTANCE")]
        public int? Acceptance { get; set; }
        [Column("CLEARED")]
        public int? Cleared { get; set; }
        [Column("SCHOOLFEE")]
        public int? Schoolfee { get; set; }
    }
}
