using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("YCTPAY_SuccessfulTransactions")]
    public partial class YctpaySuccessfulTransaction
    {
        [Key]
        [Column("TranID")]
        [StringLength(50)]
        [Unicode(false)]
        public string TranId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime Datecreated { get; set; }

        [ForeignKey("TranId")]
        [InverseProperty("YctpaySuccessfulTransaction")]
        public virtual YctpayTransaction Tran { get; set; } = null!;
    }
}
