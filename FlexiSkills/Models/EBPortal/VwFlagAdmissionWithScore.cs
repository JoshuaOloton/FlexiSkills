using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwFlagAdmissionWithScore
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("ALID")]
        public int Alid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column("ALName")]
        [StringLength(100)]
        [Unicode(false)]
        public string Alname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
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
        [Column("PGName")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Pgname { get; set; }
        [Column("PGAddress")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Pgaddress { get; set; }
        [Column("PGPhone")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Pgphone { get; set; }
        [Column("ProgramID")]
        public int? ProgramId { get; set; }
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
        [StringLength(50)]
        [Unicode(false)]
        public string StateName { get; set; } = null!;
        [Column("PCID")]
        public int Pcid { get; set; }
        [Column("PNID")]
        public int Pnid { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("PCName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcname { get; set; } = null!;
        [Column("PCAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
        [Column("PNName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pnname { get; set; } = null!;
        [Column("PTName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptname { get; set; } = null!;
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [Column("AGGREGATE")]
        public int? Aggregate { get; set; }
        public int Score { get; set; }
    }
}
