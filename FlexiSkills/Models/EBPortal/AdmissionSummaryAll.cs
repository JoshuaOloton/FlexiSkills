using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("AdmissionSummaryAll")]
    public partial class AdmissionSummaryAll
    {
        [Key]
        [StringLength(255)]
        public string Program { get; set; } = null!;
        [Column("Session2011_12")]
        [StringLength(255)]
        public string? Session201112 { get; set; }
        [Column("Session2012_13")]
        [StringLength(255)]
        public string? Session201213 { get; set; }
        [Column("Session2013_14")]
        [StringLength(255)]
        public string? Session201314 { get; set; }
        [Column("Session2014_15")]
        [StringLength(255)]
        public string? Session201415 { get; set; }
        [Column("Session2015_16")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Session201516 { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ProgramType { get; set; }
    }
}
