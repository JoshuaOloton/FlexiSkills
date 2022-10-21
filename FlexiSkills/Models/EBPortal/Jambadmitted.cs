using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("jambadmitted")]
    public partial class Jambadmitted
    {
        [Column("id")]
        [StringLength(255)]
        public string? Id { get; set; }
        [StringLength(255)]
        public string? UtmeNumber { get; set; }
    }
}
