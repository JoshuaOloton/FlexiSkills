using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("newCollegeMatriccnumm")]
    [Index("Matricnum", "StudentNumber", Name = "UQ__MatricSt__0D9BEFB04E02474F", IsUnique = true)]
    [Index("StudentNumber", Name = "UQ__MatricSt__361A5E19CA3C6DEA", IsUnique = true)]
    public partial class NewCollegeMatriccnumm
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Appnum { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Session { get; set; }
        [Column("Student_Number")]
        [StringLength(20)]
        [Unicode(false)]
        public string StudentNumber { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? AllotedDate { get; set; }
        [Column(TypeName = "time(0)")]
        public TimeSpan? AllotedTime { get; set; }
    }
}
