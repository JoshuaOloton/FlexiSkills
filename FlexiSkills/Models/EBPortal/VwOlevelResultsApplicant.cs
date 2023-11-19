using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwOlevelResultsApplicant
    {
        [Column("OLRID")]
        public int Olrid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("OLSID")]
        public int Olsid { get; set; }
        [Column("OLGID")]
        public int Olgid { get; set; }
        [Column("OLSName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Olsname { get; set; } = null!;
        [Column("OLGName")]
        [StringLength(4)]
        [Unicode(false)]
        public string? Olgname { get; set; }
        [Column("SittingID")]
        public int? SittingId { get; set; }
    }
}
