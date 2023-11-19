using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("metaaalur")]
    public partial class Metaaalur
    {
        [Column("S/N")]
        [StringLength(255)]
        public string? SN { get; set; }
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstaname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [StringLength(255)]
        public string? State { get; set; }
        [Column("Institution Attended")]
        [StringLength(255)]
        public string? InstitutionAttended { get; set; }
        [StringLength(255)]
        public string? Grade { get; set; }
        [Column("OLResult")]
        [StringLength(255)]
        public string? Olresult { get; set; }
        [Column("INST.")]
        [StringLength(255)]
        public string? Inst { get; set; }
        [Column("ENG")]
        [StringLength(255)]
        public string? Eng { get; set; }
        [Column("MATHS")]
        [StringLength(255)]
        public string? Maths { get; set; }
        [Column("PHY")]
        [StringLength(255)]
        public string? Phy { get; set; }
        [Column("CHEM")]
        [StringLength(255)]
        public string? Chem { get; set; }
        [Column("BIO")]
        [StringLength(255)]
        public string? Bio { get; set; }
        [Column("TOTAL")]
        [StringLength(255)]
        public string? Total { get; set; }
    }
}
