using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("JambDE")]
    public partial class JambDe
    {
        [Column("ID")]
        [StringLength(255)]
        public string Id { get; set; } = null!;
        [Key]
        [StringLength(255)]
        public string Regnumb { get; set; } = null!;
        [StringLength(255)]
        public string? Name { get; set; }
        [Column("Sex_Age")]
        [StringLength(255)]
        public string? SexAge { get; set; }
        [Column("State_lga")]
        [StringLength(255)]
        public string? StateLga { get; set; }
        [StringLength(255)]
        public string? Qual { get; set; }
        [StringLength(255)]
        public string? Dep { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("CourseID")]
        [StringLength(255)]
        public string? CourseId { get; set; }
    }
}
