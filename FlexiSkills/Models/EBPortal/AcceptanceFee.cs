using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class AcceptanceFee
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [Column("BankID")]
        public int BankId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ReceiptNumber { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? Paymentdate { get; set; }

        [ForeignKey("Appnum")]
        [InverseProperty("AcceptanceFee")]
        public virtual Admission AppnumNavigation { get; set; } = null!;
        [ForeignKey("BankId")]
        [InverseProperty("AcceptanceFees")]
        public virtual Bank Bank { get; set; } = null!;
        [InverseProperty("AppnumNavigation")]
        public virtual Clearance Clearance { get; set; } = null!;
        [InverseProperty("AppnumNavigation")]
        public virtual ClearanceNotQualified ClearanceNotQualified { get; set; } = null!;
        [InverseProperty("AppnumNavigation")]
        public virtual Screening Screening { get; set; } = null!;
        [InverseProperty("AppnumNavigation")]
        public virtual ScreeningNotQualified ScreeningNotQualified { get; set; } = null!;
        [InverseProperty("AppnumNavigation")]
        public virtual Verified Verified { get; set; } = null!;
    }
}
