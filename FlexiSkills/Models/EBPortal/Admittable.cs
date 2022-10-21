using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Admittable")]
    public partial class Admittable
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Othername { get; set; } = null!;
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        public int? Aggregate { get; set; }
        public int? JambScore { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("Admittables")]
        public virtual Program Program { get; set; } = null!;
    }
}
