using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ABUJA1")]
    public partial class Abuja1
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
        [Column("statename")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Statename { get; set; }
        [Column("ADMISSIONSTATUS")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Admissionstatus { get; set; }
        [Column("CHOICEPRIORITY")]
        public int? Choicepriority { get; set; }
        [Column("CRITERIA")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Criteria { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Program { get; set; }
        [Column("JAMBPoints")]
        public int? Jambpoints { get; set; }
        [Column("OLEVELPoints")]
        public int? Olevelpoints { get; set; }
        [Column("AGGREGATE")]
        public int? Aggregate { get; set; }
    }
}
