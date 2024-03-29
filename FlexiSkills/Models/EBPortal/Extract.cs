﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("Extract")]
    public partial class Extract
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        [Column("progid")]
        public int? Progid { get; set; }
        [Column("id")]
        public int Id { get; set; }
    }
}
