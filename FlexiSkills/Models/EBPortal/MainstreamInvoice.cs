using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Table("mainstream_invoice")]
    [Index("Username", Name = "UQ__password__F3DBC5723242405B", IsUnique = true)]
    public partial class MainstreamInvoice
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Key]
        [Column("username")]
        [StringLength(50)]
        [Unicode(false)]
        public string Username { get; set; } = null!;
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;
        [StringLength(255)]
        [Unicode(false)]
        public string StaffdName { get; set; } = null!;
    }
}
