using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("FlagAdmission_copy")]
    public partial class FlagAdmissionCopy
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("ALID")]
        public int Alid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [ForeignKey("Alid")]
        [InverseProperty("FlagAdmissionCopies")]
        public virtual AdmissionList Al { get; set; } = null!;
    }
}
