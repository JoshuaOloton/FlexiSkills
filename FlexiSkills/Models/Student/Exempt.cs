using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.Student
{
    [Keyless]
    [Table("exempt")]
    public partial class Exempt
    {
        public int ExemptionCode { get; set; }
        [Unicode(false)]
        public string Exemption { get; set; } = null!;
    }
}
