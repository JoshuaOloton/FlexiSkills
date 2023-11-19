using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hdn")]
    public partial class Hdn
    {
        [Key]
        [Column("appnum")]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
    }
}
