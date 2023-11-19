using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Index("Pcid", "Pnid", "Ptid", Name = "IX_Programs", IsUnique = true)]
    public partial class Program
    {
        public Program()
        {
            Admittables = new HashSet<Admittable>();
            BiodataApplicants = new HashSet<BiodataApplicant>();
            ChangeofCourseHistories = new HashSet<ChangeofCourseHistory>();
            ChangeofCourses = new HashSet<ChangeofCourse>();
            DirectEntryAllCopies = new HashSet<DirectEntryAllCopy>();
            DirectEntryAlls = new HashSet<DirectEntryAll>();
            OnlineappAlls = new HashSet<OnlineappAll>();
            PostutmeAllSecondCopies = new HashSet<PostutmeAllSecondCopy>();
            PostutmeAllSeconds = new HashSet<PostutmeAllSecond>();
            ProgramLevelSemesters = new HashSet<ProgramLevelSemester>();
            ProgramLevels = new HashSet<ProgramLevel>();
            YctTranscriptApps = new HashSet<YctTranscriptApp>();
            YctpayPaymentBiodata = new HashSet<YctpayPaymentBiodatum>();
        }

        [Key]
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("PCID")]
        public int Pcid { get; set; }
        [Column("PNID")]
        public int Pnid { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        public int ActiveStatus { get; set; }
        public int? AppId { get; set; }

        [ForeignKey("Pcid")]
        [InverseProperty("Programs")]
        public virtual ProgramCertificate Pc { get; set; } = null!;
        [ForeignKey("Pnid")]
        [InverseProperty("Programs")]
        public virtual ProgramName Pn { get; set; } = null!;
        [ForeignKey("Ptid")]
        [InverseProperty("Programs")]
        public virtual ProgramType Pt { get; set; } = null!;
        [ForeignKey("SchoolId")]
        [InverseProperty("Programs")]
        public virtual School School { get; set; } = null!;
        [InverseProperty("Program")]
        public virtual ICollection<Admittable> Admittables { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<BiodataApplicant> BiodataApplicants { get; set; }
        [InverseProperty("NewProgram")]
        public virtual ICollection<ChangeofCourseHistory> ChangeofCourseHistories { get; set; }
        [InverseProperty("NewProgram")]
        public virtual ICollection<ChangeofCourse> ChangeofCourses { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<DirectEntryAllCopy> DirectEntryAllCopies { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<DirectEntryAll> DirectEntryAlls { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<OnlineappAll> OnlineappAlls { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<PostutmeAllSecondCopy> PostutmeAllSecondCopies { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<PostutmeAllSecond> PostutmeAllSeconds { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<ProgramLevelSemester> ProgramLevelSemesters { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<ProgramLevel> ProgramLevels { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<YctTranscriptApp> YctTranscriptApps { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<YctpayPaymentBiodatum> YctpayPaymentBiodata { get; set; }
    }
}
