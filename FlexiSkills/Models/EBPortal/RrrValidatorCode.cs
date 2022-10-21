using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("RRR_Validator_Code")]
    public partial class RrrValidatorCode
    {
        [Key]
        [StringLength(255)]
        [Unicode(false)]
        public string PassCode { get; set; } = null!;
    }
}
