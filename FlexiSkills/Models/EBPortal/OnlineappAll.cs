using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("OnlineappAll")]
    [Index("ApplicationNumber", Name = "IX_OnlineappAll", IsUnique = true)]
    public partial class OnlineappAll
    {
        [Key]
        [StringLength(50)]
        [Unicode(false)]
        public string ApplicationNumber { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string? Othername { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string PhoneNumber { get; set; } = null!;
        [Column("ProgramID")]
        public int ProgramId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ApplicationDate { get; set; }
        [Column("SessionID")]
        public int SessionId { get; set; }
        [Column("PCCID")]
        public int? Pccid { get; set; }
        public int? NotAdmitable { get; set; }
        [Column("sexID")]
        public int? SexId { get; set; }

        [ForeignKey("ProgramId")]
        [InverseProperty("OnlineappAlls")]
        public virtual Program Program { get; set; } = null!;
        [ForeignKey("SessionId")]
        [InverseProperty("OnlineappAlls")]
        public virtual Session Session { get; set; } = null!;
    }
}
