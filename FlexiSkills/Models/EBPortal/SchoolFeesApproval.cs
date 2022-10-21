using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("SchoolFeesApproval")]
    public partial class SchoolFeesApproval
    {
        [Key]
        [Column("SFID")]
        public int Sfid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;

        [ForeignKey("Sfid")]
        [InverseProperty("SchoolFeesApproval")]
        public virtual SchoolFee Sf { get; set; } = null!;
    }
}
