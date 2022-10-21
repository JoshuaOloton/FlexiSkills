using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("DirectInsert_ChangeofCourse")]
    public partial class DirectInsertChangeofCourse
    {
        [Column("sn")]
        [StringLength(255)]
        public string? Sn { get; set; }
        [Column("UTMENUMBER")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("NAME")]
        [StringLength(255)]
        public string? Name { get; set; }
        [Column("PROGRAM")]
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("JAMB_COMBINATION")]
        [StringLength(255)]
        public string? JambCombination { get; set; }
        [Column("JAMB_MATCHEDCOURSES")]
        [StringLength(255)]
        public string? JambMatchedcourses { get; set; }
        [Column("WRONGSUBJECTCOMBINATION")]
        [StringLength(255)]
        public string? Wrongsubjectcombination { get; set; }
        [Column("JAMBSCORE")]
        [StringLength(255)]
        public string? Jambscore { get; set; }
        [Column("JAMBGRADE")]
        [StringLength(255)]
        public string? Jambgrade { get; set; }
        [Column("OLEVEL")]
        [StringLength(255)]
        public string? Olevel { get; set; }
        [Column("OLEVEL_MATCHEDCOURSES")]
        [StringLength(255)]
        public string? OlevelMatchedcourses { get; set; }
        [Column("CERTIFICATEMISMATCH")]
        [StringLength(255)]
        public string? Certificatemismatch { get; set; }
        [Column("STATUS")]
        [StringLength(255)]
        public string? Status { get; set; }
        [Column("TOTALSELECTEDOLEVEL")]
        [StringLength(255)]
        public string? Totalselectedolevel { get; set; }
        [StringLength(255)]
        public string? OlevelErrors { get; set; }
        [Column("OLEVELSCORE")]
        [StringLength(255)]
        public string? Olevelscore { get; set; }
        [Column("AGGREGATE")]
        [StringLength(255)]
        public string? Aggregate { get; set; }
    }
}
