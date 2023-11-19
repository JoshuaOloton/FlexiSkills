using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("mysql_programs")]
    public partial class MysqlProgram
    {
        [Key]
        [Column("programme")]
        [StringLength(255)]
        public string Programme { get; set; } = null!;
    }
}
