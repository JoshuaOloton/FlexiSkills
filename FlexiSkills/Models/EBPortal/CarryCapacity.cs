using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("CarryCapacity")]
    public partial class CarryCapacity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [Column("CarryCapacity")]
        public int? CarryCapacity1 { get; set; }
        public int? PercentageIncrease { get; set; }
        public int? TotalCapacity { get; set; }
    }
}
