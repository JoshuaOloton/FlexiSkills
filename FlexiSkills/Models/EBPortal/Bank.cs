using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class Bank
    {
        public Bank()
        {
            AcceptanceFees = new HashSet<AcceptanceFee>();
            AdmissionLetterPayments = new HashSet<AdmissionLetterPayment>();
            AdmissionLetterPaymentsCopies = new HashSet<AdmissionLetterPaymentsCopy>();
            AdmissionRejectionPayments = new HashSet<AdmissionRejectionPayment>();
            AdmissionRejectionPaymentsCopies = new HashSet<AdmissionRejectionPaymentsCopy>();
            ChangeOfCoursePayment2s = new HashSet<ChangeOfCoursePayment2>();
            ChangeOfCoursePaymentCopies = new HashSet<ChangeOfCoursePaymentCopy>();
            ChangeOfCoursePayments = new HashSet<ChangeOfCoursePayment>();
            ClearanceRegularizationPayments = new HashSet<ClearanceRegularizationPayment>();
            OnlineappPayments = new HashSet<OnlineappPayment>();
            PostutmePayments = new HashSet<PostutmePayment>();
            PostutmePayments3s = new HashSet<PostutmePayments3>();
            SchoolFees = new HashSet<SchoolFee>();
            TranscriptPayments = new HashSet<TranscriptPayment>();
        }

        [Key]
        [Column("BankID")]
        public int BankId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string BankName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? AccountNum { get; set; }
        public short? InterSwitchCode { get; set; }

        [InverseProperty("Bank")]
        public virtual ICollection<AcceptanceFee> AcceptanceFees { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<AdmissionLetterPayment> AdmissionLetterPayments { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<AdmissionLetterPaymentsCopy> AdmissionLetterPaymentsCopies { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<AdmissionRejectionPayment> AdmissionRejectionPayments { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<AdmissionRejectionPaymentsCopy> AdmissionRejectionPaymentsCopies { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<ChangeOfCoursePayment2> ChangeOfCoursePayment2s { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<ChangeOfCoursePaymentCopy> ChangeOfCoursePaymentCopies { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<ChangeOfCoursePayment> ChangeOfCoursePayments { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<ClearanceRegularizationPayment> ClearanceRegularizationPayments { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<OnlineappPayment> OnlineappPayments { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<PostutmePayment> PostutmePayments { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<PostutmePayments3> PostutmePayments3s { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<SchoolFee> SchoolFees { get; set; }
        [InverseProperty("Bank")]
        public virtual ICollection<TranscriptPayment> TranscriptPayments { get; set; }
    }
}
