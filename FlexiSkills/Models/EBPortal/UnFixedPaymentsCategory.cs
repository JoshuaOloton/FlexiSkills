using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("UnFixedPaymentsCategory")]
    public partial class UnFixedPaymentsCategory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("category_name")]
        [StringLength(255)]
        [Unicode(false)]
        public string CategoryName { get; set; } = null!;
        [Column("statusview")]
        public int Statusview { get; set; }
    }
}
