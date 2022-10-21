using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("vw_complaint")]
    public partial class VwComplaint
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("appnum")]
        [StringLength(15)]
        [Unicode(false)]
        public string? Appnum { get; set; }
        [Column("fullname")]
        [StringLength(255)]
        [Unicode(false)]
        public string Fullname { get; set; } = null!;
        [Column("complaint")]
        [StringLength(255)]
        [Unicode(false)]
        public string Complaint { get; set; } = null!;
        [Column("description")]
        [StringLength(160)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [Column("date", TypeName = "date")]
        public DateTime? Date { get; set; }
        [Column("status")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("action")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Action { get; set; }
    }
}
