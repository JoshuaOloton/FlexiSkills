using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("PT_Pay_Status")]
    public partial class PtPayStatus
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        public int? Translevel { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Amtpaid { get; set; }
        public int? Paystatus { get; set; }
        public int Id { get; set; }
    }
}
