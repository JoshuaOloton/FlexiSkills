using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwCourseRegistrationDetail
    {
        [Column("CRDID")]
        public int Crdid { get; set; }
        [Column("CRID")]
        public int Crid { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
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
        [Column("SFID")]
        public int Sfid { get; set; }
        [Column("PLSID")]
        public int Plsid { get; set; }
        [Column("ProgramID")]
        public int? ProgramId { get; set; }
        [Column("PCID")]
        public int Pcid { get; set; }
        [Column("PNID")]
        public int Pnid { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LevelName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SemesterName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [Column("CCID")]
        public int? Ccid { get; set; }
        [Column("CTID")]
        public int? Ctid { get; set; }
        [Column("CSID")]
        public int? Csid { get; set; }
        public int? CourseUnit { get; set; }
        [Column("CCName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ccname { get; set; } = null!;
        [Column("CTName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Ctname { get; set; } = null!;
        [Column("CSCode")]
        [StringLength(50)]
        [Unicode(false)]
        public string Cscode { get; set; } = null!;
        [Column("CSName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Csname { get; set; } = null!;
    }
}
