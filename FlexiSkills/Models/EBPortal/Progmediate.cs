using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Progmediate")]
    public partial class Progmediate
    {
        [StringLength(150)]
        public string? Ebprog { get; set; }
        [StringLength(150)]
        public string? Regprog { get; set; }
        [Column("deptid")]
        public int? Deptid { get; set; }
        public int? Progid { get; set; }
        public int? Schoolid { get; set; }
        [Column("id")]
        public int? Id { get; set; }
    }
}
