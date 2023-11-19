using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("found")]
    public partial class Found
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        public int? Score { get; set; }
        [Column("subject")]
        [StringLength(50)]
        public string? Subject { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
