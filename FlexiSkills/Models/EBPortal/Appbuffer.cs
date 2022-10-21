using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Appbuffer")]
    public partial class Appbuffer
    {
        [StringLength(150)]
        public string? Appnum { get; set; }
        [StringLength(250)]
        public string? Surname { get; set; }
        [StringLength(250)]
        public string? Firstname { get; set; }
        [StringLength(250)]
        public string? Othername { get; set; }
        [Column("sexid")]
        public int? Sexid { get; set; }
        [Column("progid")]
        public int? Progid { get; set; }
        [Column("email")]
        [StringLength(250)]
        public string? Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Datecreated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateMoved { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
