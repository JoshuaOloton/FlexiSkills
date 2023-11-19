using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ime_HND2")]
    public partial class ImeHnd2
    {
        [Key]
        [Column("APPNUM")]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [Column("SURNAME")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("OTHERNAME")]
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("TOTAL")]
        [StringLength(255)]
        public string? Total { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string? Status { get; set; }
        [Column("ND GRADE ")]
        [StringLength(255)]
        public string? NdGrade { get; set; }
        [Column("ND INSTITUTION")]
        [StringLength(255)]
        public string? NdInstitution { get; set; }
    }
}
