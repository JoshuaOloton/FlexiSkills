using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("AdmissionAllRep")]
    public partial class AdmissionAllRep
    {
        [StringLength(250)]
        public string? Program { get; set; }
        [StringLength(250)]
        public string? School { get; set; }
        public int? Schoolfee { get; set; }
        public int? Acceptance { get; set; }
        public int? Admission { get; set; }
        [Column("reg")]
        public int? Reg { get; set; }
        [Column("payfresh")]
        public int? Payfresh { get; set; }
        [Column("regfresh")]
        public int? Regfresh { get; set; }
    }
}
