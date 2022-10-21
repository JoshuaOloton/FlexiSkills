using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("clubs")]
    [Index("Clubname", Name = "club", IsUnique = true)]
    [Index("Clubid", Name = "clubid", IsUnique = true)]
    public partial class Club
    {
        [Column("clubid")]
        [StringLength(20)]
        [Unicode(false)]
        public string Clubid { get; set; } = null!;
        [Key]
        [Column("clubname")]
        [StringLength(255)]
        [Unicode(false)]
        public string Clubname { get; set; } = null!;
    }
}
