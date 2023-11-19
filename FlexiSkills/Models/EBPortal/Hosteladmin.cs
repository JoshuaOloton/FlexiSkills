using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hosteladmin")]
    public partial class Hosteladmin
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Username { get; set; } = null!;
        [StringLength(20)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [StringLength(200)]
        [Unicode(false)]
        public string Fullname { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Domain { get; set; } = null!;
        public int Access { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string SecurityLevel { get; set; } = null!;
        public int LogWatch { get; set; }
    }
}
