using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("complaintAll")]
    public partial class ComplaintAll
    {
        public ComplaintAll()
        {
            ApplicantComplaints = new HashSet<ApplicantComplaint>();
        }

        [Key]
        [Column("ComplaintID")]
        [StringLength(50)]
        [Unicode(false)]
        public string ComplaintId { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string? ComplaintName { get; set; }

        [InverseProperty("ComplaintNavigation")]
        public virtual ICollection<ApplicantComplaint> ApplicantComplaints { get; set; }
    }
}
