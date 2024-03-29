﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.Student
{
    [Keyless]
    public partial class VwCourse
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("A_SessionID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ASessionId { get; set; }
        [Column("SemesterID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SemesterId { get; set; }
        [Column("ProgrammeTypeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgrammeTypeId { get; set; }
        [Column("ProgrammeID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? ProgrammeId { get; set; }
        [Column("LevelID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? LevelId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseCode { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? CourseTitle { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseUnit { get; set; }
        [Column("CourseID")]
        [StringLength(225)]
        [Unicode(false)]
        public string? CourseId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CourseStatus { get; set; }
        [Column("SemID")]
        [StringLength(50)]
        [Unicode(false)]
        public string? SemId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Tstatus { get; set; }
        [Column("AStatus")]
        [StringLength(20)]
        [Unicode(false)]
        public string? Astatus { get; set; }
        public int? ProgrammeIdnew { get; set; }
        public int? CosHeadId { get; set; }
        public int? Setid { get; set; }
        [Column("coStatus")]
        public int? CoStatus { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Level { get; set; }
        [StringLength(225)]
        [Unicode(false)]
        public string Programme { get; set; } = null!;
        [StringLength(225)]
        [Unicode(false)]
        public string Department { get; set; } = null!;
        [Column("DepartmentID")]
        public int DepartmentId { get; set; }
        [StringLength(50)]
        public string? ProgrammeType { get; set; }
        [StringLength(100)]
        public string? School { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [StringLength(25)]
        public string? Session { get; set; }
        [Column("semestername")]
        [StringLength(8000)]
        [Unicode(false)]
        public string? Semestername { get; set; }
    }
}
