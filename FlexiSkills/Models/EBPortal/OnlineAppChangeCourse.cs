using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FlexiSkills.Models.EBPortal
{
    [Keyless]
    [Table("onlineAppChangeCourse")]
    public partial class OnlineAppChangeCourse
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("appnum")]
        [StringLength(11)]
        [Unicode(false)]
        public string Appnum { get; set; } = null!;
        [Column("oldprogramid")]
        public int Oldprogramid { get; set; }
        [Column("newprogramid")]
        public int Newprogramid { get; set; }
        [Column("dateCorrected", TypeName = "datetime")]
        public DateTime DateCorrected { get; set; }
    }
}
