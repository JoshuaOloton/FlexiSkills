using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("adminLogin")]
    public partial class AdminLogin
    {
        [Column("A_Id")]
        public int? AId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Username { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Password { get; set; }
    }
}
