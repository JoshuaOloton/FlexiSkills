using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("SeRVERLOS")]
    public partial class SeRverlo
    {
        [Column("passcode")]
        [StringLength(255)]
        public string? Passcode { get; set; }
        [StringLength(255)]
        public string? Score { get; set; }
        [StringLength(255)]
        public string? CourseCode { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
    }
}
