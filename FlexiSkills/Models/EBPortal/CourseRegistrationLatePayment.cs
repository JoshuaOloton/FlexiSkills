using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class CourseRegistrationLatePayment
    {
        [Key]
        [Column("CRLPID")]
        public int Crlpid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Amount { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Receiptnum { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime Paymentdate { get; set; }
        [Column("SemesterID")]
        public int SemesterId { get; set; }
        [Column("SFID")]
        public int Sfid { get; set; }

        [ForeignKey("SemesterId")]
        [InverseProperty("CourseRegistrationLatePayments")]
        public virtual Semestersp Semester { get; set; } = null!;
        [ForeignKey("Sfid")]
        [InverseProperty("CourseRegistrationLatePayments")]
        public virtual SchoolFee Sf { get; set; } = null!;
    }
}
