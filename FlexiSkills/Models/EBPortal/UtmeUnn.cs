using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("utmeUNN")]
    public partial class UtmeUnn
    {
        [Column("ID")]
        [StringLength(255)]
        public string Id { get; set; } = null!;
        [Column("PROGRAM")]
        [StringLength(255)]
        public string Program { get; set; } = null!;
        [Column("UTME_COMPULSORY_SUBJECTS")]
        [StringLength(255)]
        public string? UtmeCompulsorySubjects { get; set; }
        [Column("UTME_ELECTIVE_SUBJECTS")]
        [StringLength(255)]
        public string? UtmeElectiveSubjects { get; set; }
        [StringLength(255)]
        public string? CompulsoryTotal { get; set; }
        [StringLength(255)]
        public string? ElectivesTotal { get; set; }
    }
}
