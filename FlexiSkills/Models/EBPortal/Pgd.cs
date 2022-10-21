using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("PGD")]
    public partial class Pgd
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("SURNAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("SESSION")]
        [StringLength(50)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [Column("OLEVEL")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Olevel { get; set; }
        [Column("PREV INSTITUTION")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PrevInstitution { get; set; }
    }
}
