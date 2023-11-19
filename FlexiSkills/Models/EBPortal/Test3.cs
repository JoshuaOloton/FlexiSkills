using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("test3")]
    public partial class Test3
    {
        [Column("programid")]
        public int? Programid { get; set; }
        [Column("program")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Program { get; set; }
        [Column("merit")]
        public int? Merit { get; set; }
        [Column("supplementary")]
        public int? Supplementary { get; set; }
        [Column("suppone")]
        public int? Suppone { get; set; }
        [Column("supptwo")]
        public int? Supptwo { get; set; }
        [Column("suppthree")]
        public int? Suppthree { get; set; }
        [Column("acceptance")]
        public int? Acceptance { get; set; }
    }
}
