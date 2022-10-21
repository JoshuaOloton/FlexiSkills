using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("jambadmission")]
    public partial class Jambadmission
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("firstname1")]
        [StringLength(255)]
        public string? Firstname1 { get; set; }
    }
}
