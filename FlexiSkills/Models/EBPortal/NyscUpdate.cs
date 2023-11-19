using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("nysc_update")]
    public partial class NyscUpdate
    {
        [Column("surname")]
        [StringLength(200)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(200)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(200)]
        public string? Othername { get; set; }
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("dept")]
        [StringLength(200)]
        public string? Dept { get; set; }
        [Column("phone")]
        public int? Phone { get; set; }
        [Column("dob")]
        [StringLength(200)]
        public string? Dob { get; set; }
        [Column("state")]
        [StringLength(200)]
        public string? State { get; set; }
        [Column("prog")]
        [StringLength(200)]
        public string? Prog { get; set; }
        [Column("gradlev")]
        [StringLength(50)]
        public string? Gradlev { get; set; }
        [Column("graddate")]
        [StringLength(200)]
        public string? Graddate { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
