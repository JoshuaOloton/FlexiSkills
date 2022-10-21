using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class VwOnlineappPersonalinfo
    {
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [Column("GenderID")]
        public int GenderId { get; set; }
        [Column("DOB", TypeName = "date")]
        public DateTime Dob { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string Address { get; set; } = null!;
        [Column("BirthStateID")]
        public int BirthStateId { get; set; }
        [Column("LGAID")]
        public int Lgaid { get; set; }
        [Column("PGName")]
        [StringLength(200)]
        [Unicode(false)]
        public string Pgname { get; set; } = null!;
        [Column("PGAddress")]
        [StringLength(500)]
        [Unicode(false)]
        public string Pgaddress { get; set; } = null!;
        [Column("PGPhoneNumber")]
        [StringLength(50)]
        [Unicode(false)]
        public string PgphoneNumber { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CompleteDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string BirthState { get; set; } = null!;
        [Column("LGAName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Lganame { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string StateName { get; set; } = null!;
        [Column("StateID")]
        public int StateId { get; set; }
        [Column("ApplicationID")]
        public int ApplicationId { get; set; }
        [Column("BankID")]
        public int BankId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string ReceiptNumber { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string BankName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationCode { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string PhoneNumber { get; set; } = null!;
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("PCID")]
        public int Pcid { get; set; }
        [Column("PNID")]
        public int Pnid { get; set; }
        [Column("PTID")]
        public int Ptid { get; set; }
        [Column("SchoolID")]
        public int SchoolId { get; set; }
        [Column("PCName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcname { get; set; } = null!;
        [Column("PCAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pcacronym { get; set; } = null!;
        [Column("PTName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptname { get; set; } = null!;
        [Column("PNName")]
        [StringLength(50)]
        [Unicode(false)]
        public string Pnname { get; set; } = null!;
        [Column("PTAcronym")]
        [StringLength(50)]
        [Unicode(false)]
        public string Ptacronym { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string SchoolName { get; set; } = null!;
        [Column("program")]
        [StringLength(154)]
        [Unicode(false)]
        public string Program { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ApplicationDate { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string GenderName { get; set; } = null!;
    }
}
