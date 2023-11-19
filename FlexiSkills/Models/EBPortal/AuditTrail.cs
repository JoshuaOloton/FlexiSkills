using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("AuditTrail")]
    public partial class AuditTrail
    {
        [Key]
        [Column("AuditID")]
        public int AuditId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Action { get; set; } = null!;
        [Unicode(false)]
        public string Detail { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string TableName { get; set; } = null!;
        [Column("CreatedbyID")]
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedbyId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
    }
}
