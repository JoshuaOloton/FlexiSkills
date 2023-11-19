using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("clearance_requirements")]
    public partial class ClearanceRequirement
    {
        [StringLength(255)]
        [Unicode(false)]
        public string ReqName { get; set; } = null!;
        [Column("SchoolID")]
        [StringLength(255)]
        [Unicode(false)]
        public string SchoolId { get; set; } = null!;
        [Column("excemption")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Excemption { get; set; }
        [Column("createdBy")]
        [StringLength(255)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [Column("dateCreated")]
        [StringLength(255)]
        [Unicode(false)]
        public string? DateCreated { get; set; }
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("orderID")]
        public int? OrderId { get; set; }
    }
}
