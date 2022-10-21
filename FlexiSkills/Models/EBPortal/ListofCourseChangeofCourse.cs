using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("listofCourseChangeofCourse")]
    public partial class ListofCourseChangeofCourse
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [StringLength(255)]
        public string? Program { get; set; }
        [Column("PNName")]
        [StringLength(255)]
        public string? Pnname { get; set; }
        [Column("ProgramID")]
        public int? ProgramId { get; set; }
        [Column("activestatus")]
        public int? Activestatus { get; set; }
    }
}
