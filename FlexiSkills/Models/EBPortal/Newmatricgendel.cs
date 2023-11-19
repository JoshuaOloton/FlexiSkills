using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("newmatricgendel")]
    public partial class Newmatricgendel
    {
        [StringLength(50)]
        public string? Appnum { get; set; }
        public int? ProgramId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? DateGen { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
