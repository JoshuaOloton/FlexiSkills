using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("onlineappComplain")]
    public partial class OnlineappComplain
    {
        [Column("complainID")]
        public int ComplainId { get; set; }
        [Column("appnum")]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("complain", TypeName = "text")]
        public string Complain { get; set; } = null!;
        [Column("complainDate")]
        [StringLength(50)]
        [Unicode(false)]
        public string ComplainDate { get; set; } = null!;
        [Column("status")]
        public int? Status { get; set; }
    }
}
