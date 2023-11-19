using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Verified")]
    public partial class Verified
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
        [InverseProperty("Verified")]
        public virtual AcceptanceFee AppnumNavigation { get; set; } = null!;
    }
}
