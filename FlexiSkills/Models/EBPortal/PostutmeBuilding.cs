using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PostutmeBuilding
    {
        public PostutmeBuilding()
        {
            PostutmeVenues = new HashSet<PostutmeVenue>();
            PostutmeVenuesCopies = new HashSet<PostutmeVenuesCopy>();
        }

        [Key]
        [Column("BuildingID")]
        public int BuildingId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string BuildingName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string BuildingAcronym { get; set; } = null!;

        [InverseProperty("Building")]
        public virtual ICollection<PostutmeVenue> PostutmeVenues { get; set; }
        [InverseProperty("Building")]
        public virtual ICollection<PostutmeVenuesCopy> PostutmeVenuesCopies { get; set; }
    }
}
