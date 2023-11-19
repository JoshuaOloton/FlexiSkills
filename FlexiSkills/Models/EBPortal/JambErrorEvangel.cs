using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("JambErrorEvangel")]
    public partial class JambErrorEvangel
    {
        [Column("s/n")]
        [StringLength(255)]
        public string? SN { get; set; }
        [Column("regno")]
        [StringLength(255)]
        public string? Regno { get; set; }
        [Column("criteria")]
        [StringLength(255)]
        public string? Criteria { get; set; }
        [StringLength(255)]
        public string? Error { get; set; }
        [Column("surname")]
        [StringLength(255)]
        public string? Surname { get; set; }
        [Column("firstname")]
        [StringLength(255)]
        public string? Firstname { get; set; }
        [Column("othername")]
        [StringLength(255)]
        public string? Othername { get; set; }
        [Column("program")]
        [StringLength(255)]
        public string? Program { get; set; }
    }
}
