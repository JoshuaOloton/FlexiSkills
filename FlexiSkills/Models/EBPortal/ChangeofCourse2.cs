using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ChangeofCourse2")]
    public partial class ChangeofCourse2
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [StringLength(150)]
        public string? Newdept { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
