using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeApplicantList_copy")]
    public partial class PostutmeApplicantListCopy
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;

        [ForeignKey("Utmenumber")]
        [InverseProperty("PostutmeApplicantListCopy")]
        public virtual PostutmeResult UtmenumberNavigation { get; set; } = null!;
    }
}
