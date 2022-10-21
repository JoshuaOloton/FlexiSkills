using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwCourse
    {
        [Column("CourseID")]
        public int CourseId { get; set; }
        [Column("CCID")]
        public int? Ccid { get; set; }
        [Column("CTID")]
        public int? Ctid { get; set; }
        [Column("CSID")]
        public int? Csid { get; set; }
        public int? CourseUnit { get; set; }
        [Column("PLSID")]
        public int? Plsid { get; set; }
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
        [Column("PLSName")]
        [StringLength(256)]
        [Unicode(false)]
        public string Plsname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LevelName { get; set; } = null!;
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("LevelID")]
        public int LevelId { get; set; }
        [Column("SemesterID")]
        public int SemesterId { get; set; }
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
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SemesterName { get; set; } = null!;
        [Column("PLSOrder")]
        public int Plsorder { get; set; }
    }
}
