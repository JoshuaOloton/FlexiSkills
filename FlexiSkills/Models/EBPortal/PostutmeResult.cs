using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PostutmeResult
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string UtmeNumber { get; set; } = null!;
        public int Score { get; set; }
        public int Aggregate { get; set; }
        public int ResultCount { get; set; }

        public virtual Biodata2 UtmeNumberNavigation { get; set; } = null!;
        [InverseProperty("UtmenumberNavigation")]
        public virtual PostutmeApplicantList PostutmeApplicantList { get; set; } = null!;
        [InverseProperty("UtmenumberNavigation")]
        public virtual PostutmeApplicantListCopy PostutmeApplicantListCopy { get; set; } = null!;
    }
}
