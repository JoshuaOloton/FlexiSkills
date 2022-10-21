using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwProgram
    {
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("PCID")]
        public int Pcid { get; set; }
        [Column("PNID")]
        public int Pnid { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        public int ActiveStatus { get; set; }
        public int? AppId { get; set; }
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
    }
}
