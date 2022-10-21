using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("AllGRAD")]
    public partial class AllGrad
    {
        [Column("(No column name)")]
        [StringLength(255)]
        public string? NoColumnName { get; set; }
        [StringLength(255)]
        public string? Matricno { get; set; }
        [Column("ASession")]
        [StringLength(255)]
        public string? Asession { get; set; }
        [StringLength(255)]
        public string? Semester { get; set; }
        [StringLength(255)]
        public string? Dept { get; set; }
        [StringLength(255)]
        public string? Cgpa { get; set; }
        [Column("gradlev")]
        [StringLength(255)]
        public string? Gradlev { get; set; }
        [Column("phone no")]
        [StringLength(255)]
        public string? PhoneNo { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string? Email { get; set; }
    }
}
