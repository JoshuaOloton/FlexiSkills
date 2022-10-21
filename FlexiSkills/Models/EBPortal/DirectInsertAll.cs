using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("DirectInsertAll")]
    public partial class DirectInsertAll
    {
        [Column("UTMENUMBERS")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Utmenumbers { get; set; }
        [Column("NAME")]
        [StringLength(4000)]
        public string? Name { get; set; }
        [Column("PROGRAM")]
        [StringLength(4000)]
        public string? Program { get; set; }
        [Column("JAMB_COMBINATION")]
        [StringLength(4000)]
        public string? JambCombination { get; set; }
        [Column("JAMB_MATCHEDCOURSES")]
        [StringLength(4000)]
        public string? JambMatchedcourses { get; set; }
        [Column("WRONGSUBJECTCOMBINATION")]
        [StringLength(4000)]
        public string? Wrongsubjectcombination { get; set; }
        [Column("JAMBSCORE")]
        public int? Jambscore { get; set; }
        [Column("JAMBGRADE")]
        public int? Jambgrade { get; set; }
        [Column("OLEVEL")]
        [StringLength(4000)]
        public string? Olevel { get; set; }
        [Column("OLEVEL_MATCHEDCOURSES")]
        [StringLength(4000)]
        public string? OlevelMatchedcourses { get; set; }
        [Column("OLEVELSCORE")]
        public int? Olevelscore { get; set; }
        [Column("AGGREGATE")]
        public int? Aggregate { get; set; }
        [Column("CERTIFICATEMISMATCH")]
        [StringLength(4000)]
        public string? Certificatemismatch { get; set; }
        [Column("STATUS")]
        [StringLength(4000)]
        public string? Status { get; set; }
        [Column("TOTALSELECTEDOLEVEL")]
        public int? Totalselectedolevel { get; set; }
    }
}
