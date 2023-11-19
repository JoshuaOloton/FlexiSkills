using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("GradTable2016")]
    public partial class GradTable2016
    {
        [StringLength(50)]
        public string? Matrinum { get; set; }
        [StringLength(250)]
        public string? FullName { get; set; }
        [StringLength(250)]
        public string? Dept { get; set; }
        [StringLength(50)]
        public string? Asession { get; set; }
        [StringLength(50)]
        public string? Sex { get; set; }
        [StringLength(50)]
        public string? ProgramType { get; set; }
        [StringLength(50)]
        public string? FinalRemark { get; set; }
        [Column("cgpa", TypeName = "decimal(18, 2)")]
        public decimal? Cgpa { get; set; }
        [Column("DOB")]
        [StringLength(50)]
        public string? Dob { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        public string? Address { get; set; }
        [StringLength(150)]
        public string? Email { get; set; }
    }
}
