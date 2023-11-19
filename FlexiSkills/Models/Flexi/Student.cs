using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.Flexi
{
    [Table("student")]
    public partial class Student
    {
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("surname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [Column("firstname")]
        [StringLength(100)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [Column("matricno")]
        [StringLength(50)]
        [Unicode(false)]
        public string Matricno { get; set; } = null!;
        [Column("amount_paid")]
        public int AmountPaid { get; set; }
        [Column("is_submitted")]
        public byte IsSubmitted { get; set; }
        [Column("total_fees_due")]
        public int TotalFeesDue { get; set; }
        [Column("final_submission")]
        public byte FinalSubmission { get; set; }
        [Column("total_units")]
        public int TotalUnits { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("SemesterID")]
        public int SemesterId { get; set; }

        [InverseProperty("Student")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
