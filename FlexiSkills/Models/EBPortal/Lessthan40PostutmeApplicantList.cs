using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("lessthan40_PostutmeApplicantList")]
    public partial class Lessthan40PostutmeApplicantList
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
    }
}
