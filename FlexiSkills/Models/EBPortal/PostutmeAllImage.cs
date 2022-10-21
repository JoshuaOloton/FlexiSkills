using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    public partial class PostutmeAllImage
    {
        [Key]
        [StringLength(10)]
        [Unicode(false)]
        public string UtmeNumber { get; set; } = null!;
        public byte[]? Image { get; set; }
    }
}
