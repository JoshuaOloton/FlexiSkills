using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("verifyTransactions")]
    public partial class VerifyTransaction
    {
        [StringLength(50)]
        public string? Transid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
