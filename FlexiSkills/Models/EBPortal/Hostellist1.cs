using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hostellist1")]
    public partial class Hostellist1
    {
        [StringLength(255)]
        public string? Sn { get; set; }
        [Key]
        [StringLength(255)]
        public string MatricNum { get; set; } = null!;
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [StringLength(255)]
        public string? Sex { get; set; }
        [StringLength(255)]
        public string? HostelList { get; set; }
        [StringLength(255)]
        public string? Hostel { get; set; }
        [StringLength(255)]
        public string? Paymentdate { get; set; }
        [StringLength(255)]
        public string? Amount { get; set; }
    }
}
