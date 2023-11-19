using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("OLevelExamYear")]
    public partial class OlevelExamYear
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("examyear")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Examyear { get; set; }
    }
}
