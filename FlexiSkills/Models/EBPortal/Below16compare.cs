using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("BELOW16COMPARE")]
    public partial class Below16compare
    {
        [Column("candname")]
        [StringLength(255)]
        public string? Candname { get; set; }
        [Column("regnumb")]
        [StringLength(255)]
        public string? Regnumb { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [Column("JAMB_AGE")]
        [StringLength(255)]
        public string? JambAge { get; set; }
        [Column("YABATECH_AGE")]
        public int? YabatechAge { get; set; }
    }
}
