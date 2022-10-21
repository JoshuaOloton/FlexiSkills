using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("clearanceRequirements")]
    public partial class ClearanceRequirement1
    {
        [StringLength(150)]
        [Unicode(false)]
        public string ReqName { get; set; } = null!;
        [Column("programType")]
        [StringLength(50)]
        [Unicode(false)]
        public string ProgramType { get; set; } = null!;
        [Column("levelName")]
        [StringLength(50)]
        [Unicode(false)]
        public string LevelName { get; set; } = null!;
        [Column("createdBy")]
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column("dateCreated")]
        [StringLength(50)]
        [Unicode(false)]
        public string DateCreated { get; set; } = null!;
        [Column("ID")]
        public int Id { get; set; }
    }
}
