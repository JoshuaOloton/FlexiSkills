using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("LGA")]
    public partial class Lga
    {
        public Lga()
        {
            Biodata = new HashSet<Biodatum>();
            Biodata2s = new HashSet<Biodata2>();
            BiodataApplicants = new HashSet<BiodataApplicant>();
            DirectEntryAllCopies = new HashSet<DirectEntryAllCopy>();
            DirectEntryAlls = new HashSet<DirectEntryAll>();
        }

        [Key]
        [Column("LGAID")]
        public int Lgaid { get; set; }
        [Column("LGAName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Lganame { get; set; } = null!;
        [Column("StateID")]
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        [InverseProperty("Lgas")]
        public virtual State State { get; set; } = null!;
        [InverseProperty("Lga")]
        public virtual ICollection<Biodatum> Biodata { get; set; }
        [InverseProperty("Lga")]
        public virtual ICollection<Biodata2> Biodata2s { get; set; }
        [InverseProperty("Lga")]
        public virtual ICollection<BiodataApplicant> BiodataApplicants { get; set; }
        [InverseProperty("Lga")]
        public virtual ICollection<DirectEntryAllCopy> DirectEntryAllCopies { get; set; }
        [InverseProperty("Lga")]
        public virtual ICollection<DirectEntryAll> DirectEntryAlls { get; set; }
    }
}
