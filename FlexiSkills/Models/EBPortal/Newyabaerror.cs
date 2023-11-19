using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("newyabaerror")]
    public partial class Newyabaerror
    {
        [Column("SNo")]
        [StringLength(255)]
        public string Sno { get; set; } = null!;
        [StringLength(255)]
        public string RegNo { get; set; } = null!;
        [StringLength(255)]
        public string? CorsId { get; set; }
        [Column("criteria")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [StringLength(255)]
        public string? RejectStage { get; set; }
        [StringLength(255)]
        public string? Error { get; set; }
        [StringLength(255)]
        public string? BatchNo { get; set; }
    }
}
