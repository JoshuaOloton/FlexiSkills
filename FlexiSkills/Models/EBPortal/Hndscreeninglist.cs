using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hndscreeninglist")]
    public partial class Hndscreeninglist
    {
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [Column("SURNAME")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Session { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("FIRSTNAME")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [Column("OTHERNAME")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Othername { get; set; }
    }
}
