using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Genmatric1")]
    public partial class Genmatric1
    {
        [Column("dept")]
        [StringLength(50)]
        public string? Dept { get; set; }
        [Column("matricno")]
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("status")]
        public int? Status { get; set; }
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("PCAcronym")]
        [StringLength(10)]
        public string? Pcacronym { get; set; }
        [Column("PTAcronym")]
        [StringLength(10)]
        public string? Ptacronym { get; set; }
        [Column("PNName")]
        [StringLength(200)]
        public string? Pnname { get; set; }
        [Column("EntrySessionID")]
        public int? EntrySessionId { get; set; }
        [Column("deptcode")]
        [StringLength(50)]
        public string? Deptcode { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
