using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class Tempsmb
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [StringLength(150)]
        public string? Name { get; set; }
        [StringLength(150)]
        public string? Programme { get; set; }
        [StringLength(50)]
        public string? Slevel { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
    }
}
