using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Remita_error")]
    public partial class RemitaError
    {
        [Column("remita_rrr")]
        [StringLength(50)]
        public string? RemitaRrr { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
