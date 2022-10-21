using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("error21")]
    public partial class Error21
    {
        [Column("SNo")]
        [StringLength(255)]
        public string? Sno { get; set; }
        [Key]
        [StringLength(255)]
        public string Regnumb { get; set; } = null!;
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
