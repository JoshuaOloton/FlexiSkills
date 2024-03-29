﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class GenMatricno
    {
        [StringLength(50)]
        public string? Matricno { get; set; }
        public int? Progid { get; set; }
        [StringLength(50)]
        public string? Appnum { get; set; }
        [Column("id")]
        public int Id { get; set; }
        public int? Sessionid { get; set; }
    }
}
