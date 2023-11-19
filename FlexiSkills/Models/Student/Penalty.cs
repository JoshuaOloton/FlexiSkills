using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.Student
{
    [Keyless]
    [Table("penalty")]
    public partial class Penalty
    {
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PaymentName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Status { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DateCreated { get; set; }
    }
}
