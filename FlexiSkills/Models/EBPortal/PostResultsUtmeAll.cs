using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("PostResultsUtmeAll")]
    public partial class PostResultsUtmeAll
    {
        [Column("UTMENumber")]
        [StringLength(255)]
        public string? Utmenumber { get; set; }
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Middlename { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
        [StringLength(255)]
        public string? ScreeningScore { get; set; }
        [Column("score")]
        [StringLength(255)]
        public string? Score { get; set; }
        [Column("PostUTMEScore50")]
        [StringLength(255)]
        public string? PostUtmescore50 { get; set; }
        [StringLength(255)]
        public string? JambScore50 { get; set; }
        [StringLength(255)]
        public string? Aggregate { get; set; }
        [StringLength(255)]
        public string? SerialNo { get; set; }
        [StringLength(255)]
        public string? StateName { get; set; }
    }
}
