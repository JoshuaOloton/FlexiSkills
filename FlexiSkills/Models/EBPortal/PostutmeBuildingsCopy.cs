using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("PostutmeBuildings_copy")]
    public partial class PostutmeBuildingsCopy
    {
        [Key]
        [Column("BuildingID")]
        public int BuildingId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string BuildingName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string BuildingAcronym { get; set; } = null!;
    }
}
