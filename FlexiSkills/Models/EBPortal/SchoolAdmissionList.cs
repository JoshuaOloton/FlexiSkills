using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("SchoolAdmissionList")]
    public partial class SchoolAdmissionList
    {
        [Key]
        [Column("MapID")]
        public int MapId { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("ALID")]
        public int Alid { get; set; }
        [Column("ALIDPT")]
        public int? Alidpt { get; set; }
        [Column("PTAcronym")]
        [StringLength(50)]
        public string? Ptacronym { get; set; }

        [ForeignKey("Alid")]
        [InverseProperty("SchoolAdmissionLists")]
        public virtual AdmissionList Al { get; set; } = null!;
        [ForeignKey("SchoolId")]
        [InverseProperty("SchoolAdmissionLists")]
        public virtual School School { get; set; } = null!;
    }
}
