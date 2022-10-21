using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hnd_certificate")]
    public partial class HndCertificate
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("NDProgram")]
        [StringLength(255)]
        [Unicode(false)]
        public string Ndprogram { get; set; } = null!;
        [Column("HNDProgram")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Hndprogram { get; set; }
        public int? Allowed { get; set; }
    }
}
