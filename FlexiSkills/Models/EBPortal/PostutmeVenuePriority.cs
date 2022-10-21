using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeVenuePriority")]
    [Index("SchoolId", "VenueId", Name = "IX_PostutmeVenuePriority", IsUnique = true)]
    public partial class PostutmeVenuePriority
    {
        [Key]
        [Column("PVPID")]
        public int Pvpid { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("VenueID")]
        public int VenueId { get; set; }
        public int Priority { get; set; }
    }
}
