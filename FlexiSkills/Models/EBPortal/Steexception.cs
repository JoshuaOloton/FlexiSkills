using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("steexception")]
    public partial class Steexception
    {
        [Column("appnum")]
        [StringLength(255)]
        public string? Appnum { get; set; }
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
    }
}
