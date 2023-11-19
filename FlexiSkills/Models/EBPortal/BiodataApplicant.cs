using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("BiodataApplicant")]
    public partial class BiodataApplicant
    {
        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [Column("SexID")]
        public int? SexId { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Email { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Address { get; set; }
        [Column("POBID")]
        public int? Pobid { get; set; }
        [Column("LGAID")]
        public int? Lgaid { get; set; }
        [Column("PGName")]
        [StringLength(200)]
        [Unicode(false)]
        public string? Pgname { get; set; }
        [Column("PGAddress")]
        [StringLength(500)]
        [Unicode(false)]
        public string? Pgaddress { get; set; }
        [Column("PGPhone")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Pgphone { get; set; }
        [Column("NOK")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Nok { get; set; }
        [Column("NOKRelationship")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Nokrelationship { get; set; }
        [Column("NOKPhone")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Nokphone { get; set; }
        [Column("ProgramID")]
        public int? ProgramId { get; set; }
        [Column("SessionID")]
        public int? SessionId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? MaritalStatus { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? JambNum { get; set; }

        [ForeignKey("Lgaid")]
        [InverseProperty("BiodataApplicants")]
        public virtual Lga? Lga { get; set; }
        [ForeignKey("Pobid")]
        [InverseProperty("BiodataApplicants")]
        public virtual State? Pob { get; set; }
        [ForeignKey("ProgramId")]
        [InverseProperty("BiodataApplicants")]
        public virtual Program? Program { get; set; }
        [ForeignKey("SessionId")]
        [InverseProperty("BiodataApplicants")]
        public virtual Session? Session { get; set; }
        [ForeignKey("SexId")]
        [InverseProperty("BiodataApplicants")]
        public virtual Gender? Sex { get; set; }
    }
}
