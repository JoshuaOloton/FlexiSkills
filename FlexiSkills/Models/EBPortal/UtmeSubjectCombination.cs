using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("UtmeSubjectCombination")]
    public partial class UtmeSubjectCombination
    {
        [StringLength(50)]
        [Unicode(false)]
        public string UtmeNumber { get; set; } = null!;
        [StringLength(500)]
        [Unicode(false)]
        public string SubjectComb { get; set; } = null!;
    }
}
