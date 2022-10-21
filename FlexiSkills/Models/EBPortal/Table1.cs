using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Table_1")]
    public partial class Table1
    {
        [Column("ta")]
        [StringLength(10)]
        public string? Ta { get; set; }
    }
}
