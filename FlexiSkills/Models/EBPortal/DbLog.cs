using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("dbLog")]
    public partial class DbLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("userName")]
        [StringLength(20)]
        public string UserName { get; set; } = null!;
        [Column("logDate", TypeName = "datetime")]
        public DateTime LogDate { get; set; }
        [Column("details")]
        [StringLength(300)]
        public string Details { get; set; } = null!;
        [Column("editedMat")]
        [StringLength(30)]
        public string EditedMat { get; set; } = null!;
    }
}
