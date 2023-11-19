using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("eenableddvverified")]
    public partial class Eenableddvverified
    {
        [Column("matricnum")]
        [StringLength(20)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("session")]
        [StringLength(10)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [Column("semester")]
        [StringLength(10)]
        [Unicode(false)]
        public string Semester { get; set; } = null!;
        [Column("docketId")]
        [StringLength(10)]
        [Unicode(false)]
        public string DocketId { get; set; } = null!;
        [Column("dateprinted", TypeName = "datetime")]
        public DateTime? Dateprinted { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
