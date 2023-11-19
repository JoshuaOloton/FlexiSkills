using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class ProgramCertificate
    {
        public ProgramCertificate()
        {
            Programs = new HashSet<Program>();
        }

        [Key]
        [Column("PCID")]
        public int Pcid { get; set; }
        [Column("PCName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcname { get; set; } = null!;
        [Column("PCAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;

        [InverseProperty("Pc")]
        public virtual ICollection<Program> Programs { get; set; }
    }
}
