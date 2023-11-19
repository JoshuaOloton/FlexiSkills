using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ClearanceReverse")]
    public partial class ClearanceReverse
    {
        [Key]
        [Column("CRID")]
        public int Crid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Clearedby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCleared { get; set; }
    }
}
