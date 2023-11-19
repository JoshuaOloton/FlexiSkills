using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class PostutmeImage
    {
        [StringLength(10)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column(TypeName = "image")]
        public byte[] OldImage { get; set; } = null!;
        [Column("id")]
        public int Id { get; set; }
    }
}
