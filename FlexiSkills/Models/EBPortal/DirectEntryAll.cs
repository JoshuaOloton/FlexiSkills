﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("DirectEntryAll")]
    public partial class DirectEntryAll
    {
        [Key]
        [Column("UTMENumber")]
        [StringLength(20)]
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
        public int? GenderId { get; set; }
        [StringLength(11)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("LGAID")]
        public int Lgaid { get; set; }
        public int PhysicalChallenge { get; set; }

        [ForeignKey("GenderId")]
        [InverseProperty("DirectEntryAlls")]
        public virtual Gender? Gender { get; set; }
        [ForeignKey("Lgaid")]
        [InverseProperty("DirectEntryAlls")]
        public virtual Lga Lga { get; set; } = null!;
        [ForeignKey("ProgramId")]
        [InverseProperty("DirectEntryAlls")]
        public virtual Program Program { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("DirectEntryAlls")]
        public virtual Session Session { get; set; } = null!;
    }
}
