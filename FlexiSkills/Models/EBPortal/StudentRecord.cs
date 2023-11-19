﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("student_record")]
    public partial class StudentRecord
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("appnum")]
        [StringLength(50)]
        public string Appnum { get; set; } = null!;
        [Column("matricnum")]
        [StringLength(50)]
        public string Matricnum { get; set; } = null!;
        [Column("surname")]
        [StringLength(100)]
        public string Surname { get; set; } = null!;
        [Column("firstname")]
        [StringLength(100)]
        public string Firstname { get; set; } = null!;
        [Column("othername")]
        [StringLength(100)]
        public string Othername { get; set; } = null!;
        [Column("sex")]
        [StringLength(50)]
        public string Sex { get; set; } = null!;
        [Column("dob")]
        [StringLength(50)]
        public string Dob { get; set; } = null!;
        [Column("mob")]
        [StringLength(50)]
        public string Mob { get; set; } = null!;
        [Column("yob")]
        [StringLength(50)]
        public string Yob { get; set; } = null!;
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; } = null!;
        [Column("phone")]
        [StringLength(50)]
        public string Phone { get; set; } = null!;
        [Column("address")]
        [StringLength(200)]
        public string Address { get; set; } = null!;
        [Column("place_of_birth")]
        [StringLength(200)]
        public string PlaceOfBirth { get; set; } = null!;
        [Column("state_of_origin")]
        [StringLength(100)]
        public string StateOfOrigin { get; set; } = null!;
        [Column("local_gov_area")]
        [StringLength(100)]
        public string LocalGovArea { get; set; } = null!;
        [Column("parent_guardian")]
        [StringLength(200)]
        public string ParentGuardian { get; set; } = null!;
        [Column("p_g_address")]
        [StringLength(200)]
        public string PGAddress { get; set; } = null!;
        [Column("p_g_phone")]
        [StringLength(200)]
        public string PGPhone { get; set; } = null!;
        [Column("programme_type")]
        [StringLength(200)]
        public string ProgrammeType { get; set; } = null!;
        [Column("acadsession")]
        [StringLength(20)]
        public string Acadsession { get; set; } = null!;
        [Column("programme")]
        [StringLength(200)]
        public string Programme { get; set; } = null!;
        [Column("level")]
        [StringLength(50)]
        public string Level { get; set; } = null!;
        [Column("entry_year")]
        [StringLength(50)]
        public string EntryYear { get; set; } = null!;
        [Column("defer")]
        [StringLength(20)]
        [Unicode(false)]
        public string Defer { get; set; } = null!;
        [Column("graduate")]
        [StringLength(1)]
        [Unicode(false)]
        public string Graduate { get; set; } = null!;
        [Column("repeatclass")]
        [StringLength(1)]
        [Unicode(false)]
        public string Repeatclass { get; set; } = null!;
        [Column("expel")]
        [StringLength(1)]
        [Unicode(false)]
        public string Expel { get; set; } = null!;
        [Column("stepdown")]
        [StringLength(1)]
        [Unicode(false)]
        public string Stepdown { get; set; } = null!;
        [Column("suspension")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Suspension { get; set; }
        [Column("withdrawal")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Withdrawal { get; set; }
        [Column("failout")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Failout { get; set; }
        [Column("withdrawal_certificate")]
        [StringLength(1)]
        [Unicode(false)]
        public string? WithdrawalCertificate { get; set; }
        [Column("studenshipstatus")]
        [StringLength(20)]
        public string? Studenshipstatus { get; set; }
        [Column("activecount")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Activecount { get; set; }
        [Column("inactivecount")]
        [StringLength(1)]
        [Unicode(false)]
        public string? Inactivecount { get; set; }
        [Column("password")]
        [StringLength(200)]
        public string? Password { get; set; }
        [StringLength(20)]
        public string? DateEdited { get; set; }
        [StringLength(20)]
        public string? TimeEdited { get; set; }
        [StringLength(100)]
        public string? CourseOptions { get; set; }
        [Column("Real_Level")]
        [StringLength(50)]
        public string? RealLevel { get; set; }
        [Column("ProgrammeID")]
        [StringLength(50)]
        public string? ProgrammeId { get; set; }
        [StringLength(225)]
        public string? CurrentPhoneNo { get; set; }
        [StringLength(255)]
        public string? CurrentEmail { get; set; }
        public int? YellowCase { get; set; }
    }
}
