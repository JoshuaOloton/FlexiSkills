using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("allusers")]
    public partial class Alluser
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("email")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Email { get; set; }
        [Column("phone")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Phone { get; set; }
        [Column("utmenumber")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Utmenumber { get; set; }
        [Column("active")]
        public int? Active { get; set; }
        [Column("verificationcode")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Verificationcode { get; set; }
        [Column("datecreated", TypeName = "date")]
        public DateTime? Datecreated { get; set; }
        [Column("paymentstatus")]
        public int? Paymentstatus { get; set; }
        [Column("surname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(50)]
        [Unicode(false)]
        public string? Firstname { get; set; }
    }
}
