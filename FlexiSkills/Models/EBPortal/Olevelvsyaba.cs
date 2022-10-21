using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("olevelvsyaba")]
    public partial class Olevelvsyaba
    {
        [StringLength(255)]
        public string? OnlineAppSubject { get; set; }
        [StringLength(255)]
        public string? YabaSub { get; set; }
        [Column("SN")]
        public int Sn { get; set; }
    }
}
