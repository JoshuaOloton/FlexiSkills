using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("CorrectionPanelhistory")]
    public partial class CorrectionPanelhistory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string Regnum { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string OriginialEntry { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? NewEntry { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateTime { get; set; }
        public int? PaymentPurpose { get; set; }
    }
}
