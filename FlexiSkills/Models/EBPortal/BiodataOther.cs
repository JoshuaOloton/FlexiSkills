using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Biodata_Others")]
    [Index("PayerId", Name = "Biodata_Other_PayerID", IsUnique = true)]
    public partial class BiodataOther
    {
        [Key]
        [Column("PayerID")]
        [StringLength(50)]
        [Unicode(false)]
        public string PayerId { get; set; } = null!;
        [StringLength(500)]
        [Unicode(false)]
        public string? PayerName { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Address { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PaymentPurpose { get; set; }
    }
}
