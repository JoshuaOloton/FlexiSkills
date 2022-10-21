using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeAllSecond_copy")]
    public partial class PostutmeAllSecondCopy
    {
        [Key]
        [Column("UTMENumber")]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Othername { get; set; } = null!;
        [Column("GenderID")]
        public int GenderId { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string PhoneNumber { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        public int Score { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("LGAID")]
        public int? Lgaid { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? SubjectCombination { get; set; }

        [ForeignKey("GenderId")]
        [InverseProperty("PostutmeAllSecondCopies")]
        public virtual Gender Gender { get; set; } = null!;
        [ForeignKey("ProgramId")]
        [InverseProperty("PostutmeAllSecondCopies")]
        public virtual Program Program { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("PostutmeAllSecondCopies")]
        public virtual Session Session { get; set; } = null!;
    }
}
