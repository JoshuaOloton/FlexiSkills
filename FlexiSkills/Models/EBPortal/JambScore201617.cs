using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("JambScore201617")]
    public partial class JambScore201617
    {
        [Column("CandID")]
        public long CandId { get; set; }
        public long? JambScore { get; set; }
    }
}
