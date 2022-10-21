using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("newJambErrorAfterAdmission")]
    public partial class NewJambErrorAfterAdmission
    {
        [Column("regno")]
        [StringLength(255)]
        public string? Regno { get; set; }
        [Column("criteria")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [StringLength(255)]
        public string? Error { get; set; }
    }
}
