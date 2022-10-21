using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class AdmissionUnflagReason
    {
        public AdmissionUnflagReason()
        {
            UnFlagAdmissions = new HashSet<UnFlagAdmission>();
        }

        [Key]
        [Column("ReasonID")]
        public int ReasonId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Reason { get; set; } = null!;

        [InverseProperty("Reason")]
        public virtual ICollection<UnFlagAdmission> UnFlagAdmissions { get; set; }
    }
}
