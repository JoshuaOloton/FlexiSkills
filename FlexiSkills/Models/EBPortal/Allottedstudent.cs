using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("allottedstudents")]
    public partial class Allottedstudent
    {
        [StringLength(20)]
        [Unicode(false)]
        public string? MatricNum { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Sex { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? AcadSession { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? Course { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? AllotStatus { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? HostelList { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? AllotDate { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? HostelAllotted { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string? PaymentApproval { get; set; }
        public DateTime? PaymentDeadline { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? RoomNumber { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Appnum { get; set; }
    }
}
