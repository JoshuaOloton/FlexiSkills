using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwGradTable2016
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
        public string? ProgramType { get; set; }
        [StringLength(50)]
        public string? FinalRemark { get; set; }
        [Column("cgpa", TypeName = "decimal(18, 2)")]
        public decimal? Cgpa { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Sex { get; set; } = null!;
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Address { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("PTName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptname { get; set; } = null!;
        [Column("PNName")]
        [StringLength(150)]
        public string? Pnname { get; set; }
        [Column("PCAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
    }
}
