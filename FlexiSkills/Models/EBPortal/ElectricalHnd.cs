using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Electrical_HND")]
    public partial class ElectricalHnd
    {
        [Key]
        [Column("appnum")]
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
        [Column("total")]
        [StringLength(255)]
        public string? Total { get; set; }
        [Column("ND GRADE")]
        [StringLength(255)]
        public string? NdGrade { get; set; }
        [Column("ND INSTITUTION")]
        [StringLength(255)]
        public string? NdInstitution { get; set; }
    }
}
