using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("TESTD")]
    public partial class Testd
    {
        [StringLength(255)]
        public string RegNumb { get; set; } = null!;
    }
}
