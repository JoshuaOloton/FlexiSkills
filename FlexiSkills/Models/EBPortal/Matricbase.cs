using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("matricbase")]
    public partial class Matricbase
    {
        public int? ProgId { get; set; }
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
