using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ChangeofCourse")]
    public partial class ChangeofCourse
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        [Column("NewProgramID")]
        public int NewProgramId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        [Column("PNNAME")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Pnname { get; set; }

        [ForeignKey("NewProgramId")]
        [InverseProperty("ChangeofCourses")]
        public virtual Program NewProgram { get; set; } = null!;
    }
}
