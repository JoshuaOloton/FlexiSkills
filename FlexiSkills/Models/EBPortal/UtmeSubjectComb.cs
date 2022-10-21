using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("UtmeSubjectComb")]
    public partial class UtmeSubjectComb
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("PROGRAM")]
        [StringLength(150)]
        [Unicode(false)]
        public string? Program { get; set; }
        [Column("OLEVEL_COMPULSORY", TypeName = "text")]
        public string? OlevelCompulsory { get; set; }
        [Column("OLEVEL_ELECTIVES", TypeName = "text")]
        public string? OlevelElectives { get; set; }
        [Column("UTME_COMPULSORY_SUBJECTS", TypeName = "text")]
        public string? UtmeCompulsorySubjects { get; set; }
        [Column("UTME_ELECTIVE_SUBJECTS", TypeName = "text")]
        public string? UtmeElectiveSubjects { get; set; }
        [Column("NO_COMP_SUBJECTS")]
        public int? NoCompSubjects { get; set; }
        [Column("NO_ELECT_SUBJECTS")]
        public int? NoElectSubjects { get; set; }
        [Column("olevel_com_num")]
        public int? OlevelComNum { get; set; }
        [Column("olevel_elective_num")]
        public int? OlevelElectiveNum { get; set; }
    }
}
