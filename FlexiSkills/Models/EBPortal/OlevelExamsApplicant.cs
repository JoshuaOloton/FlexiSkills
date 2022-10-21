using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("OLevelExamsApplicant")]
    public partial class OlevelExamsApplicant
    {
        [StringLength(50)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        public int? NoOfSittings { get; set; }
        [Column("OLENID1")]
        public int? Olenid1 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ExamYear1 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? ExamNumber1 { get; set; }
        [Column("OLENID2")]
        public int? Olenid2 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Examyear2 { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Examnumber2 { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? PrimarySchool { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PryFrom { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PryTo { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? SecondarySchool { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SecFrom { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SecTo { get; set; }
        [Column("OLEMID1")]
        public int? Olemid1 { get; set; }
        [Column("OLEMID2")]
        public int? Olemid2 { get; set; }

        [ForeignKey("Olenid1")]
        public virtual OlevelExamName? Olenid1Navigation { get; set; }
        [ForeignKey("Olenid2")]
        public virtual OlevelExamName? Olenid2Navigation { get; set; }
    }
}
