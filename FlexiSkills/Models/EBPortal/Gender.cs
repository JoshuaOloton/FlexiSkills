using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class Gender
    {
        public Gender()
        {
            Biodata = new HashSet<Biodatum>();
            Biodata2s = new HashSet<Biodata2>();
            BiodataApplicants = new HashSet<BiodataApplicant>();
            DirectEntryAllCopies = new HashSet<DirectEntryAllCopy>();
            DirectEntryAlls = new HashSet<DirectEntryAll>();
            PostutmeAllSecondCopies = new HashSet<PostutmeAllSecondCopy>();
            PostutmeAllSeconds = new HashSet<PostutmeAllSecond>();
        }

        [Key]
        [Column("GenderID")]
        public int GenderId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string GenderName { get; set; } = null!;

        [InverseProperty("Sex")]
        public virtual ICollection<Biodatum> Biodata { get; set; }
        [InverseProperty("Sex")]
        public virtual ICollection<Biodata2> Biodata2s { get; set; }
        [InverseProperty("Sex")]
        public virtual ICollection<BiodataApplicant> BiodataApplicants { get; set; }
        [InverseProperty("Gender")]
        public virtual ICollection<DirectEntryAllCopy> DirectEntryAllCopies { get; set; }
        [InverseProperty("Gender")]
        public virtual ICollection<DirectEntryAll> DirectEntryAlls { get; set; }
        [InverseProperty("Gender")]
        public virtual ICollection<PostutmeAllSecondCopy> PostutmeAllSecondCopies { get; set; }
        [InverseProperty("Gender")]
        public virtual ICollection<PostutmeAllSecond> PostutmeAllSeconds { get; set; }
    }
}
