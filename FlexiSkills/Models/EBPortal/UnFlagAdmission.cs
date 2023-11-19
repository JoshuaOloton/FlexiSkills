using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("UnFlagAdmission")]
    public partial class UnFlagAdmission
    {
        [Key]
        [Column("UnFlagID")]
        public int UnFlagId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [Column("ReasonID")]
        public int ReasonId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FlagCreatedby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime FlagDateCreated { get; set; }
        [Column("FlagALID")]
        public int FlagAlid { get; set; }

        [ForeignKey("ReasonId")]
        [InverseProperty("UnFlagAdmissions")]
        public virtual AdmissionUnflagReason Reason { get; set; } = null!;
    }
}
