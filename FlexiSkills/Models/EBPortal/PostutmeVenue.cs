using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PostutmeVenue
    {
        public PostutmeVenue()
        {
            PostutmeAllocations = new HashSet<PostutmeAllocation>();
            PostutmeAllocationsCopies = new HashSet<PostutmeAllocationsCopy>();
        }

        [Key]
        [Column("VenueID")]
        public int VenueId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Venue { get; set; } = null!;
        [Column("BuildingID")]
        public int BuildingId { get; set; }
        public int Capacity { get; set; }
        public bool GroundFloor { get; set; }

        [ForeignKey("BuildingId")]
        [InverseProperty("PostutmeVenues")]
        public virtual PostutmeBuilding Building { get; set; } = null!;
        [InverseProperty("Venue")]
        public virtual ICollection<PostutmeAllocation> PostutmeAllocations { get; set; }
        [InverseProperty("Venue")]
        public virtual ICollection<PostutmeAllocationsCopy> PostutmeAllocationsCopies { get; set; }
    }
}
