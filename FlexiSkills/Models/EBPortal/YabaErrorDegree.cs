using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("yaba_error_degree")]
    public partial class YabaErrorDegree
    {
        [Column("REGNO")]
        [StringLength(255)]
        public string? Regno { get; set; }
        [Column("COURSECODE")]
        [StringLength(255)]
        public string? Coursecode { get; set; }
        [Column("CRITERIA")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [Column("COURSEALREADYADMITTEDTO")]
        [StringLength(255)]
        public string? Coursealreadyadmittedto { get; set; }
        [Column("COURSEADMITTEDTOINYABATECH_AFFTOUNN")]
        [StringLength(255)]
        public string? CourseadmittedtoinyabatechAfftounn { get; set; }
    }
}
