using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("er4_bsc1516")]
    public partial class Er4Bsc1516
    {
        [Column("matricnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("surname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [Column("firstname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [Column("othername")]
        [StringLength(100)]
        [Unicode(false)]
        public string Othername { get; set; } = null!;
        [Column("LEVEL")]
        [StringLength(20)]
        [Unicode(false)]
        public string Level { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [Column("deptname")]
        [StringLength(255)]
        [Unicode(false)]
        public string Deptname { get; set; } = null!;
        [Column("facultyname", TypeName = "text")]
        public string Facultyname { get; set; } = null!;
        [Column("degreetype")]
        [StringLength(1)]
        [Unicode(false)]
        public string Degreetype { get; set; } = null!;
        [Column("courseoptions")]
        [StringLength(1)]
        [Unicode(false)]
        public string Courseoptions { get; set; } = null!;
    }
}
