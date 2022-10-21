using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwPtPayStatus
    {
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("surname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("Total_amount_paid", TypeName = "decimal(18, 2)")]
        public decimal? TotalAmountPaid { get; set; }
        [Column("program")]
        [StringLength(254)]
        public string? Program { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        [Column("level")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
        [Column("paystatus")]
        public int? Paystatus { get; set; }
    }
}
