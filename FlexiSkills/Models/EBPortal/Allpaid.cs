using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ALLPAID")]
    public partial class Allpaid
    {
        [Key]
        [Column("matricnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
    }
}
