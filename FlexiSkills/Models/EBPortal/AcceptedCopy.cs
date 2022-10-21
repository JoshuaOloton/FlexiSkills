using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("accepted_copy")]
    public partial class AcceptedCopy
    {
        [Column("S/No")]
        public int? SNo { get; set; }
        [Column("Reg-No")]
        [StringLength(255)]
        public string? RegNo { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? D { get; set; }
        [Column("Sta-LGA")]
        [StringLength(255)]
        public string? StaLga { get; set; }
        [StringLength(255)]
        public string? F { get; set; }
        [Column("Age&Sex")]
        [StringLength(255)]
        public string? AgeSex { get; set; }
        [StringLength(255)]
        public string? Eng { get; set; }
        [Column("Subj 1")]
        [StringLength(255)]
        public string? Subj1 { get; set; }
        [Column("Subj 2")]
        [StringLength(255)]
        public string? Subj2 { get; set; }
        [Column("Subj 3")]
        [StringLength(255)]
        public string? Subj3 { get; set; }
        [Column("AGGATE")]
        [StringLength(255)]
        public string? Aggate { get; set; }
        [Column("Inst/Course/Remarks")]
        [StringLength(255)]
        public string? InstCourseRemarks { get; set; }
        [StringLength(255)]
        public string? N { get; set; }
        [StringLength(255)]
        public string? O { get; set; }
        [StringLength(255)]
        public string? P { get; set; }
    }
}
