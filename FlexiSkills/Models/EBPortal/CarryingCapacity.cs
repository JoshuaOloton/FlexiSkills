using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("carrying_capacity")]
    public partial class CarryingCapacity
    {
        [Key]
        [Column("PROGRAM")]
        [StringLength(255)]
        public string Program { get; set; } = null!;
        [Column("CARRY CAPACITY")]
        [StringLength(255)]
        public string? CarryCapacity { get; set; }
        [Column("ACCEPTANCE FEES")]
        [StringLength(255)]
        public string? AcceptanceFees { get; set; }
        [Column("SCHOOL FEES")]
        [StringLength(255)]
        public string? SchoolFees { get; set; }
    }
}
