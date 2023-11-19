using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("GTCOCALSCAN_Payment_Details")]
    public partial class GtcocalscanPaymentDetail
    {
        [Column("rrr")]
        [StringLength(255)]
        public string? Rrr { get; set; }
        [Column("payername")]
        [StringLength(255)]
        public string? Payername { get; set; }
        [Column("payeremail")]
        [StringLength(255)]
        public string? Payeremail { get; set; }
        [Column("payerphone")]
        [StringLength(255)]
        public string? Payerphone { get; set; }
        [Column("remita_orderid")]
        [StringLength(255)]
        public string? RemitaOrderid { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string? Orderid { get; set; }
        [Column("paymentid")]
        [StringLength(255)]
        public string? Paymentid { get; set; }
        [Column("amt")]
        [StringLength(255)]
        public string? Amt { get; set; }
        [Column("acadsession")]
        [StringLength(255)]
        public string? Acadsession { get; set; }
        [Column("paymentdescription")]
        [StringLength(255)]
        public string? Paymentdescription { get; set; }
        [Column("paymentName")]
        [StringLength(255)]
        public string? PaymentName { get; set; }
        [Column("dategenerated")]
        [StringLength(255)]
        public string? Dategenerated { get; set; }
        [Column("trans_date")]
        [StringLength(255)]
        public string? TransDate { get; set; }
        [Column("status")]
        [StringLength(255)]
        public string? Status { get; set; }
        [Column("payerID")]
        [StringLength(255)]
        public string? PayerId { get; set; }
        [Column("server")]
        [StringLength(255)]
        public string? Server { get; set; }
    }
}
