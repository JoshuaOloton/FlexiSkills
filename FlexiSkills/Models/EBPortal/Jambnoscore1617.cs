using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("jambnoscore1617")]
    public partial class Jambnoscore1617
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
    }
}
