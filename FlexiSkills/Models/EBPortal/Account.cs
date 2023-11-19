using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class Account
    {
        public Account()
        {
            SchoolFees = new HashSet<SchoolFee>();
        }

        [Key]
        [Column("MerchantID")]
        public int MerchantId { get; set; }
        [Column("Account")]
        [StringLength(50)]
        [Unicode(false)]
        public string Account1 { get; set; } = null!;

        [InverseProperty("Merchant")]
        public virtual ICollection<SchoolFee> SchoolFees { get; set; }
    }
}
