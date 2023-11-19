using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("FlagAdmission")]
    public partial class FlagAdmission
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
        [InverseProperty("FlagAdmissions")]
        public virtual AdmissionList Al { get; set; } = null!;
    }
}
