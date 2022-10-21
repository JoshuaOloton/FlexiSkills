using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Civl_HND")]
    public partial class CivlHnd
    {
        [Key]
        [Column("APPLICATIONNUMBER")]
        [StringLength(255)]
        public string Applicationnumber { get; set; } = null!;
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
        [Column("REMARK")]
        [StringLength(255)]
        public string? Remark { get; set; }
        [Column("ND GRADE ")]
        [StringLength(255)]
        public string? NdGrade { get; set; }
        [Column("ND INST.")]
        [StringLength(255)]
        public string? NdInst { get; set; }
    }
}
