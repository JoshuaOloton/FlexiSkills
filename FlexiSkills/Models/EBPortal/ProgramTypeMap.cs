using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("ProgramType_map")]
    public partial class ProgramTypeMap
    {
        [Column("Progtype_id")]
        public int? ProgtypeId { get; set; }
        [Column("PCAcronyms")]
        [StringLength(50)]
        public string? Pcacronyms { get; set; }
        [Column("PTAcronym")]
        [StringLength(50)]
        public string? Ptacronym { get; set; }
        [Column("id")]
        public int? Id { get; set; }
    }
}
