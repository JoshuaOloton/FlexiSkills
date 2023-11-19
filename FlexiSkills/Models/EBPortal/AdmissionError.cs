using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("AdmissionError")]
    public partial class AdmissionError
    {
        [Column("REGNO")]
        [StringLength(255)]
        public string? Regno { get; set; }
    }
}
