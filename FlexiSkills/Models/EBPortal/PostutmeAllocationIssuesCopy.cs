using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeAllocationIssues_copy")]
    public partial class PostutmeAllocationIssuesCopy
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string Utmenumber { get; set; } = null!;
        [Column("datecreated", TypeName = "datetime")]
        public DateTime Datecreated { get; set; }
    }
}
