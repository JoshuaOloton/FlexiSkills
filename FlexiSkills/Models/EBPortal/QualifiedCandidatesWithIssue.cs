using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class QualifiedCandidatesWithIssue
    {
        [Column("CandID")]
        public long CandId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? OtherName { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string? Gender { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? RegNumber { get; set; }
        [Column("ConcantenateMESubjects")]
        [StringLength(250)]
        [Unicode(false)]
        public string? ConcantenateMesubjects { get; set; }
        public byte[]? Image { get; set; }
        [Column("course")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Course { get; set; }
        [Column("courseid")]
        public int? Courseid { get; set; }
        [Column("score")]
        public int? Score { get; set; }
    }
}
