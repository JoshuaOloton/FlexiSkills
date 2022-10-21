using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("Hostelpayment1")]
    public partial class Hostelpayment1
    {
        [StringLength(150)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("dept")]
        [StringLength(240)]
        public string? Dept { get; set; }
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(50)]
        public string? Phone { get; set; }
        [Column("sex")]
        [StringLength(50)]
        public string? Sex { get; set; }
        [StringLength(50)]
        public string? Slevel { get; set; }
    }
}
