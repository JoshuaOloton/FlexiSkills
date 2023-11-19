using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("medicalFire")]
    public partial class MedicalFire
    {
        public double? Sn { get; set; }
        [StringLength(255)]
        public string? Matricnum { get; set; }
    }
}
