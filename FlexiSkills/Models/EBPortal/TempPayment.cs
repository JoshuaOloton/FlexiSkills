using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Temp_Payment")]
    public partial class TempPayment
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Payment { get; set; }
        public int? Translevel { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
