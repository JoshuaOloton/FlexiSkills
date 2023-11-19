using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwGenmatricno
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        public int? Progid { get; set; }
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("program")]
        [StringLength(254)]
        public string? Program { get; set; }
        [Column("pcacronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
        [Column("ptacronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [Column("pnname")]
        [StringLength(150)]
        public string? Pnname { get; set; }
        [Column("schoolname")]
        [StringLength(50)]
        [Unicode(false)]
        public string Schoolname { get; set; } = null!;
    }
}
