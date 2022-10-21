using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("appstatus")]
    public partial class Appstatus
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("apptype")]
        [StringLength(50)]
        [Unicode(false)]
        public string Apptype { get; set; } = null!;
        [Column("level")]
        [StringLength(20)]
        [Unicode(false)]
        public string Level { get; set; } = null!;
        [Column("academicsession")]
        [StringLength(11)]
        [Unicode(false)]
        public string? Academicsession { get; set; }
        [Column("current_semester")]
        [StringLength(50)]
        [Unicode(false)]
        public string? CurrentSemester { get; set; }
        [Column("deadline_date")]
        public DateTime DeadlineDate { get; set; }
        [Column("total_units")]
        public int TotalUnits { get; set; }
        [Column("progtype")]
        [StringLength(5)]
        [Unicode(false)]
        public string Progtype { get; set; } = null!;
    }
}
