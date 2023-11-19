using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("StudTab_copy1")]
    public partial class StudTabCopy1
    {
        [StringLength(50)]
        [Unicode(false)]
        public string UtmeReg { get; set; } = null!;
        [Column("id")]
        public int Id { get; set; }
        public byte[]? Finger { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? SchoolName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ProgName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? ClassName { get; set; }
    }
}
