using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OLevelResults")]
    [Index("ApplicationNumber", "Olsid", Name = "IX_OLevelResults", IsUnique = true)]
    public partial class OlevelResult
    {
        [Key]
        [Column("OLRID")]
        public int Olrid { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [Column("OLSID")]
        public int Olsid { get; set; }
        [Column("OLGID")]
        public int Olgid { get; set; }

        [ForeignKey("Olgid")]
        [InverseProperty("OlevelResults")]
        public virtual OlevelGrade Olg { get; set; } = null!;
        [ForeignKey("Olsid")]
        [InverseProperty("OlevelResults")]
        public virtual OlevelSubject Ols { get; set; } = null!;
    }
}
