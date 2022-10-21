using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ste_second_semester_1516")]
    public partial class SteSecondSemester1516
    {
        [Key]
        [StringLength(255)]
        [Unicode(false)]
        public string Matricno { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("ASession")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Asession { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Semester { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Prog { get; set; }
        [Column("SLevel")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Slevel { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Remark { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Cgpa { get; set; }
    }
}
