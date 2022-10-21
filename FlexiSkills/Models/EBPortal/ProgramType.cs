using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class ProgramType
    {
        public ProgramType()
        {
            Programs = new HashSet<Program>();
            SchoolFeesBreakdownCopies = new HashSet<SchoolFeesBreakdownCopy>();
            SchoolFeesBreakdowns = new HashSet<SchoolFeesBreakdown>();
        }

        [Key]
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column("PTName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptname { get; set; } = null!;
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;

        [InverseProperty("Pt")]
        public virtual ICollection<Program> Programs { get; set; }
        [InverseProperty("Pt")]
        public virtual ICollection<SchoolFeesBreakdownCopy> SchoolFeesBreakdownCopies { get; set; }
        [InverseProperty("Pt")]
        public virtual ICollection<SchoolFeesBreakdown> SchoolFeesBreakdowns { get; set; }
    }
}
