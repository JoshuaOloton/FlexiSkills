using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hostels")]
    [Index("Hostelid", Name = "hostelid", IsUnique = true)]
    public partial class Hostel
    {
        [Key]
        [Column("hostelid")]
        [StringLength(20)]
        [Unicode(false)]
        public string Hostelid { get; set; } = null!;
        [Column("hostelname")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Hostelname { get; set; }
        [Column("activelist")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Activelist { get; set; }
        [Column("sextype")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Sextype { get; set; }
        [Column("amount")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Amount { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Quota { get; set; }
    }
}
