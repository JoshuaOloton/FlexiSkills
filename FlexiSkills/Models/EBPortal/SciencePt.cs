using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("SciencePT")]
    public partial class SciencePt
    {
        [StringLength(255)]
        public string? Appnum { get; set; }
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [StringLength(255)]
        public string? InstitutionAttended { get; set; }
        [StringLength(255)]
        public string? Course { get; set; }
        [StringLength(255)]
        public string? Grade { get; set; }
        [Column("Olevel Result")]
        [StringLength(255)]
        public string? OlevelResult { get; set; }
    }
}
