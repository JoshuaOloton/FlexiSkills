using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("nysclist2021")]
    public partial class Nysclist2021
    {
        [Column("surname")]
        [StringLength(50)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(50)]
        public string? Firstname { get; set; }
        [Column("middlename")]
        [StringLength(50)]
        public string? Middlename { get; set; }
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("course")]
        [StringLength(50)]
        public string? Course { get; set; }
        [Column("degree")]
        [StringLength(50)]
        public string? Degree { get; set; }
        [Column("sex")]
        [StringLength(50)]
        public string? Sex { get; set; }
        [Column("phone")]
        [StringLength(50)]
        public string? Phone { get; set; }
        [Column("dob", TypeName = "datetime")]
        public DateTime? Dob { get; set; }
        [Column("state")]
        [StringLength(50)]
        public string? State { get; set; }
    }
}
