using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("JambAdmission20162017")]
    public partial class JambAdmission20162017
    {
        [Column("utmenumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [StringLength(255)]
        public string? Id { get; set; }
        [StringLength(255)]
        public string? DeptSn { get; set; }
        [StringLength(255)]
        public string? RegNumb { get; set; }
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
        public string? SecondChoice { get; set; }
        [StringLength(255)]
        public string? FacAbrev { get; set; }
        [StringLength(255)]
        public string? CorsAbrev { get; set; }
        [StringLength(255)]
        public string? CorsId { get; set; }
        [Column("Tel_No")]
        [StringLength(255)]
        public string? TelNo { get; set; }
        [Column("CRITERIA")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [Column("ADMISSIONSTATUS")]
        [StringLength(255)]
        public string? Admissionstatus { get; set; }
        [Column("CHOICEPRIORITY")]
        [StringLength(255)]
        public string? Choicepriority { get; set; }
        [Column("statename")]
        [StringLength(255)]
        public string? Statename { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("JAMBPoints")]
        [StringLength(255)]
        public string? Jambpoints { get; set; }
        [Column("OLEVELPoints")]
        [StringLength(255)]
        public string? Olevelpoints { get; set; }
        [Column("AGGREGATE")]
        [StringLength(255)]
        public string? Aggregate { get; set; }
        [StringLength(255)]
        public string? NewProgram { get; set; }
        [Column("PNAME")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Pname { get; set; }
        [Column("JAMBPROGCODE")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Jambprogcode { get; set; }
        [Column("JAMBPROG")]
        [StringLength(255)]
        [Unicode(false)]
        public string? Jambprog { get; set; }
    }
}
