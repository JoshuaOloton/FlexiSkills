using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("error4")]
    public partial class Error4
    {
        [Column("Remita_rrr")]
        [StringLength(50)]
        public string? RemitaRrr { get; set; }
        [StringLength(50)]
        public string? Payeenum { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
