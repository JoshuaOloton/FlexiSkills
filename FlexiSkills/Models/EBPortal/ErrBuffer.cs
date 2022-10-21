using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Err_buffer")]
    public partial class ErrBuffer
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [StringLength(250)]
        public string? ErrorNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Datecreated { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
