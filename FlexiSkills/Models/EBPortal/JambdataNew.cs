using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("JambdataNew")]
    public partial class JambdataNew
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        [StringLength(150)]
        public string? Surname { get; set; }
        [StringLength(150)]
        public string? Firstname { get; set; }
        [StringLength(150)]
        public string? Othername { get; set; }
        [StringLength(50)]
        public string? Sex { get; set; }
        [StringLength(150)]
        public string? StateName { get; set; }
        public int? JambScore { get; set; }
        [StringLength(200)]
        public string? Program { get; set; }
        [Column("lga")]
        [StringLength(100)]
        public string? Lga { get; set; }
        [StringLength(50)]
        public string? Subject1 { get; set; }
        [Column("score1")]
        public int? Score1 { get; set; }
        [StringLength(50)]
        public string? Subject2 { get; set; }
        [Column("score2")]
        public int? Score2 { get; set; }
        [StringLength(50)]
        public string? Subject3 { get; set; }
        public int? Score3 { get; set; }
        public int? EngScore { get; set; }
        public int? TotalScore { get; set; }
        public int? Sexid { get; set; }
        public int? Lgaid { get; set; }
        public int? Programid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
