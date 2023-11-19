using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("medicals")]
    public partial class Medical
    {
        public double? Sn { get; set; }
        [StringLength(255)]
        public string? Matricnum { get; set; }
    }
}
