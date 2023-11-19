using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Index("Matricnum", "SessionId", Name = "IX_SchoolFees", IsUnique = true)]
    public partial class SchoolFee
    {
        public SchoolFee()
        {
            CourseRegistrationLatePayments = new HashSet<CourseRegistrationLatePayment>();
            CourseRegistrationLateSubmissions = new HashSet<CourseRegistrationLateSubmission>();
        }

        [Key]
        [Column("SFID")]
        public int Sfid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Matricnum { get; set; } = null!;
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("BankID")]
        public int BankId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime Paymentdate { get; set; }
        [Column("LevelID")]
        public int LevelId { get; set; }
        [Column("MerchantID")]
        public int MerchantId { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("SchoolFees")]
        public virtual Bank Bank { get; set; } = null!;
        [ForeignKey("LevelId")]
        [InverseProperty("SchoolFees")]
        public virtual Level Level { get; set; } = null!;
        [ForeignKey("MerchantId")]
        [InverseProperty("SchoolFees")]
        public virtual Account Merchant { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("SchoolFees")]
        public virtual Session Session { get; set; } = null!;
        [InverseProperty("Hap")]
        public virtual HostelApplicationPayment HostelApplicationPayment { get; set; } = null!;
        [InverseProperty("Sf")]
        public virtual SchoolFeesApproval SchoolFeesApproval { get; set; } = null!;
        [InverseProperty("Sf")]
        public virtual ICollection<CourseRegistrationLatePayment> CourseRegistrationLatePayments { get; set; }
        [InverseProperty("Sf")]
        public virtual ICollection<CourseRegistrationLateSubmission> CourseRegistrationLateSubmissions { get; set; }
    }
}
