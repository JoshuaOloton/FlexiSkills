using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Admission")]
    public partial class Admission
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Createdby { get; set; } = null!;

        [InverseProperty("AppnumNavigation")]
        public virtual AcceptanceFee AcceptanceFee { get; set; } = null!;
        [InverseProperty("AppnumNavigation")]
        public virtual AdmissionRejectionPayment AdmissionRejectionPayment { get; set; } = null!;
        [InverseProperty("AppnumNavigation")]
        public virtual AdmissionRejectionPaymentsCopy AdmissionRejectionPaymentsCopy { get; set; } = null!;
    }
}
