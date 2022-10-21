using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("error127")]
    public partial class Error127
    {
        [Column("S/No")]
        public int? SNo { get; set; }
        [StringLength(255)]
        public string? Regnumb { get; set; }
        [StringLength(255)]
        public string? Remarks { get; set; }
        [StringLength(255)]
        public string? D { get; set; }
        [StringLength(255)]
        public string? E { get; set; }
    }
}
