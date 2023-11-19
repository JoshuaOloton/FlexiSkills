using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("hostelpayment")]
    public partial class Hostelpayment
    {
        [StringLength(30)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Middlename { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Programme { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? AcadSession { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Hostel { get; set; }
        [Column(TypeName = "decimal(11, 2)")]
        public decimal? Amount { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? PaymentStatus { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? PaymentDate { get; set; }
    }
}
