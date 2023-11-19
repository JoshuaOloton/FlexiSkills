using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Jambvsyabaolevel")]
    public partial class Jambvsyabaolevel
    {
        [StringLength(255)]
        public string? JambSubject { get; set; }
        [StringLength(255)]
        public string? YabaSub { get; set; }
        [Column("SN")]
        public int Sn { get; set; }
    }
}
