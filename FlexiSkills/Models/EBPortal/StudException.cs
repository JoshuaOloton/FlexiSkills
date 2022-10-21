using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("StudException")]
    public partial class StudException
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("RegNUmber")]
        [StringLength(20)]
        [Unicode(false)]
        public string RegNumber { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string CurrentSession { get; set; } = null!;
        public int? PaymentCategory { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Deadline { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string ApplicableSession { get; set; } = null!;
        [Column("SemesterID")]
        public int? SemesterId { get; set; }
    }
}
