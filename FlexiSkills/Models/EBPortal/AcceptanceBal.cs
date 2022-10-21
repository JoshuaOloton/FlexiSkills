using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("acceptanceBal")]
    public partial class AcceptanceBal
    {
        [Column("id")]
        public int Id { get; set; }
        [Key]
        [StringLength(20)]
        public string Appnum { get; set; } = null!;
    }
}
