using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("OlevelSittingTbl")]
    public partial class OlevelSittingTbl1
    {
        [Column("verificationID")]
        public int VerificationId { get; set; }
        [Column("sitting")]
        public int Sitting { get; set; }
        [Column("amount")]
        public int Amount { get; set; }
        [Column("status")]
        public int Status { get; set; }
        [Column("dateUpdated", TypeName = "datetime")]
        public DateTime DateUpdated { get; set; }
    }
}
