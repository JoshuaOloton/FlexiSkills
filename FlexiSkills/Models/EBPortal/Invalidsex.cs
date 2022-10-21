using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("invalidsex")]
    public partial class Invalidsex
    {
        [Column("matricnum")]
        [StringLength(50)]
        public string? Matricnum { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
