using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwSchoolFeesBreakDown
    {
        [Column("SFBID")]
        public int Sfbid { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string Code { get; set; } = null!;
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("LevelID")]
        public int LevelId { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
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
        public string LevelName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [Column("SessionID")]
        public int? SessionId { get; set; }
    }
}
