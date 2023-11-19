using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("YCTPAY_TransactionswithMixedupData")]
    public partial class YctpayTransactionswithMixedupDatum
    {
        [Key]
        [Column("TranID")]
        [StringLength(50)]
        [Unicode(false)]
        public string TranId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }

        [ForeignKey("TranId")]
        [InverseProperty("YctpayTransactionswithMixedupDatum")]
        public virtual YctpayTransaction Tran { get; set; } = null!;
    }
}
