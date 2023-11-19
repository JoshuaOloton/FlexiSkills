using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("EbportalLog")]
    public partial class EbportalLog
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [Unicode(false)]
        public string LogDetail { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
    }
}
