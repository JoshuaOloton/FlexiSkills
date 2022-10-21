using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("fakeND_NCE_Result_1516")]
    public partial class FakeNdNceResult1516
    {
        [Column("S/N")]
        public int? SN { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string? Name { get; set; }
        [Column("INSTITUTION")]
        [StringLength(255)]
        public string? Institution { get; set; }
        [Key]
        [Column("MATRIC NO.")]
        [StringLength(255)]
        public string MatricNo { get; set; } = null!;
        [Column(" DEPT.")]
        [StringLength(255)]
        public string? Dept { get; set; }
        [Column("FINDINGS")]
        [StringLength(255)]
        public string? Findings { get; set; }
    }
}
