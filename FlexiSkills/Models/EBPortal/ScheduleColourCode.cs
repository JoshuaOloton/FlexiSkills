using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class ScheduleColourCode
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("BatchID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? BatchId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? DayName { get; set; }
    }
}
