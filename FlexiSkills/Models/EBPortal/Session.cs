using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class Session
    {
        public Session()
        {
            BiodataApplicants = new HashSet<BiodataApplicant>();
            DirectEntryAllCopies = new HashSet<DirectEntryAllCopy>();
            DirectEntryAlls = new HashSet<DirectEntryAll>();
            OnlineappAlls = new HashSet<OnlineappAll>();
            PenaltyPayments = new HashSet<PenaltyPayment>();
            PostutmeAllSecondCopies = new HashSet<PostutmeAllSecondCopy>();
            PostutmeAllSeconds = new HashSet<PostutmeAllSecond>();
            SchoolFees = new HashSet<SchoolFee>();
            YctTranscriptApps = new HashSet<YctTranscriptApp>();
            YctpayOthersPayments = new HashSet<YctpayOthersPayment>();
            YctpayStudentsPayments = new HashSet<YctpayStudentsPayment>();
            YctpayStudentsPaymentsCopies = new HashSet<YctpayStudentsPaymentsCopy>();
            YctpayStudentsPaymentsCopyCopies = new HashSet<YctpayStudentsPaymentsCopyCopy>();
            YctpayStudentsPaymentsMistakes = new HashSet<YctpayStudentsPaymentsMistake>();
        }

        [Key]
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("Session")]
        [StringLength(50)]
        [Unicode(false)]
        public string Session1 { get; set; } = null!;
        public bool CurrentSession { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        public bool CurrentSchoolSession { get; set; }
        public bool CurrentApplicationSession { get; set; }
        public bool CurrentAdmissionSession { get; set; }
        public bool? CurrentScreeningSession { get; set; }

        [InverseProperty("Session")]
        public virtual ICollection<BiodataApplicant> BiodataApplicants { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<DirectEntryAllCopy> DirectEntryAllCopies { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<DirectEntryAll> DirectEntryAlls { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<OnlineappAll> OnlineappAlls { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<PenaltyPayment> PenaltyPayments { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<PostutmeAllSecondCopy> PostutmeAllSecondCopies { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<PostutmeAllSecond> PostutmeAllSeconds { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<SchoolFee> SchoolFees { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<YctTranscriptApp> YctTranscriptApps { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<YctpayOthersPayment> YctpayOthersPayments { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<YctpayStudentsPayment> YctpayStudentsPayments { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<YctpayStudentsPaymentsCopy> YctpayStudentsPaymentsCopies { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<YctpayStudentsPaymentsCopyCopy> YctpayStudentsPaymentsCopyCopies { get; set; }
        [InverseProperty("Session")]
        public virtual ICollection<YctpayStudentsPaymentsMistake> YctpayStudentsPaymentsMistakes { get; set; }
    }
}
