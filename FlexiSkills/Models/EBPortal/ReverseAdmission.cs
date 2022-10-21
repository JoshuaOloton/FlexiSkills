using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("ReverseAdmission")]
    public partial class ReverseAdmission
    {
        [Key]
        [Column("ReverseID")]
        public int ReverseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AdmissionCreatedby { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime AdmissionDateCreated { get; set; }
        [Column("AdmissionALID")]
        public int AdmissionAlid { get; set; }
    }
}
