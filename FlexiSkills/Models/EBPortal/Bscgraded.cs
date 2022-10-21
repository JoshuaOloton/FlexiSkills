using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("BSCGraded")]
    public partial class Bscgraded
    {
        [StringLength(255)]
        public string? Sn { get; set; }
        [Column("UTMENumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
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
        [StringLength(255)]
        public string? Olevel { get; set; }
        [StringLength(255)]
        public string? Raw { get; set; }
        [StringLength(255)]
        public string? Score100 { get; set; }
    }
}
