using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.Student
{
    [Keyless]
    [Table("passportret")]
    public partial class Passportret
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("id")]
        public int? Id { get; set; }
    }
}
