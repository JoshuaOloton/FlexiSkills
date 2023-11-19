using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Jamb1_1617")]
    public partial class Jamb11617
    {
        [StringLength(255)]
        public string Id { get; set; } = null!;
        [StringLength(255)]
        public string? DeptSn { get; set; }
        [StringLength(255)]
        public string RegNumb { get; set; } = null!;
        [StringLength(255)]
        public string? CandName { get; set; }
        [StringLength(255)]
        public string? StateOfOrigin { get; set; }
        [Column("LGA")]
        [StringLength(255)]
        public string? Lga { get; set; }
        [StringLength(255)]
        public string? Sex { get; set; }
        [StringLength(255)]
        public string? Age { get; set; }
        [StringLength(255)]
        public string? Engscore { get; set; }
        [StringLength(255)]
        public string? Subj2 { get; set; }
        [StringLength(255)]
        public string? Subj2Score { get; set; }
        [StringLength(255)]
        public string? Subj3 { get; set; }
        [StringLength(255)]
        public string? Subj3Score { get; set; }
        [StringLength(255)]
        public string? Subj4 { get; set; }
        [StringLength(255)]
        public string? Subj4Score { get; set; }
        [StringLength(255)]
        public string? TotalScore { get; set; }
        [StringLength(255)]
        public string? FirstChoice { get; set; }
        [StringLength(255)]
        public string? FacAbrev { get; set; }
        [StringLength(255)]
        public string? CorsAbrev { get; set; }
        [StringLength(255)]
        public string? CorsId { get; set; }
        [Column("Ad_GSM")]
        [StringLength(255)]
        public string? AdGsm { get; set; }
    }
}
