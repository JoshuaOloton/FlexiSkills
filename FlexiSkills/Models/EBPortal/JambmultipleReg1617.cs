using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("jambmultipleReg1617")]
    public partial class JambmultipleReg1617
    {
        [Key]
        [StringLength(20)]
        public string Appnum { get; set; } = null!;
        [Column("surname")]
        [StringLength(50)]
        public string? Surname { get; set; }
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? OtherName { get; set; }
        [Column("jambscore")]
        [StringLength(255)]
        public string? Jambscore { get; set; }
    }
}
