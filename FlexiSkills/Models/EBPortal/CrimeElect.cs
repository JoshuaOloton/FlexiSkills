using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("crimeElect")]
    public partial class CrimeElect
    {
        [Column("S/N")]
        [StringLength(255)]
        public string SN { get; set; } = null!;
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("STATE")]
        [StringLength(255)]
        public string? State { get; set; }
        [StringLength(255)]
        public string? InstitutionAttended { get; set; }
        [Column("ND Course")]
        [StringLength(255)]
        public string? NdCourse { get; set; }
        [Column("ND Grade")]
        [StringLength(255)]
        public string? NdGrade { get; set; }
        [Column("OLResult")]
        [StringLength(255)]
        public string? Olresult { get; set; }
        [Column("NO SIT")]
        [StringLength(255)]
        public string? NoSit { get; set; }
        [Column("SIT SCORE")]
        [StringLength(255)]
        public string? SitScore { get; set; }
        [Column("ND_60")]
        [StringLength(255)]
        public string? Nd60 { get; set; }
        [Column("ENG")]
        [StringLength(255)]
        public string? Eng { get; set; }
        [Column("MATHS")]
        [StringLength(255)]
        public string? Maths { get; set; }
        [Column("ECONS")]
        [StringLength(255)]
        public string? Econs { get; set; }
        [Column("COMM")]
        [StringLength(255)]
        public string? Comm { get; set; }
        [Column("other")]
        [StringLength(255)]
        public string? Other { get; set; }
        [Column("TOTOL")]
        [StringLength(255)]
        public string? Totol { get; set; }
        [Column("OL_40")]
        [StringLength(255)]
        public string? Ol40 { get; set; }
        [Column("TOTAL")]
        [StringLength(255)]
        public string? Total { get; set; }
    }
}
