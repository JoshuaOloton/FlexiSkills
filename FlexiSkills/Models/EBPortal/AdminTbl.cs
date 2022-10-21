using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("adminTbl")]
    public partial class AdminTbl
    {
        [Column("id")]
        public int Id { get; set; }
        [Key]
        [Column("userName")]
        [StringLength(20)]
        public string UserName { get; set; } = null!;
        [Column("userPass")]
        [StringLength(20)]
        public string UserPass { get; set; } = null!;
        [Column("createdDate")]
        [StringLength(20)]
        public string CreatedDate { get; set; } = null!;
        [Column("lastLogin")]
        [StringLength(30)]
        public string LastLogin { get; set; } = null!;
        [Column("adminLevel")]
        [StringLength(2)]
        public string AdminLevel { get; set; } = null!;
    }
}
