using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("PostutmeAllocationInitializer_copy")]
    public partial class PostutmeAllocationInitializerCopy
    {
        [StringLength(50)]
        [Unicode(false)]
        public string UtmeNumber { get; set; } = null!;
        [Column("VenueID")]
        public int VenueId { get; set; }
        [Column("BatchID")]
        [StringLength(50)]
        [Unicode(false)]
        public string BatchId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime AllocationDate { get; set; }
        public int SchoolAllocationCount { get; set; }
    }
}
