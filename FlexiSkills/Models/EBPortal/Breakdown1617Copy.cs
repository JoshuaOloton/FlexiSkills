using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Breakdown1617_copy")]
    public partial class Breakdown1617Copy
    {
        [Column("SFBID")]
        [StringLength(255)]
        public string? Sfbid { get; set; }
        [StringLength(255)]
        public string? Code { get; set; }
        [Column("SchoolID")]
        [StringLength(255)]
        public string? SchoolId { get; set; }
        [Column("LevelID")]
        [StringLength(255)]
        public string? LevelId { get; set; }
        [Column("PTID")]
        [StringLength(255)]
        public string? Ptid { get; set; }
        [StringLength(255)]
        public string? Amount { get; set; }
        [StringLength(255)]
        public string? SchoolName { get; set; }
        [Column("PTName")]
        [StringLength(255)]
        public string? Ptname { get; set; }
        [Column("PTAcronym")]
        [StringLength(255)]
        public string? Ptacronym { get; set; }
        [StringLength(255)]
        public string? LevelName { get; set; }
        [StringLength(255)]
        public string? Description { get; set; }
        [Column("SessionID")]
        [StringLength(255)]
        public string? SessionId { get; set; }
    }
}
