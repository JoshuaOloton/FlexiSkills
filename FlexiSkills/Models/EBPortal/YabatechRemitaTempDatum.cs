﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("yabatech_remita_temp_data")]
    [Index("YabaOrderId", Name = "tranid", IsUnique = true)]
    public partial class YabatechRemitaTempDatum
    {
        [Key]
        [Column("rrr")]
        [StringLength(30)]
        [Unicode(false)]
        public string Rrr { get; set; } = null!;
        [Column("order_id")]
        [StringLength(50)]
        [Unicode(false)]
        public string? OrderId { get; set; }
        [Column("yaba_order_id")]
        [StringLength(30)]
        [Unicode(false)]
        public string? YabaOrderId { get; set; }
        [Column("session")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Session { get; set; }
        [Column("amount")]
        [StringLength(30)]
        [Unicode(false)]
        public string? Amount { get; set; }
        [Column("yabatech_cut")]
        [StringLength(30)]
        [Unicode(false)]
        public string? YabatechCut { get; set; }
        [Column("gtco_cut")]
        [StringLength(30)]
        [Unicode(false)]
        public string? GtcoCut { get; set; }
        [Column("payment_id")]
        public int? PaymentId { get; set; }
        [Column("payment_type")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PaymentType { get; set; }
        [Column("status")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("transaction_date")]
        [StringLength(50)]
        [Unicode(false)]
        public string? TransactionDate { get; set; }
        [Column("payer_id")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PayerId { get; set; }
        [Column("payer_name")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PayerName { get; set; }
        [Column("payer_email")]
        [StringLength(100)]
        [Unicode(false)]
        public string? PayerEmail { get; set; }
        [Column("payer_phone")]
        [StringLength(15)]
        [Unicode(false)]
        public string? PayerPhone { get; set; }
        [Column("referrer")]
        [StringLength(900)]
        [Unicode(false)]
        public string? Referrer { get; set; }
        [Column("ip")]
        [StringLength(300)]
        [Unicode(false)]
        public string? Ip { get; set; }
        [Column("programme_type")]
        [StringLength(255)]
        [Unicode(false)]
        public string? ProgrammeType { get; set; }
        [Column("level")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Level { get; set; }
        [Column("description")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Description { get; set; }
    }
}
