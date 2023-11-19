using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("PGDFULLTIME")]
    public partial class Pgdfulltime
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string EntrySession { get; set; } = null!;
        [Column("olevel")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Olevel { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? PrevInstitution { get; set; }
    }
}
