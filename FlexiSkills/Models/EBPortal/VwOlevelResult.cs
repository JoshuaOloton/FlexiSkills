using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwOlevelResult
    {
        [Column("OLRID")]
        public int Olrid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [Column("OLSID")]
        public int Olsid { get; set; }
        [Column("OLGID")]
        public int Olgid { get; set; }
        [Column("OLSName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Olsname { get; set; } = null!;
        [Column("OLGName")]
        [StringLength(2)]
        [Unicode(false)]
        public string Olgname { get; set; } = null!;
    }
}
