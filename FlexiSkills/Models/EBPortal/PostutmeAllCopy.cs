using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeAll_copy")]
    public partial class PostutmeAllCopy
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
        public string? Othername { get; set; }
        [Column("GenderID")]
        public int GenderId { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
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
        public int FirstChoice { get; set; }
        public int? PhysicalChallenge { get; set; }
    }
}
