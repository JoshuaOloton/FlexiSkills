using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    public partial class Outstudent
    {
        [StringLength(255)]
        public string? Matricno { get; set; }
        [StringLength(255)]
        public string? Name { get; set; }
        [StringLength(255)]
        public string? Dept { get; set; }
        [StringLength(255)]
        public string? Cgpa { get; set; }
        [Column("Phone_no")]
        [StringLength(255)]
        public string? PhoneNo { get; set; }
        [Column("e_mail address")]
        [StringLength(255)]
        public string? EMailAddress { get; set; }
    }
}
