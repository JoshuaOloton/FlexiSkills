using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("gradsegun")]
    public partial class Gradsegun
    {
        [StringLength(255)]
        public string? Matricno { get; set; }
        [Column("(No column name)")]
        [StringLength(255)]
        public string? NoColumnName { get; set; }
        public double? Cgpa { get; set; }
        [Column("ASession")]
        [StringLength(255)]
        public string? Asession { get; set; }
        [StringLength(255)]
        public string? Semester { get; set; }
        [StringLength(255)]
        public string? Dept { get; set; }
        [Column("SLevel")]
        [StringLength(255)]
        public string? Slevel { get; set; }
        [StringLength(255)]
        public string? Prog { get; set; }
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("gradlev")]
        [StringLength(255)]
        public string? Gradlev { get; set; }
    }
}
