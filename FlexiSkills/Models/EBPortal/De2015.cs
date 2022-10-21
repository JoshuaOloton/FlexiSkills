using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("DE2015")]
    public partial class De2015
    {
        [StringLength(255)]
        public string? Regnumber { get; set; }
        [StringLength(255)]
        public string? Sname { get; set; }
        [StringLength(255)]
        public string? Fname { get; set; }
        [StringLength(255)]
        public string? Oname { get; set; }
    }
}
