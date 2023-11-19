using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("hostelapplication_copy")]
    public partial class HostelapplicationCopy
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string MatricNum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Sex { get; set; }
        [Column("dob")]
        [StringLength(15)]
        [Unicode(false)]
        public string? Dob { get; set; }
        public int? Age { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Mobile { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? AcadSession { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Course { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? StateofOrigin { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? LocalGov { get; set; }
        [Unicode(false)]
        public string? ResAddress { get; set; }
        [Column("Parent_Guardian")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ParentGuardian { get; set; }
        [Column("p_g_address")]
        [Unicode(false)]
        public string? PGAddress { get; set; }
        [Column("p_g_mobile")]
        [StringLength(200)]
        [Unicode(false)]
        public string? PGMobile { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? NextofKin { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? KinRelationship { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? KinMobile { get; set; }
        [Unicode(false)]
        public string? KinAddress { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? PreviouslyAccomodated { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? PrevHostel { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? PrevRoomNumber { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? YearofResidence { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? SocClub1 { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? SocClub2 { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? SocClub3 { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? SocClub4 { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? SocClub5 { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? QueryOption { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? MedicalProblems { get; set; }
        [Unicode(false)]
        public string? MedicalProblemDetail { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string? CollegeSport { get; set; }
        [Unicode(false)]
        public string? SportDetail { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? AllotStatus { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? HostelList { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? AllotDate { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? HostelAllotted { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? RoomNumber { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? PaymentStatus { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? CompletedDate { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Completed { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? Appnum { get; set; }
    }
}
