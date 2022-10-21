using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("olevelgrader_pt")]
    public partial class OlevelgraderPt
    {
        [Column("id ")]
        public int? Id { get; set; }
        [Column("grade")]
        [StringLength(5)]
        [Unicode(false)]
        public string? Grade { get; set; }
        [Column("marks")]
        public int? Marks { get; set; }
    }
}
