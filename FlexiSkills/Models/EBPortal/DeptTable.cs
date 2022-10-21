using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("DeptTable")]
    public partial class DeptTable
    {
        [Column("DeptID")]
        public int? DeptId { get; set; }
        [Column("SchoolID")]
        public int? SchoolId { get; set; }
        [StringLength(150)]
        public string? Dept { get; set; }
    }
}
