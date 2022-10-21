using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwChangeofCourse
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("SexID")]
        public int? SexId { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Address { get; set; }
        [Column("POBID")]
        public int? Pobid { get; set; }
        [Column("LGAID")]
        public int? Lgaid { get; set; }
        [Column("PGAddress")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Pgaddress { get; set; }
        [Column("PGPhone")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Pgphone { get; set; }
        [Column("SessionID")]
        public int? SessionId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string Sex { get; set; } = null!;
        [Column("POBName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pobname { get; set; } = null!;
        [Column("LGAName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Lganame { get; set; } = null!;
        [Column("StateID")]
        public int StateId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string StateName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [Column("NOK")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Nok { get; set; }
        [Column("NOKRelationship")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Nokrelationship { get; set; }
        [Column("NOKPhone")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Nokphone { get; set; }
        [Column("OldProgramID")]
        public int OldProgramId { get; set; }
        [StringLength(154)]
        [Unicode(false)]
        public string OldProgram { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? DateUpdated { get; set; }
        [Column("PGName")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Pgname { get; set; }
        [Column("NewProgramID")]
        public int NewProgramId { get; set; }
        [StringLength(154)]
        [Unicode(false)]
        public string NewProgram { get; set; } = null!;
        [Column("NewPNName")]
        [StringLength(50)]
        [Unicode(false)]
        public string NewPnname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("NewPNID")]
        public int NewPnid { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? SubjectCombination { get; set; }
        public int UtmeScore { get; set; }
        [Column("AGGREGATE")]
        public int? Aggregate { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column("PCID")]
        public int Pcid { get; set; }
    }
}
