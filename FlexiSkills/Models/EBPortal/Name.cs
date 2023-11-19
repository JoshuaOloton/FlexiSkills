using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("names")]
    public partial class Name
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [StringLength(250)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(250)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(250)]
        public string? Othername { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
