using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("allottedstudents2")]
    public partial class Allottedstudents2
    {
        [Column("id")]
        [StringLength(255)]
        public string? Id { get; set; }
        [StringLength(255)]
        public string? MatricNum { get; set; }
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [StringLength(255)]
        public string? Sex { get; set; }
        [StringLength(255)]
        public string? AcadSession { get; set; }
        [StringLength(255)]
        public string? Course { get; set; }
        [StringLength(255)]
        public string? Level { get; set; }
        [StringLength(255)]
        public string? AllotStatus { get; set; }
        [StringLength(255)]
        public string? HostelList { get; set; }
        [StringLength(255)]
        public string? AllotDate { get; set; }
        [StringLength(255)]
        public string? HostelAllotted { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? PaymentApproval { get; set; }
        [StringLength(255)]
        public string? PaymentDeadline { get; set; }
        [StringLength(255)]
        public string? RoomNumber { get; set; }
        [StringLength(255)]
        public string? Appnum { get; set; }
    }
}
