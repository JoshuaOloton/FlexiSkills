using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("DirectInsert_main")]
    public partial class DirectInsertMain
    {
        [Key]
        [Column("sn")]
        public int Sn { get; set; }
        [Column("UTMENUMBER")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Utmenumber { get; set; }
        [Column("NAME")]
        [Unicode(false)]
        public string? Name { get; set; }
        [Column("PROGRAM")]
        [Unicode(false)]
        public string? Program { get; set; }
        [Column("JAMB_COMBINATION")]
        [Unicode(false)]
        public string? JambCombination { get; set; }
        [Column("JAMB_MATCHEDCOURSES")]
        [Unicode(false)]
        public string? JambMatchedcourses { get; set; }
        [Column("WRONGSUBJECTCOMBINATION")]
        [Unicode(false)]
        public string? Wrongsubjectcombination { get; set; }
        [Column("JAMBSCORE")]
        public int? Jambscore { get; set; }
        [Column("JAMBGRADE")]
        public int? Jambgrade { get; set; }
        [Column("OLEVEL")]
        [Unicode(false)]
        public string? Olevel { get; set; }
        [Column("OLEVEL_MATCHEDCOURSES")]
        [Unicode(false)]
        public string? OlevelMatchedcourses { get; set; }
        [Column("OLEVELSCORE")]
        public int? Olevelscore { get; set; }
        [Column("AGGREGATE")]
        public int? Aggregate { get; set; }
        [Column("CERTIFICATEMISMATCH")]
        [Unicode(false)]
        public string? Certificatemismatch { get; set; }
        [Column("STATUS")]
        [Unicode(false)]
        public string? Status { get; set; }
        [Column("TOTALSELECTEDOLEVEL")]
        public int? Totalselectedolevel { get; set; }
    }
}
