using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("YCTPAY_PaymentBiodata")]
    public partial class YctpayPaymentBiodatum
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string PayeeNum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Phone { get; set; } = null!;
        [Column("ProgramID")]
        public int ProgramId { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("YctpayPaymentBiodata")]
        public virtual Program Program { get; set; } = null!;
    }
}
