using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("student_record$")]
    public partial class StudentRecord1
    {
        public double? F1 { get; set; }
        [StringLength(255)]
        public string? F2 { get; set; }
        [StringLength(255)]
        public string? F3 { get; set; }
        [StringLength(255)]
        public string? F4 { get; set; }
        [StringLength(255)]
        public string? F5 { get; set; }
        [StringLength(255)]
        public string? F6 { get; set; }
        [StringLength(255)]
        public string? F7 { get; set; }
        public double? F8 { get; set; }
        [StringLength(255)]
        public string? F9 { get; set; }
        public double? F10 { get; set; }
        [StringLength(255)]
        public string? F11 { get; set; }
        public double? F12 { get; set; }
        [StringLength(255)]
        public string? F13 { get; set; }
        [StringLength(255)]
        public string? F14 { get; set; }
        [StringLength(255)]
        public string? F15 { get; set; }
        [StringLength(255)]
        public string? F16 { get; set; }
        [StringLength(255)]
        public string? F17 { get; set; }
        [StringLength(255)]
        public string? F18 { get; set; }
        public double? F19 { get; set; }
        [StringLength(255)]
        public string? F20 { get; set; }
        [StringLength(255)]
        public string? F21 { get; set; }
        [StringLength(255)]
        public string? F22 { get; set; }
        public double? F23 { get; set; }
        [StringLength(255)]
        public string? F24 { get; set; }
        public double? F25 { get; set; }
        public double? F26 { get; set; }
        public double? F27 { get; set; }
        public double? F28 { get; set; }
        public double? F29 { get; set; }
        public double? F30 { get; set; }
        public double? F31 { get; set; }
        public double? F32 { get; set; }
        public double? F33 { get; set; }
        [StringLength(255)]
        public string? F34 { get; set; }
        public double? F35 { get; set; }
        public double? F36 { get; set; }
        [StringLength(255)]
        public string? F37 { get; set; }
        [StringLength(255)]
        public string? F38 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? F39 { get; set; }
        [StringLength(255)]
        public string? F40 { get; set; }
        [StringLength(255)]
        public string? F41 { get; set; }
        [StringLength(255)]
        public string? F42 { get; set; }
        [StringLength(255)]
        public string? F43 { get; set; }
        [StringLength(255)]
        public string? F44 { get; set; }
        public double? F45 { get; set; }
    }
}
