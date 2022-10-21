using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("StudException_copy")]
    public partial class StudExceptionCopy
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("RegNUmber")]
        [StringLength(20)]
        [Unicode(false)]
        public string RegNumber { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Session { get; set; } = null!;
        [StringLength(500)]
        [Unicode(false)]
        public string? PaymentCategory { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Deadline { get; set; }
    }
}
