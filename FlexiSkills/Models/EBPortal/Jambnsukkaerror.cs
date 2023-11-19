using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("jambnsukkaerror")]
    public partial class Jambnsukkaerror
    {
        [Column("S/N")]
        [StringLength(255)]
        public string? SN { get; set; }
        [Key]
        [Column("REGNO")]
        [StringLength(255)]
        public string Regno { get; set; } = null!;
        [Column("COURSE CODE")]
        [StringLength(255)]
        public string? CourseCode { get; set; }
        [Column("CRITERIA")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [Column("COURSE ALREADY ADMITTED TO")]
        [StringLength(255)]
        public string? CourseAlreadyAdmittedTo { get; set; }
        [Column("COURSE ADMITTED TO IN YABATECH (AFF TO UNN)")]
        [StringLength(255)]
        public string? CourseAdmittedToInYabatechAffToUnn { get; set; }
    }
}
