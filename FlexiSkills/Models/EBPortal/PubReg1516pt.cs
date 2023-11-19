﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("PubReg1516pt")]
    public partial class PubReg1516pt
    {
        [Column("ASession")]
        [StringLength(80)]
        [Unicode(false)]
        public string? Asession { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Semester { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CosCode { get; set; }
        [Column("ca", TypeName = "decimal(18, 1)")]
        public decimal? Ca { get; set; }
        [Column("exam", TypeName = "decimal(18, 1)")]
        public decimal? Exam { get; set; }
        public int? Score { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Grade { get; set; }
        [Column("CUnit")]
        public int? Cunit { get; set; }
        [Column("CNature")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Cnature { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Clevel { get; set; }
        [Column("id")]
        [StringLength(100)]
        [Unicode(false)]
        public string Id { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? MatricNo { get; set; }
        [Column("CPoint", TypeName = "decimal(18, 2)")]
        public decimal? Cpoint { get; set; }
        public int? SemId { get; set; }
    }
}
