using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class State
    {
        public State()
        {
            Biodata = new HashSet<Biodatum>();
            Biodata2s = new HashSet<Biodata2>();
            BiodataApplicants = new HashSet<BiodataApplicant>();
            Lgas = new HashSet<Lga>();
        }

        [Key]
        [Column("StateID")]
        public int StateId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string StateName { get; set; } = null!;

        [InverseProperty("Pob")]
        public virtual ICollection<Biodatum> Biodata { get; set; }
        [InverseProperty("Pob")]
        public virtual ICollection<Biodata2> Biodata2s { get; set; }
        [InverseProperty("Pob")]
        public virtual ICollection<BiodataApplicant> BiodataApplicants { get; set; }
        [InverseProperty("State")]
        public virtual ICollection<Lga> Lgas { get; set; }
    }
}
