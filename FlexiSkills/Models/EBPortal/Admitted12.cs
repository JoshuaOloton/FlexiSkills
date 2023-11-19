using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("admitted12")]
    public partial class Admitted12
    {
        [Column("sn")]
        public double? Sn { get; set; }
        [Column("deptid")]
        public double? Deptid { get; set; }
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("courseid")]
        [StringLength(255)]
        public string? Courseid { get; set; }
        [Column("course")]
        [StringLength(255)]
        public string? Course { get; set; }
        [Column("criteria")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [StringLength(255)]
        public string? Status { get; set; }
    }
}
