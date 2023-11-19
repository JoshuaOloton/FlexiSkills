using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("stud_img")]
    public partial class StudImg
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("matricnum")]
        [StringLength(20)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("images")]
        public byte[] Images { get; set; } = null!;
    }
}
