using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class ApplicantComplaint
    {
        [Key]
        [Column("ComplaintTrackID")]
        [StringLength(100)]
        [Unicode(false)]
        public string ComplaintTrackId { get; set; } = null!;
        [Column("UTMENumber")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Utmenumber { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ApplicantName { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Complaint { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SubmittedDateTime { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? ComplaintStatus { get; set; }
        [Column(TypeName = "text")]
        public string? Remark { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? MerchantRef { get; set; }

        [ForeignKey("Complaint")]
        [InverseProperty("ApplicantComplaints")]
        public virtual ComplaintAll? ComplaintNavigation { get; set; }
    }
}
