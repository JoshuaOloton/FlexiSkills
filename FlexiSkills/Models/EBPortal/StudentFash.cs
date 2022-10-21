using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("student_fash")]
    public partial class StudentFash
    {
        [Column("payer_id")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PayerId { get; set; }
        [Column("payer_name")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PayerName { get; set; }
    }
}
