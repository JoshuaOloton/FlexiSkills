using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ChangeofCourse_history")]
    public partial class ChangeofCourseHistory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        [Column("NewProgramID")]
        public int NewProgramId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [ForeignKey("NewProgramId")]
        [InverseProperty("ChangeofCourseHistories")]
        public virtual Program NewProgram { get; set; } = null!;
    }
}
