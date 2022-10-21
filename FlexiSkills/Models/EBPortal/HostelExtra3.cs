using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("HostelExtra3")]
    public partial class HostelExtra3
    {
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
        public string? Level { get; set; }
        [StringLength(255)]
        public string? AllotStatus { get; set; }
        [StringLength(255)]
        public string? HostelList { get; set; }
        [StringLength(255)]
        public string? PaymentApproval { get; set; }
    }
}
