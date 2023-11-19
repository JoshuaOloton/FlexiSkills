using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ELDS")]
    public partial class Eld
    {
        [Key]
        [StringLength(11)]
        public string Id { get; set; } = null!;
        [Column("state_elds")]
        [StringLength(50)]
        public string? StateElds { get; set; }
    }
}
