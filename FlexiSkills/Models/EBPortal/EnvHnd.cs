using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("env_hnd")]
    public partial class EnvHnd
    {
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [StringLength(255)]
        public string? Total { get; set; }
    }
}
