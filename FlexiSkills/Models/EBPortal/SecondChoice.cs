using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("SecondChoice")]
    public partial class SecondChoice
    {
        public int Id { get; set; }
        public int? DeptSn { get; set; }
        [StringLength(10)]
        public string? RegNumb { get; set; }
        [StringLength(30)]
        public string? CandName { get; set; }
        [StringLength(3)]
        public string? StateOfOrigin { get; set; }
        [Column("LGA")]
        [StringLength(6)]
        public string? Lga { get; set; }
        [StringLength(1)]
        public string? Sex { get; set; }
        public short? Age { get; set; }
        public short? Engscore { get; set; }
        [StringLength(3)]
        public string? Subj2 { get; set; }
        public short? Subj2Score { get; set; }
        [StringLength(3)]
        public string? Subj3 { get; set; }
        public short? Subj3Score { get; set; }
        [StringLength(3)]
        public string? Subj4 { get; set; }
        public short? Subj4Score { get; set; }
        public short? TotalScore { get; set; }
        [StringLength(25)]
        public string? FirstChoice { get; set; }
        [StringLength(10)]
        public string? FacAbrev { get; set; }
        [StringLength(20)]
        public string? CorsAbrev { get; set; }
        [StringLength(10)]
        public string? CorsId { get; set; }
        [Column("Tel_no")]
        [StringLength(15)]
        public string? TelNo { get; set; }
    }
}
