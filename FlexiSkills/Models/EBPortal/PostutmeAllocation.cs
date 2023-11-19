using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PostutmeAllocation
    {
        [StringLength(50)]
        [Unicode(false)]
        public string? UtmeNumber { get; set; }
        [Column("VenueID")]
        public int VenueId { get; set; }
        [Column("BatchID")]
        [StringLength(50)]
        [Unicode(false)]
        public string BatchId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? AllocationDate { get; set; }
        public int SchoolAllocationCount { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("SessionID")]
        public int? SessionId { get; set; }

        [ForeignKey("BatchId")]
        [InverseProperty("PostutmeAllocations")]
        public virtual PostutmeBatch Batch { get; set; } = null!;
        [ForeignKey("VenueId")]
        [InverseProperty("PostutmeAllocations")]
        public virtual PostutmeVenue Venue { get; set; } = null!;
    }
}
