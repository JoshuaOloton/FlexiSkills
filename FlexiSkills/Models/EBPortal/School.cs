using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class School
    {
        public School()
        {
            Programs = new HashSet<Program>();
            SchoolAdmissionLists = new HashSet<SchoolAdmissionList>();
            SchoolFeesBreakdownCopies = new HashSet<SchoolFeesBreakdownCopy>();
            SchoolFeesBreakdowns = new HashSet<SchoolFeesBreakdown>();
        }

        [Key]
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        public int? SchoolId2 { get; set; }
        [StringLength(150)]
        public string? SchoolName1 { get; set; }

        [InverseProperty("School")]
        public virtual ICollection<Program> Programs { get; set; }
        [InverseProperty("School")]
        public virtual ICollection<SchoolAdmissionList> SchoolAdmissionLists { get; set; }
        [InverseProperty("School")]
        public virtual ICollection<SchoolFeesBreakdownCopy> SchoolFeesBreakdownCopies { get; set; }
        [InverseProperty("School")]
        public virtual ICollection<SchoolFeesBreakdown> SchoolFeesBreakdowns { get; set; }
    }
}
