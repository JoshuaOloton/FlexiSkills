using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Screening")]
    public partial class Screening
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;

        [ForeignKey("Appnum")]
        [InverseProperty("Screening")]
        public virtual AcceptanceFee AppnumNavigation { get; set; } = null!;
    }
}
