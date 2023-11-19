using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwTertiaryInstitutionResult
    {
        [Column("TIRID")]
        public int Tirid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [Column("TIID")]
        public int? Tiid { get; set; }
        [Column("TIPNID")]
        public int? Tipnid { get; set; }
        [Column("TIGID")]
        public int? Tigid { get; set; }
        [Column("TIGName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tigname { get; set; } = null!;
        [Column("TIName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Tiname { get; set; } = null!;
        public bool BlackListed { get; set; }
        [Column("TIPName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Tipname { get; set; } = null!;
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
        [StringLength(50)]
        [Unicode(false)]
        public string QualificationName { get; set; } = null!;
    }
}
