using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("AdmissionList")]
    public partial class AdmissionList
    {
        public AdmissionList()
        {
            FlagAdmissionCopies = new HashSet<FlagAdmissionCopy>();
            FlagAdmissionCopy1s = new HashSet<FlagAdmissionCopy1>();
            FlagAdmissions = new HashSet<FlagAdmission>();
            SchoolAdmissionLists = new HashSet<SchoolAdmissionList>();
        }

        [Key]
        [Column("ALID")]
        public int Alid { get; set; }
        [Column("ALName")]
        [StringLength(100)]
        [Unicode(false)]
        public string Alname { get; set; } = null!;
        public int Priority { get; set; }

        [InverseProperty("Al")]
        public virtual ICollection<FlagAdmissionCopy> FlagAdmissionCopies { get; set; }
        [InverseProperty("Al")]
        public virtual ICollection<FlagAdmissionCopy1> FlagAdmissionCopy1s { get; set; }
        [InverseProperty("Al")]
        public virtual ICollection<FlagAdmission> FlagAdmissions { get; set; }
        [InverseProperty("Al")]
        public virtual ICollection<SchoolAdmissionList> SchoolAdmissionLists { get; set; }
    }
}
