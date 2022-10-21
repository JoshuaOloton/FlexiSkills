using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwTertiaryInstitutionResultApplicant2
    {
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [Column("TIID")]
        public int? Tiid { get; set; }
        [Column("TIPNID")]
        public int? Tipnid { get; set; }
        [Column("TIGID")]
        public int? Tigid { get; set; }
        [Column("TIFrom")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tifrom { get; set; }
        [Column("TITo")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Tito { get; set; }
        [Column("QualificationID")]
        public int? QualificationId { get; set; }
        [Column("TIName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Tiname { get; set; } = null!;
        [Column("PNName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pnname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string QualificationName { get; set; } = null!;
        [Column("TIGName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tigname { get; set; } = null!;
    }
}
