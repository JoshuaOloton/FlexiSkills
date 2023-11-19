using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Maskprogid")]
    public partial class Maskprogid
    {
        public int? ProgId { get; set; }
        public int? MaskId { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
