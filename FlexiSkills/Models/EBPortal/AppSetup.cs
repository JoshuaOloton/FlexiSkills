using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("AppSetup")]
    public partial class AppSetup
    {
        [StringLength(50)]
        public string? AppName { get; set; }
        public int AppId { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateUpdated { get; set; }
        public int? Whoid { get; set; }
        [Column("PTAcronym")]
        [StringLength(50)]
        public string? Ptacronym { get; set; }
        public int? Paymentid { get; set; }
        [Column("PCAcronym")]
        [StringLength(50)]
        public string? Pcacronym { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Amount { get; set; }
        [Column("appUrl", TypeName = "ntext")]
        public string? AppUrl { get; set; }
        [Column("sessionID")]
        public int? SessionId { get; set; }
        [Column("acadsession")]
        [StringLength(15)]
        public string? Acadsession { get; set; }
        [Column("paymentFor")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PaymentFor { get; set; }
        [Column("icon")]
        [StringLength(30)]
        [Unicode(false)]
        public string? Icon { get; set; }
        [Column("programAcronym")]
        [StringLength(8)]
        [Unicode(false)]
        public string? ProgramAcronym { get; set; }
        [Column("visibleStatus")]
        public int? VisibleStatus { get; set; }
    }
}
