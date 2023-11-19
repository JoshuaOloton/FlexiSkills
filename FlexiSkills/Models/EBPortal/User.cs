using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class User
    {
        [Key]
        [Column("UserID")]
        public int UserId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Surname { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string Firstname { get; set; } = null!;
        [Column("MembershipUserID")]
        [StringLength(50)]
        [Unicode(false)]
        public string MembershipUserId { get; set; } = null!;
        [Column("CreatedbyID")]
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedbyId { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
    }
}
