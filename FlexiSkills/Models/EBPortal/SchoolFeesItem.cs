using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class SchoolFeesItem
    {
        public SchoolFeesItem()
        {
            SchoolFeesBreakdownCopies = new HashSet<SchoolFeesBreakdownCopy>();
            SchoolFeesBreakdowns = new HashSet<SchoolFeesBreakdown>();
        }

        [Key]
        [StringLength(4)]
        [Unicode(false)]
        public string Code { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        public int? StatusView { get; set; }

        [InverseProperty("CodeNavigation")]
        public virtual ICollection<SchoolFeesBreakdownCopy> SchoolFeesBreakdownCopies { get; set; }
        [InverseProperty("CodeNavigation")]
        public virtual ICollection<SchoolFeesBreakdown> SchoolFeesBreakdowns { get; set; }
    }
}
