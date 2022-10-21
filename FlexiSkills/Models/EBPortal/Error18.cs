using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Error18")]
    public partial class Error18
    {
        [Key]
        [StringLength(255)]
        public string Appnum { get; set; } = null!;
        [Column("ALID")]
        [StringLength(255)]
        public string? Alid { get; set; }
        [StringLength(255)]
        public string? Createdby { get; set; }
        [StringLength(255)]
        public string? DateCreated { get; set; }
        [Column("ALName")]
        [StringLength(255)]
        public string? Alname { get; set; }
        [StringLength(255)]
        public string? Surname { get; set; }
        [StringLength(255)]
        public string? Firstname { get; set; }
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("SexID")]
        [StringLength(255)]
        public string? SexId { get; set; }
        [Column("DOB")]
        [StringLength(255)]
        public string? Dob { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
        [StringLength(255)]
        public string? Session { get; set; }
    }
}
