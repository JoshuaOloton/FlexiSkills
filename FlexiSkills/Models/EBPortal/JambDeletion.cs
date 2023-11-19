using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("JambDeletion")]
    public partial class JambDeletion
    {
        [Column("SN")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Key]
        [Column("UTMENUMBER")]
        [StringLength(255)]
        public string Utmenumber { get; set; } = null!;
        [Column("SURNAME")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("OTHERNAME")]
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("PROGRAM")]
        [StringLength(255)]
        public string? Program { get; set; }
    }
}
