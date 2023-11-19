using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeVenues_copy")]
    public partial class PostutmeVenuesCopy
    {
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
        [InverseProperty("PostutmeVenuesCopies")]
        public virtual PostutmeBuilding Building { get; set; } = null!;
    }
}
