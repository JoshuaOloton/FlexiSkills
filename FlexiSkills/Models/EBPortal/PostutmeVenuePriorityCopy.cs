using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeVenuePriority_copy")]
    [Index("SchoolId", "VenueId", Name = "UQ__Postutme__0E611927D2A892B8", IsUnique = true)]
    public partial class PostutmeVenuePriorityCopy
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
